using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp_1
{
    class Program
    {
        public static double fce1(double x)
        {
            return Math.Pow(x, 2) + 8;
        }

        public static double fce2(double x)
        {
            return Math.Pow(x, 3) - 3;
        }

        static void Main(string[] args)
        {
            int choice = 0;

            while (choice != 3)
            {
                Console.WriteLine("Vyber si fci: ");
                Console.WriteLine("\t\t 1) x^2 + 8 ");
                Console.WriteLine("\t\t 2) x^3 - 3");
                Console.WriteLine("\t\t 3) Exit\n");

                choice = int.Parse(Console.ReadLine());
                double x = -1;

                Console.WriteLine();

                switch (choice)
                {
                    case 1:
                        while (x != 1.20)
                        {
                            Console.WriteLine("x = {0:f2}\t\t f(x) = {1:f2}", x, fce1(x));
                            x += 0.2;
                        }
                        break;
                    case 2:
                        while (x != 1.20)
                        {
                            Console.WriteLine("x = {0:f2}\t\t f(x) = {1:f2}", x, fce2(x));
                            x += 0.2;
                        }
                        break;
                }

                Console.ReadLine();
            }
        }
    }
}
