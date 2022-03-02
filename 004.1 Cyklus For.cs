using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("YES");
            Console.WriteLine("YES");
            Console.WriteLine("YES");
            Console.WriteLine("NO");
            Console.WriteLine();

            for (int i = 0; i < 2; i++)
            {
               Console.WriteLine("YES");
            }
            Console.WriteLine("NO");
            Console.WriteLine();


            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} ", i);
            }
            Console.WriteLine();


            for (int i = 1; i <= 2; i++)
            for (int a = 1; a <= 10; a++)
            {
               Console.WriteLine("{0} * {1} = {2}", a, i, a * i);
            }
            Console.WriteLine();

            for (int i = 10; i <= 11; i++)
                for (int a = 90; a <= 100; a++)
                {
                    Console.WriteLine("{0} / {1} = {2}", a, i, a / i);
                }
            Console.WriteLine();

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine("{0}", i);
            }
            Console.WriteLine();

            Console.ReadLine();

            /* Cyklus for vytiskne 
             * samostatné řádky čísel kromě 5
            */

            for (int k = 0; k < 10; k++)
            {
                if (k == 5)
                    continue; // nebo break;

                Console.WriteLine("K = {0}", k);
            }
            Console.WriteLine();

            Console.ReadLine();

            for (int a = 0; a <= 5; a++)
            {
                for (int b = 1; b <= 6; b++)
                    Console.Write("*");
                Console.WriteLine();
            }

            Console.ReadLine();


        }
    }
}
