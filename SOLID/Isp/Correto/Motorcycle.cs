using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isp.Correto
{
    class Motorcycle : IVehicleMotorcycle
    {
        protected string color;
        protected int year;
        protected double engine;

        public Motorcycle(string color, int year, double engine)
        {
            ConfigureMotorcycle(color, year, engine);
        }

        public void ConfigureMotorcycle(string color, int year, double engine)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;

            Console.WriteLine($"Criando uma Moto {color}, {year}, {engine} cilindradas");
            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine($"Ligando os motores!");
        }
    }
}
