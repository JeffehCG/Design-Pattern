using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip.Correto.Model
{
    class MongoDBProduct : IDbProduct
    {
        public string GetProductById(string id)
        {
            return $"MongoDB: Exibindo dados do produto {id}.";
        }
    }
}
