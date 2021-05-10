using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Payoneer : IPayoneerPayment
    {
        private Token token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePayment()
        {
            Console.WriteLine("Recebendo pagamento com Payoneer.");
        }

        public void SendPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com Payoneer.");
        }
    }
}
