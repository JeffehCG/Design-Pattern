using System;

namespace FactoryMethod_Exemplo2
{
    public class FactoryMethod
    {
        public IPersonagem Escolher_Personagem(string personagem)
        {
            switch (personagem)
            {
                case "Liu Kang": return new LiuKang();
                case "SubZero": return new SubZero();
                case "Scorpion": return new Scorpion();
                default: return null;
            }
        }
    }
}
