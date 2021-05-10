using System;

namespace Builder_Exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria o Fabricante
            Fabricante fabricante = new Fabricante();

            // Permite que a classe Builder esteja pronta
            ICelular celularBuilder = null;

            //Agora vamos criar um telefone Android
            celularBuilder = new AndroidBuilder();
            fabricante.Constructor(celularBuilder);
            Console.WriteLine("Um novo Celular foi construido: \n{0}", celularBuilder.Celular.Nome);

            Console.ReadKey();
        }
    }
}
