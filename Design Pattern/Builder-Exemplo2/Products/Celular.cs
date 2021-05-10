using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Exemplo2
{
    public class Celular
    {
        public Celular(string nome)
        {
            this.Nome = nome;
        }

        public string Nome { get; set; }
        public string Tela { get; set; }
        public string Bateria { get; set; }
        public string Sistema { get; set; }
        public string Camera { get; set; }
    }
}
