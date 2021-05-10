using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Exemplo2
{
    public class SmartTv
    {
        // Aqui temos pontes (Bridge)
        public ICanal CanalAtual { get; set; }
        public void ExibeCanalSintonizado()
        {
            if(CanalAtual != null)
            {
                Console.WriteLine(CanalAtual.Canal());
            }
            else
            {
                Console.WriteLine("Por favor, selecione um canal!");
            }
        }

        public void PlayTv()
        {
            if (CanalAtual != null)
            {
                Console.WriteLine(CanalAtual.Status());
            }
            else
            {
                Console.WriteLine("Por favor, selecione um canal para assistir algo!");
            }
        }
    }
}
