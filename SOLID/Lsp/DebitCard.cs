using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp
{
    class DebitCard : NubankCard
    {
        public override void Validade()
        {
            Console.WriteLine("Verificando saldo da conta...");
            Console.WriteLine("Saldo disponivel!");
        }
    }
}
