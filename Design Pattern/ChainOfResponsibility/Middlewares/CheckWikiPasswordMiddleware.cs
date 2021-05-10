using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Middlewares
{
    class CheckWikiPasswordMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (password.Where(c => char.IsLetter(c)).Count() <= 0 || password.Where(c => char.IsNumber(c)).Count() <= 0)
            {
                Console.WriteLine("Sua senha é muita fraca, precisa ser alterada!");
            }

            return CheckNext(email, password);
        }
    }
}
