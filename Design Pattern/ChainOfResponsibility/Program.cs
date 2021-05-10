using ChainOfResponsibility.Middlewares;
using ChainOfResponsibility.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        private static Server server;
        static void Init()
        {
            server = new Server();

            server.RegisterUser("master@gmail.com.br", "5354gi234hjk5hg");
            server.RegisterUser("user@gmail.com.br", "3552345324");

            Middleware middleware = new CheckUserMiddleware(server);
            Middleware middlewarePermission = new CheckPermissionMiddleware();

            middlewarePermission.LinkWith(new CheckWikiPasswordMiddleware());
            middleware.LinkWith(middlewarePermission);

            server.SetMiddleware(middleware);
        }

        static void Main(string[] args)
        {
            Init();

            Boolean done = false;

            do
            {
                Console.WriteLine("Digite o seu e-email:");
                string email = Console.ReadLine();

                Console.WriteLine("Digite a sua senha:");
                string password = Console.ReadLine();

                done = server.LogIn(email, password);
            } while (!done);

            Console.ReadLine();
        }
    }
}
