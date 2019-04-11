using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            /** Løsning fra tavla
             * int tall1
             * int tall2;
             * int svar;
             * tall1 = Convert.ToInt32(Console.ReadLine());
             * tall2 = Convert.ToInt32(Console.ReadLine());
             * svar = tall1 / tall2;
             * Console.WriteLine(svar);
             * Console.ReadLine();
             */

            // Skriver inn tall 1
            Console.WriteLine("Skriv inn ett tall");
            string numberOne = Console.ReadLine();

            // Skriver inn tall 2
            Console.WriteLine("Skriv inn ett nytt tall");
            string numberTwo = Console.ReadLine();

            // ExceptionHandling med "try" og catch(Exception ex)
            try
            {
                double one = Convert.ToDouble(numberOne);
                double two = Convert.ToDouble(numberTwo);

                Console.WriteLine("Result: " + one / two);
            }
            // Spesifikk catch. Forsøk på å dele på null
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Det ble forsøkt å dele på null \n" +ex.GetType());
            }

            // Hindrer å skrive inn tekst i en int.
            catch(FormatException ex)
            {
                Console.WriteLine("Du la inn en tekst \n" + ex.GetType());
            }

            // Generell "Exception" for variabelen ex. 
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadLine();
        }
    }
}
