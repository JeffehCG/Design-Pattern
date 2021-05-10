using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Violação
            Violacao.Car car = new Violacao.Car("Azul", 2021, 4.0, 2, 2);
            Violacao.Motorcycle motorcycle = new Violacao.Motorcycle("Branco", 2021, 600);

            // Correto
            Correto.Car car2 = new Correto.Car("Azul", 2021, 4.0, 2, 2);
            Correto.Motorcycle motorcycle2 = new Correto.Motorcycle("Branco", 2021, 600);

            Console.ReadLine();
        }
    }
}
