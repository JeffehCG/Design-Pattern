using Bridge.Platforms;
using Bridge.Transmissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            StartLive(new Youtube());
            StartLive(new Facebook());
            StartLiveAdvanced(new Twitch());
            StartLiveAdvanced(new DLive());

            Console.ReadLine();
        }

        static void StartLive(IPlatform plaform)
        {
            Console.WriteLine("Aguarde...");

            Live live = new Live(plaform);

            live.Broadcasting();
            live.Result();
        }

        static void StartLiveAdvanced(IPlatform plaform)
        {
            Console.WriteLine("Aguarde...");

            AdvancedLive live = new AdvancedLive(plaform);

            live.Broadcasting();
            live.Subtitle();
            live.Comments();
            live.Record();
            live.Result();
        }
    }
}
