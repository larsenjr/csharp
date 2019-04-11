using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] liste;
                liste = new int [8] {10, -10, 18, 17, 200, 51, 33, 73};
            int lengde = liste.Length;                    // Setter antall elementer i lista (array)
            int maxval = 0;
            for (int hei = 0; hei < lengde; hei++)
            {
                maxval = Max(maxval, liste[hei]);
            }
            for (int i = 0; i < lengde; i++)                                // Definerer i = 0 og om lengde er høyere enn variabelen "lengde"
            {
                float kjottkake = liste[i];                                 // Float definerer liste + 1
                double value = 0;                                           // Setter value til desimaltall som skrives ut når det kjøres. 

                Console.Write("Index: ");                                    // Skriver ut "Index" som settes sammen med "i" når det skrives ut. 
                Console.WriteLine(i);
                Console.Write("Case: ");                                     // Setter sammen Ordet "Case" og "kjottkake" verdi.
                Console.WriteLine(kjottkake);

                // Switchcase
                switch(i)
                {
                    case 0: // Ganger med 3
                        value = kjottkake * 3;
                        break;
                    case 1:
                        // Absolutt tall
                        value = Abs(kjottkake);
                        break;
                    case 2:
                        // Ganger med 5 og deler på 4. 
                        value = ((kjottkake * 5) / 4);
                        break;
                    case 3:
                        // Opphøyes med 3.
                        value = Pow(kjottkake,3);
                        break;
                    case 4:
                        // Kvadratrot av variabelen kjøttkake
                        value = Math.Sqrt(kjottkake);
                        break;
                    case 5:
                        // Differanse mellom tall som deles på 4
                        value = (int)kjottkake % 4;
                        break;
                    case 6:
                        // Høyeste verdi i listen
                        value = maxval;
                        break;
                    case 7:
                        // Deling på 2
                        value = (kjottkake / 2);
                        break;
                }
                Console.WriteLine(value);
            }
            Console.ReadLine();
        }
        /* alternativ 2 for å skrive ut.
        static void SkrivUt(int i, float tall)
        {
            if (i == 6)
            {
                Console.WriteLine($"{i} : Største verdien er: {tall} ");
            }
            else
            {
                Console.WriteLine($" {i} : {tall}");
            }
        }*/
    }
}
