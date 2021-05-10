using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Exemplo2
{
    public class Culinaria : ICanal
    {
        const string canal = "Canal de Culinaria";
        const string status = "Receita de Bolo de Laranja.";
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
