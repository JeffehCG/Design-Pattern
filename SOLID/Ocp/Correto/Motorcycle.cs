using System;

namespace Ocp.Correto
{
    class Motorcycle : Vehicle
    {
        public Motorcycle(string color, int year, double engine)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;
        }

        public void ConfigureMotorcycle()
        {
            Console.WriteLine($"Criando uma Moto {color}, {year}, {engine} cilindradas");
            StartVehicle();
        }
    }
}
