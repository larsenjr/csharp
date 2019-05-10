using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oppgave3Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // Array som er definert i oppgaven. 

                int[] tallrekke = {1000, 90, 255, 150, 14, 25, 2, 580, 380, 400};

            // Brukes for å sjekke om verdien
                int temp;

            // En bubblesort
                for (int i = tallrekke.Length; i >= 1; i--)
                {
                    for (int j = 0; j < i - 1; j++)
                    {
                        if (tallrekke[j] > tallrekke[j + 1])
                        {
                            temp = tallrekke[j + 1];
                            tallrekke[j + 1] = tallrekke[j];
                            tallrekke[j] = temp;
                        }
                    }
                }

            // Skriver ut sortering. 
                Console.WriteLine("Her er de sorterte verdiene");

            // For-loop for å spesifisere at den skal starte på 0 og øke gradvis med 1 (ii++)
                for (int ii = 0; ii < tallrekke.Length; ii++)
                    
                    // Denne funksjonen skriver ut "Tall" samtidig som den bruker tallrekken jeg definerte tidligere. 
                {
                    Console.WriteLine($"Tall {ii} - Verdi \b {tallrekke [ii]}");
                }

            // En lettere måte å sortere Array på!

                Array.Sort(tallrekke);

            // Hvis man skal ha baklengs brukes:

                Array.Reverse(tallrekke);


            Console.ReadLine();
        }
    }

}
