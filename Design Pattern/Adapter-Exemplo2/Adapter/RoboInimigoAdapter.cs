using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Exemplo2
{
    // Essa classe é o nosso adapter - o adaptador do objeto Robo com o Tanque
    public class RoboInimigoAdapter : IAtaqueInimigo
    {
        RoboInimigo robo;
        // Passa para o metodo construtor o robo que sera adaptado
        public RoboInimigoAdapter(RoboInimigo novo_rovo)
        {
            this.robo = novo_rovo;
        }

        public void ArmaFogo()
        {
            robo.EsmagarComMaos();
        }

        public void Movimenta()
        {
            robo.AndarComPernas();
        }

        public void Pilotar(string piloto)
        {
            robo.Controlar(piloto);
        }
    }
}
