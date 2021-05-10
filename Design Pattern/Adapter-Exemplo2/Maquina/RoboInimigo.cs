using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Exemplo2
{
    // Esse classe é o nosso adaptee - o objeto que sera adaptado.
    public class RoboInimigo
    {
        Random gerador = new Random();

        public void EsmagarComMaos()
        {
            int danoAtaque = this.gerador.Next(10) + 1;
            Console.WriteLine($"O robo inimigo causou {danoAtaque} de dano com o ataque Esmagar com as Mãos!");
        }

        public void AndarComPernas()
        {
            int movimento = this.gerador.Next(10) + 1;
            Console.WriteLine($"O robo inimigo andou {movimento} passos para frente!");
        }

        public void Controlar(string piloto)
        {
            Console.WriteLine($"O robo esta sendo controlado por {piloto}!");
        }
    }
}
