using Dip.Correto.Factory;
using Dip.Correto.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Pode ser visto que agora o principio Dip esta sendo utilizado de maneira correta,
// pois product não esta recendo uma instancia fixa,
// pode ser retornando tanto uma instancia de SQLServerProduct como de MongoDBProduct dependendo de qual estiver sendo utilizado
// E ambas classes estão implementando a interface IDbProduct

namespace Dip.Correto.Payments
{
    class PaymentProcess
    {
        public void Pay(string id)
        {
            IDbProduct product = DbProductFactory.Create();
            string productData = product.GetProductById(id);
            Console.WriteLine(productData);
        }
    }
}
