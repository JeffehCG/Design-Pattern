using FactoryMethod.Factories;
using FactoryMethod.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Transport trasport = null;

            if (args.Length > 0 && args[0] == "--uber")
            {
                trasport = new CarTransport();
            }
            else if (args.Length > 0 && args[0] == "--log")
            {
                trasport = new MotorcycleTransport();
            }
            else if (args.Length > 0 && args[0] == "--eats")
            {
                trasport = new BicycleTransport();
            }
            else
            {
                Console.WriteLine("Selecione o tipo do serviço");
            }

            if(trasport != null)
            {
                trasport.StartTransport();
            }

            Console.ReadLine();
        }
    }
}
