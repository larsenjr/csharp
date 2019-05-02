using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Øvelse_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tall = new int[] { 7231,1123123,1205595,28828, 12 };
            // Array.Sort< int > (tall, new Comparison<int> ((i1, i2) => i2.CompareTo(i1)));
            Array.Sort(tall);
            Array.Reverse(tall);

            /* Metode 2
            for (int ii = 0; ii < tall.Length; ii++)
            {
                Console.WriteLine(tall[ii]);
            } */

            // Metode 1
            SkrivUt(tall);
            Console.ReadLine();

        }
        static void SkrivUt(int[] listemedtall)
        {
            foreach (var tall in listemedtall)
            {
                Console.WriteLine(tall);
            }
        }
    }
}
