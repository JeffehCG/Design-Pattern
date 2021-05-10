using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Platforms
{
    class Twitch : IPlatform
    {
        public Twitch()
        {
            ConfigureRMTP();
            Console.WriteLine("Twitch: Transmissão Iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("Twitch: Autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Twitch: Configurando servidor RMTP.");
        }
    }
}
