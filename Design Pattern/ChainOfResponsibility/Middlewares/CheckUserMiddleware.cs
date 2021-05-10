using ChainOfResponsibility.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Middlewares
{
    class CheckUserMiddleware : Middleware
    {
        private Server server;

        public CheckUserMiddleware(Server server)
        {
            this.server = server;
        }

        public override bool Check(string email, string password)
        {
            if (!server.HasEmail(email))
            {
                Console.WriteLine("E-mail e/ou Senha invalidos!");
                return false;
            }

            if (!server.IsValidPassword(email, password))
            {
                Console.WriteLine("E-mail e/ou Senha invalidos!");
                return false;
            }

            return CheckNext(email, password);
        }
    }
}
