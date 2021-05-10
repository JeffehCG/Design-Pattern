using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Exemplo2
{
    public interface IAtaqueInimigo
    {
        void ArmaFogo();
        void Movimenta();
        void Pilotar(string piloto);

    }
}
