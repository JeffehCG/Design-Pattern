using Builder.Builders;
using Builder.Directors;
using Builder.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder = new VehicleBuilder();
            Director director = new Director(builder);

            director.ConstructSedanCar();
            Vehicle sedan = builder.GetVehicle();
            Console.WriteLine($"Criando um veiculo do tipo: {sedan.VehicleType}");

            director.ConstructTruck();
            Vehicle truck = builder.GetVehicle();
            Console.WriteLine($"Criando um veiculo do tipo: {truck.VehicleType}");

            director.ConstructSUV();
            Vehicle suv = builder.GetVehicle();
            Console.WriteLine($"Criando um veiculo do tipo: {suv.VehicleType}");

            Console.ReadLine();
        }
    }
}
