using System;

namespace Ocp.Correto
{
    class Car : Vehicle
    {
        private int seats;
        private int doors;

        public Car(string color, int year, double engine, int seats, int doors)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;
            this.seats = seats;
            this.doors = doors;
        }

        public void ConfigureCar()
        {
            Console.WriteLine($"Criando um Carro {color}, {year}, {engine}, {seats} assentos e {doors} portas");
            StartVehicle();
        }
    }
}
