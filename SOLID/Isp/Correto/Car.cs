using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isp.Correto
{
    class Car : IVehicleCar
    {
        protected string color;
        protected int year;
        protected double engine;
        private int seats;
        private int doors;

        public Car(string color, int year, double engine, int seats, int doors)
        {
            ConfigureCar(color, year, engine, seats, doors);
        }

        public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;
            this.seats = seats;
            this.doors = doors;

            Console.WriteLine($"Criando um Carro {color}, {year}, {engine}, {seats} assentos e {doors} portas");
            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine($"Ligando os motores!");
        }
    }
}
