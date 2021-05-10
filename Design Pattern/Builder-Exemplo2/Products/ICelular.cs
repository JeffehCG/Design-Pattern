using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Exemplo2
{
    public interface ICelular
    {
        void BuildTela();
        void BuildBateria();
        void BuildSistema();
        void BuildCamera();

        Celular Celular { get; }
    }
}
