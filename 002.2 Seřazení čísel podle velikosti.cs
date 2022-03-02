using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seřazení čísel od největšího po nejmenší");

            Console.Write("Zadej a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Zadej b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Zadej c: ");
            int c = int.Parse(Console.ReadLine());
            int pom;

            if (a < b)
            {
                pom = a;
                a = b;
                b = pom;
            }
            if (a < c)
            {
                pom = a;
                a = c;
                c = pom;
            }
            if (b < c)
            {
                pom = b;
                b = c;
                c = pom;
            }

            Console.WriteLine("{0} > {1} > {2}", a, b, c);
            Console.ReadLine();
        
        }
    }
}
