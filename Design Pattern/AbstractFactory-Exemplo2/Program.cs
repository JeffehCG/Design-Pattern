using System;

namespace AbstractFactory_Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = ExecutaAbstractFactory.MonstarCarro("luxo");

            Carro c2 = ExecutaAbstractFactory.MonstarCarro("popular");

            Console.ReadKey();
        }
    }
}
