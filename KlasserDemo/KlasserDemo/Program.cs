using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KlasserDemo
{
    class Person
    {
        public double Hoyde;
        public double Vekt;
        public string Haarfarge;

        public Person(double hoyde, double vekt, string haarfarge)
        {
            Hoyde = hoyde;
            Vekt = vekt;
            Haarfarge = haarfarge;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var bruker = new Person(195, 130, "Svart");

            Console.WriteLine($"Du er {bruker.Hoyde}cm høy, er dritfet med dine {bruker.Vekt}kg og har { bruker.Haarfarge}. hår");
            /*Console.WriteLine(bruker.Hoyde);
            Console.WriteLine(bruker.Vekt);
            Console.WriteLine(bruker.Haarfarge); */

            Console.ReadLine();
        }
    }
}
