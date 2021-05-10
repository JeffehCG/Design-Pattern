using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class MercadoPago : IMercadoPago
    {
        private Token token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void MercadoPagoPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com Mercado Pago.");
        }

        public void MercadoPagoReceive()
        {
            Console.WriteLine("Recebendo pagamento com Mercado Pago.");
        }
    }
}
