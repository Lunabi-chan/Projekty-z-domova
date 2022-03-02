using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static int N(int pom, int a)
        {
            for (int i = 1; i <= pom; i++)
            {
                a = a * i;
            }

            return a;

            /*
             * if (pom == 0)
             *    return a = 1;
             * else
             *    return pom*N(pom - 1); ????
             */
        }

        static int Fibo(int pom, ref int a, ref int b)
        {
            int c;
            for (int i = 2; i < pom; ++i)
            {
                Console.Write("{0} ", c = a + b);
                a = b;
                b = c;
            }

            return a;

            /*
             * if (n == 0)
             *   return 0;
             * if (n == 1)
             *   return 1;
             * else 
             *   return N(pom - 1) ?????
             */

        }

        static int Fibo2(int pom)
        {
            int č1 = 0;
            int č2 = 1;
            int č3 = 0;

            for (int i = 2; i < pom; ++i)
            {
                č3 = č1 + č2;
                č1 = č2;
                č2 = č3;
            }

            return č3;
        }

        static int Dělitel(int a, int b)
        {
            int pom;

            while (b != 0)
            {
                pom = a % b;
                a = b;
                b = pom;
            }

            return a;

            /*
             * if (a == b)
             *   return ????????
             */
        }



        static void Main(string[] args)
        {
            
            { // Naprogramujte metodu s celočíselným parametrem n, která vrací n!.
                int a = 1;
                int číslo;

                Console.Write("Zadej číslo: ");
                číslo = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Factoriál z čísla {0} je {1}", číslo, N(číslo, a));
            }
            Console.ReadLine();
            Console.Clear();


            { // Naprogramujte metodu s celočíselným parametrem n, která tiskne prvních n-členů Fibonacciho posloupnosti.
                Console.WriteLine("Fibonacciho posloupnost");
                
                int č1 = 0;
                int č2 = 1;
                int číslo;

                Console.Write("Zadejte počet čísel: ");
                číslo = int.Parse(Console.ReadLine());

                Console.Write(č1 + " " + č2 + " ");
                Console.Write(Fibo(číslo, ref č1, ref č2) + " ");

            }
            Console.ReadLine();
            Console.Clear();


            { // Naprogramujte metodu s celočíselným parametrem n, která vrací n-tý člen Fibonacciho posloupnosti.
                Console.WriteLine("Fibonacciho posloupnost 2");

                int číslo;

                Console.Write("Zadejte kolikáté číslo z Fibonacciho posloupnosti chcete získat: ");
                číslo = int.Parse(Console.ReadLine());

                Console.Write("{0}", Fibo2(číslo));
            }
            Console.ReadLine();
            Console.Clear();


            { // Naprogramujte metodu NSD se dvěma celočíselnými parametry, která vrací největšího společného dělitele parametrů (Eukleidův algoritmus).
                int x, y;

                Console.WriteLine("Největší společný dělitel dvou čísel");
                Console.Write("1. číslo: ");
                x = int.Parse(Console.ReadLine());

                Console.Write("2. číslo: ");
                y = int.Parse(Console.ReadLine());

                Console.Write("\nNejvětší dělitel {0} a {1} je {2}", x, y, Dělitel(x, y));

                Console.ReadLine();

                return;
            }
        }

    }
}
