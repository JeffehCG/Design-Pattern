using Dip.Payments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dip
{
    class Program
    {
        static void Main(string[] args)
        {
            Violacao.Payments.PaymentProcess payment = new Violacao.Payments.PaymentProcess();
            payment.Pay("ABC123");

            Console.ReadLine();
        }
    }
}
