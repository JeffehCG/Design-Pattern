using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartTv minhaTv = new SmartTv();
            Console.WriteLine("Selecione um canal");
            Console.WriteLine(" 1 - Filmes \n 2 - Documentarios. \n 3 - Culinaria");

            ConsoleKeyInfo input = Console.ReadKey();

            switch (input.KeyChar)
            {
                case '1':
                    minhaTv.CanalAtual = new Filme();
                    break;
                case '2':
                    minhaTv.CanalAtual = new Documentario();
                    break;
                case '3':
                    minhaTv.CanalAtual = new Culinaria();
                    break;
                default:
                    Console.WriteLine("Opção Invalida");
                    return;
            }

            minhaTv.ExibeCanalSintonizado();
            minhaTv.PlayTv();

            Console.ReadKey();
        }
    }
}
