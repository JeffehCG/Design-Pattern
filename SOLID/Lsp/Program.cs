using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// A classe CreditCard é uma herança da classe NubankCard(Implementa a interface IPaymentInstrument)
// E a classe NubankRewards tambem implementa a interface IPaymentInstrument
// O principio LSP é aplicado nesse caso, quando caso substituimos a classe CreditCard, pela NubankRewards
// é visualizado que o codigo permanece funcionando, pois as duas classes estão utilizando o mesmo contrato(IPaymentInstrument)
// e respeitando a assinatura
namespace Lsp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Correto

            //CreditCard card = new CreditCard();
            //DebitCard card = new DebitCard();
            Correto.NubankRewards card = new Correto.NubankRewards();

            card.Validade();
            card.CollectPayment();

            Console.ReadLine();

            // Violação

            Violacao.NubankRewards cards = new Violacao.NubankRewards();

            cards.Validade();
            cards.CollectPayment();

            Console.ReadLine();
        }
    }
}
