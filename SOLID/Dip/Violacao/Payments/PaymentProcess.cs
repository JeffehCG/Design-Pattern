using Dip.Violacao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Modulo nivel Alto
// Pode ser visto que esta sendo violado o principio Dip pois essa classe de nivel alto
// esta dependendo de uma classe de nivel baixo "SQLServerProduct", que não faz parte da regra de negocio
// e sim define onde os dados estão armazenados

// O problema desse caso é que caso haja a necessidade de trocar o banco de dados da aplicação
// o codigo se encontra engessado, amarrado ao SQLServer.

// A forma correta é amarrar abstrações as classes de nivel alto

namespace Dip.Violacao.Payments
{
    class PaymentProcess
    {
        public void Pay(string id)
        {
            SQLServerProduct product = new SQLServerProduct();
            string productData = product.GetProductById(id);
            Console.WriteLine(productData);
        }
    }
}
