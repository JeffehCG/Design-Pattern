using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory_Exemplo2
{
    public class ExecutaAbstractFactory
    {
        public static Carro MonstarCarro(string tipo)
        {
            CarroFactory cf = null;

            switch (tipo)
            {
                case "luxo":
                    cf = new CarroLuxoFactory();
                    break;
                case "popular":
                    cf = new CarroPopularFactory();
                    break;
            }

            Carro carro = new Carro();
            carro.roda = cf.MontarRoda();
            carro.som = cf.MonstarSom();

            return carro;
        }
    }
}
