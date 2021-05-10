using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Funcionario : IFuncionario
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Cargo { get; set; }
        public string Tipo { get; set; }
        public IFuncionario Clone()
        {
            // Efetua uma copia do proprio objeto convertendo para interface IFuncionario
            return this.MemberwiseClone() as IFuncionario;
        }
    }
}
