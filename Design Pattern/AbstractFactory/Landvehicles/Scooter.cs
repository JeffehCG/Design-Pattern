using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Landvehicles
{
    class Scooter : ILandvehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Alimento recebido!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando entrega!");
        }
    }
}
