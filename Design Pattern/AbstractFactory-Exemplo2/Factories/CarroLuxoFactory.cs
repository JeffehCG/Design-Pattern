using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Exemplo2
{
    class CarroLuxoFactory : CarroFactory
    {
        public override Som MonstarSom()
        {
            return new BluetoothPlayer();
        }

        public override Roda MontarRoda()
        {
            return new RodaLigaLeve();
        }
    }
}
