using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tast inn alder");
            var alder = Convert.ToInt32(Console.ReadLine());

            // Sjekker alder i forhold til tallet 1. Hvis tallet er under 1 viser den meldingen nedenfor. 
            if (alder < 1)
            {
                Console.WriteLine("Du bør være hjemme");
            }
            // Sjekker verdi i forhold til 1-5. Er tallet imellom disse vil den printe ut setningen nedenfor. 
            else if (alder >= 1 && alder < 6)
            {
                Console.WriteLine("Du er kanskje i barnehagen");
            }
            // Sjekker verdi i forhold til 6-12 år.
            else if (alder >= 6 && alder < 13)
            {
                Console.WriteLine("Du går på barneskolen");
            }
            // Sjekker verdi i forhold til 13 - 15
            else if (alder >= 13 && alder < 16)
            {
                Console.WriteLine("Du går på ungdomsskolen");
            }

            // Sjekker verdi i forhold til 16 - 18
            else if (alder >= 16 && alder < 19)
            {
                Console.WriteLine("Du går på videregående");
            }

            // Sjekker verdi i forhold til 19 og oppover til 45.  
            else if (alder >= 19 && alder < 45)
            {
                Console.WriteLine("Du gjennomfører høyere utdanning, er lærling eller jobber");
            }

            // Sjekker verdi fra 80 til 120. Nå er den kodet så den tar alle tall over 80. Så man kan skrive inn 2029 og man går fortsatt på "høyere utdanning".
            else if (alder >= 80 && alder < 120)
            {
                Console.WriteLine("Du er sannsynligvis død");
            }
            // Holder vinduet oppe når man har skrevet inn en verdi og kjører programmet i loop. 
            Main(args);
        }
    }
}
