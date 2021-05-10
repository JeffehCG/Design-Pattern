using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Exemplo2
{
    public class Documentario: ICanal
    {
        const string canal = "Canal de Documentarios";
        const string status = "A Origem de Tudo.";
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
