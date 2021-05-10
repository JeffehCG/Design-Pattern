﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Middlewares
{
    class CheckPermissionMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (email.Equals("master@gmail.com.br"))
            {
                Console.WriteLine("Seja bem vindo administrador");
                return true;
            }

            Console.WriteLine("Seja bem vindo!");

            return CheckNext(email, password);
        }
    }
}
