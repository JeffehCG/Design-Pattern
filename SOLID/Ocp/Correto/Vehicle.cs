using System;

namespace Ocp.Correto
{
    abstract class Vehicle
    {
        protected string color;
        protected int year;
        protected double engine;

        public void StartVehicle()
        {
            Console.WriteLine($"Ligando os motores!");
        }
    }
}
