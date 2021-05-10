using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            SemAdapter();

            ComAdapter();

            Console.ReadLine();
        }

        static void SemAdapter()
        {
            // Como pode ser visto abaixo, o novo metodo de pagamento tem nomes de metodos diferentes
            // Uma forma de resolver isso é utilizando o adapter 

            //PayPal payment = new PayPal();
            Payoneer payment = new Payoneer();

            //payment.PayPalPayment();
            //payment.PayPalReceive();

            payment.SendPayment();
            payment.ReceivePayment();
        }

        static void ComAdapter()
        {
            IPayPalPayment payment = new PayoneerAdapter(new Payoneer());
            payment.PayPalPayment();
            payment.PayPalReceive();

            payment = new MercadoPagoAdapter(new MercadoPago());
            payment.PayPalPayment();
            payment.PayPalReceive();
        }
    }
}
