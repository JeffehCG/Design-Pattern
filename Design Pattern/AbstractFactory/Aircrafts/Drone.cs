using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Aircrafts
{
    class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando vento!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Encomenda pronta pra entrega! Ligando helices e camera!");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando entrega!");
        }
    }
}
