using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sammenlignetallmedtotall
{
    class Program
    {
        static void Main(string[] args)
        {
            // Valgfritt - Eksisterer kun for at "æ, ø, å" vises i konsollvinduet riktig.!
            Console.OutputEncoding = Encoding.UTF8;

            // Setter nummer verdi som et tall som kan ha desimaler. 
            double nummer;

            /*Alternativ 2:
             * do
             * {
             * Console.WriteLine("Skriv inn ett tall");
             * nummer = double.Parse(Console.ReadLine());
             * Console.WriteLine(nummer);
             * } 
             * while (nummer < 5 || nummer 54.99);
             * Console.writeline("Tallet er gyldig {0}, nummer);
             * Alternativ 2 Stopp! 
             */

            // Skriver ut en melding om å skrive ut et nummer.
            Console.WriteLine("Slå inn ett tall.");

            // Setter "Skrivnummer" som en readline. 
            string Skrivnummer = Console.ReadLine();
            // Konverterer fra tekst til desimaltall. 
            bool resultat = false;

            while (!resultat)
            {
                // Prøver å konvertere fra tekst til desimaltall. 
                if (double.TryParse(Skrivnummer, out nummer))
                {
                    if (nummer < 5 || nummer >= 54.99)
                    {
                        Console.WriteLine($"Nummeret {nummer} er ikke gyldig - Prøv igjen");
                        
                        // Skriver ut nummer som er skrevet inn. 
                        Skrivnummer = Console.ReadLine();
                        continue;
                    }
                else
                {
                    resultat = true;
                    Console.WriteLine($"Nummeret {nummer} er gyldig");
                    Console.ReadKey(true);
                    break;
                }
                    Console.WriteLine($"Nummeret du skrev inn er: {nummer}");
                    Skrivnummer = Console.ReadLine();
                    break;
                }
            }
        }
    }
}