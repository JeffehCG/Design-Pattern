using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            ComSingleton();

            Console.WriteLine();

            SemSingleton();

            Console.ReadKey();
        }

        public static void ComSingleton()
        {
            Console.WriteLine("Com Singleton!");

            Singleton jogador_1 = Singleton.GetInstancia;
            jogador_1.Mensagem("Jogador 1: a bola esta comigo no meio do campo!");

            Singleton jogador_2 = Singleton.GetInstancia;
            jogador_2.Mensagem("Jogador 2: recebeu a bola");

            Singleton jogador_3 = Singleton.GetInstancia;
            jogador_3.Mensagem("Jogador 3: recebeu o lançamento na linha de fundo");
        }

        public static void SemSingleton()
        {
            Console.WriteLine("Sem Singleton!");

            BolaSemSingleton jogador_1 = new BolaSemSingleton();
            jogador_1.Mensagem("Jogador 1: a bola esta comigo no meio do campo!");

            BolaSemSingleton jogador_2 = new BolaSemSingleton();
            jogador_2.Mensagem("Jogador 2: recebeu a bola");

            BolaSemSingleton jogador_3 = new BolaSemSingleton();
            jogador_3.Mensagem("Jogador 3: recebeu o lançamento na linda de fundo");
        }
    }
}
