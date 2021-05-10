using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Exemplo2
{
    class CarroPopularFactory : CarroFactory
    {
        public override Som MonstarSom()
        {
            return new CDPlayer();
        }

        public override Roda MontarRoda()
        {
            return new RodaSimples();
        }
    }
}
