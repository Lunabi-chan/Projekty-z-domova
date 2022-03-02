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

            int i = 1;
            while (i <= 10)
            {
                Console.Write("{0}", i);
                i++;
            }
            Console.ReadLine();


            int j = 1;
            while (j <= 10)
            {
                Console.WriteLine("*");
                j++;
            }
            Console.ReadLine();



            Console.Write("Zadej počet čísel: ");
            int n = int.Parse(Console.ReadLine());

            int poč = 1;
            double součet = 0;

            while (n >= poč)
            {
                Console.Write("Zadej {0} celé číslo: ", poč);
                int číslo = int.Parse(Console.ReadLine());
                součet += číslo;
                poč++;
            }

            Console.WriteLine("Průměr: {0}", součet / n);
            Console.ReadLine();

        }
    }
}
