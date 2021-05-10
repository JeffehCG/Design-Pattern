using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Exemplo2
{
    public class TanqueInimigo : IAtaqueInimigo
    {
        Random gerador = new Random();
        public void ArmaFogo()
        {
            int danoAtaque = this.gerador.Next(10) + 1;
            Console.WriteLine($"Tanque inimigo fez {danoAtaque} de dano!");
        }

        public void Movimenta()
        {
            int movimento = this.gerador.Next(5) + 1;
            Console.WriteLine($"Tanque inimigo andou {movimento} metros!");
        }

        public void Pilotar(string piloto)
        {
            Console.WriteLine($"{piloto} esta no comando do tanque agora!");
        }
    }
}
