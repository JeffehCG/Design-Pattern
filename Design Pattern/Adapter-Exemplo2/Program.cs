using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            TanqueInimigo tanque = new TanqueInimigo();
            Iniciar(tanque);

            RoboInimigo robo = new RoboInimigo();
            RoboInimigoAdapter roboAdapter = new RoboInimigoAdapter(robo);
            Iniciar(roboAdapter);

            Console.ReadKey();
        }

        public static void Iniciar(IAtaqueInimigo maquina)
        {
            maquina.Pilotar("Rodrigo");
            maquina.Movimenta();
            maquina.ArmaFogo();

            Console.WriteLine();
        }
    }
}
