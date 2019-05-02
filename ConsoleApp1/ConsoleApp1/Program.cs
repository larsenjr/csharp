using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string tall1;
           // tall1 = Console.ReadLine();


            var tekst1 = Convert.ToDouble(Console.ReadLine());
            var tekst2 = Convert.ToDouble(Console.ReadLine());
            var tekst3 = Convert.ToDouble(Console.ReadLine());
            var tekst4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Summer er:" +(tekst1+tekst2+tekst3+tekst4));



            Console.ReadLine();
        }
    }
}
