using Ocp.Correto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp
{
    class Program
    {
        static void Main(string[] args)
        {
            Violacao();
            Correto();
        }

        static void Correto()
        {
            Car car = new Car("Azul", 2021, 2.0, 5, 4);
            car.ConfigureCar();

            Motorcycle motorcycle = new Motorcycle("Branco", 2023, 250);
            motorcycle.ConfigureMotorcycle();

            Console.ReadLine();
        }

        static void Violacao()
        {
            Violacao.EnumTypeVehicle type = Ocp.Violacao.EnumTypeVehicle.CAR;

            if (type == Ocp.Violacao.EnumTypeVehicle.CAR)
            {
                Violacao.Vehicle vehicle = new Violacao.Vehicle("Azul", 2021, 2.0, 5, 4);
                vehicle.Car();
            }
            else
            {
                Violacao.Vehicle vehicle = new Violacao.Vehicle("Branco", 2023, 250, 1, 0);
                vehicle.Motorcycle();
            }

            Console.ReadLine();
        }
    }
}
