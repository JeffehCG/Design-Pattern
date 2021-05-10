using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class BolaSemSingleton
    {
        public BolaSemSingleton()
        {
            Console.WriteLine("Bola em Jogo!");
        }

        public void Mensagem(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
