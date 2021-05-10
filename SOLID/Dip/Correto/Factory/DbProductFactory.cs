using Dip.Correto.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip.Correto.Factory
{
    class DbProductFactory
    {
        public static IDbProduct Create()
        {
            if(ConfigurationManager.AppSettings["DB"] == "SQLSERVER")
            {
                return new SQLServerProduct();
            }
            else
            {
                return new MongoDBProduct();
            }
        }
    }
}
