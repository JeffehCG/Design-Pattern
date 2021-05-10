﻿using System;

namespace Singleton
{
    public sealed class Singleton // sealed - Impede que a classe seja herdada
    {
        private static Singleton instancia = null;

        public static Singleton GetInstancia 
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Singleton();
                    Console.WriteLine("Bola em jogo!");
                }

                return instancia;
            }
        }

        public void Mensagem(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
