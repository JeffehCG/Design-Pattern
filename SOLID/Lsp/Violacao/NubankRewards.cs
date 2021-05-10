using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Nessa caso o NubankRewards tambem é um metodo de pagamento, porem pode ser visto que ele não implementando a interface (IPaymentInstrument)
// Implemtado nos outros metodos, dessa forma, o principio LSP não poderia ser usado, pois como não a um contrato, os metodos estão com assinaturas diferentes
// e caso o objeto seja substituidos não ira conter as mesmas funcionalidades
namespace Lsp.Violacao
{
    class NubankRewards
    {
        public void CollectPaymentRewards()
        {
            Console.WriteLine("Pagamento realizado com sucesso!");
            Console.WriteLine("Pontuação creditada!");
        }

        public void ValidadeRewards()
        {
            Console.WriteLine("Limite OK, Rewards OK!");
        }
    }
}
