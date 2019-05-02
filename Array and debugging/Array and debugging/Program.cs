using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_and_debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tabell1 = new int[] { 1, 2, 3, };
            string[] tabellnavn = new string[] { "Marte", "Smokk", "Kåre" };
            for (int kuk = 0; kuk <tabell1.Length; kuk++)
            {
                    Console.WriteLine($"Arrayverdi er: {tabell1[kuk]}");
            }
            for (int kuk = 0; kuk <tabellnavn.Length; kuk++)
            {
                Console.WriteLine($"Arrayverdien er: {tabellnavn[kuk]}");
            }
            Console.ReadLine();
            
        }
    }
}
