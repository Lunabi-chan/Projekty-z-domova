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
            Console.WriteLine("Vytiskni největší číslo");

            Console.Write("Zadej a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Zadej b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Zadej c: ");
            int c = int.Parse(Console.ReadLine());

            if (a < b)
                if (b < c)
                    Console.WriteLine("Největší číslo je {0}", c);
                else
                    Console.WriteLine("Největší číslo je {0}", b);
            else
                Console.WriteLine("Největší číslo je {0}", a);
            Console.ReadLine();

          


        }
    }
}
