using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Exemplo2
{
    public class Filme : ICanal
    {
        const string canal = "Canal de Filmes";
        const string status = "Os Vingadores";
        public string Canal()
        {
            return "Sintonizado no: " + canal;
        }

        public string Status()
        {
            return "Você esta assistindo - " + status;
        }
    }
}
