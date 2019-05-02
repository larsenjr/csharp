using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switchcase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tast inn tall fra 1 til 5");
            int tall1 = Convert.ToInt32(Console.ReadLine()); // Brukes til å "konvertere"
            switch (tall1)
            {
                case 1:
                    Console.WriteLine($"Apekatt {tall1}");
                        break;
                case 2:
                    Console.WriteLine($"Tallet er: {tall1}");
                    break;
                case 3:
                    Console.WriteLine($"Tallet er: {tall1}");
                    break;
                case 4:
                    Console.WriteLine($"Tallet er: {tall1}");
                    break;
                case 5:
                    Console.WriteLine($"Tallet er: {tall1}");
                    break;


            }
            Main(args); // Brukes til å kjøre programmet i Loop!
        }
    }
}
