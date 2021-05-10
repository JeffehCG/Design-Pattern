using AbstractFactory.App;
using AbstractFactory.Factories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Application app = ConfigureApplication();

            app.StartRoute();

            Console.ReadLine();
        }

        static Application ConfigureApplication()
        {
            Application app;

            ITransportFactory transportFactory = null;
            string company = "lime";

            if(company == "uber")
            {
                transportFactory = new UberTransport();
            }
            else if( company == "ninenine")
            {
                transportFactory = new NineNineTransport();
            }
            else if (company == "lime")
            {
                transportFactory = new LimeTransport();
            }

            app = new Application(transportFactory);

            return app;
        }
    }
}
