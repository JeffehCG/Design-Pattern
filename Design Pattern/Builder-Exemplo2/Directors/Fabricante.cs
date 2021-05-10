using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Exemplo2
{
    public class Fabricante
    {
        public void Constructor(ICelular celularBuilder)
        {
            celularBuilder.BuildBateria();
            celularBuilder.BuildSistema();
            celularBuilder.BuildTela();
            celularBuilder.BuildCamera();
        }
    }
}
