using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionarioPermanente = new Funcionario()
            {
                Nome = "João",
                Idade = 21,
                Cargo = "Desenvolvedor Junior",
                Tipo = "Periodo Integral"
            };

            Funcionario funcionarioPermanenteClone = (Funcionario)funcionarioPermanente.Clone();
            funcionarioPermanenteClone.Idade = 19;
            funcionarioPermanenteClone.Nome = "Henrique";

            Console.WriteLine("Detalhes do Funcionario Permanente");
            Console.WriteLine("Nome: {0}; Idade {1}; Cargo: {2}", funcionarioPermanente.Nome, funcionarioPermanente.Idade, funcionarioPermanente.Cargo);

            Console.WriteLine("Detalhes do Funcionario Permanente Clone");
            Console.WriteLine("Nome: {0}; Idade {1}; Cargo: {2}", funcionarioPermanenteClone.Nome, funcionarioPermanenteClone.Idade, funcionarioPermanenteClone.Cargo);

            Console.ReadKey();
        }
    }
}
