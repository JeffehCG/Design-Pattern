using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Modulo nivel baixo
namespace Dip.Violacao.Model
{
    class SQLServerProduct
    {
        public string GetProductById(string id)
        {
            return $"SQLServer: Exibindo dados do produto {id}.";
        }
    }
}
