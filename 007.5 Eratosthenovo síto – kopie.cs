using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        public static bool prime(int a)
        {
            if (a < 2)
                return false;
            else if (a == 2)
                return true;
            else
                for (int i = 2; i <= Math.Sqrt(a); i++)
                {
                    if ((a % i) == 0)
                    { return false; }
                }
            return true;
        }

        static void Main(string[] args)
        {
            bool[] prv = new bool[1000];            
            int k = 1;
            string mezera = " ";

            k = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (k == 1)
                    {
                        Console.Write("{0, 5}", mezera);                        
                    }
                    else
                        Console.Write("{0,5}", k);
                    k++;
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\n");
            
            k = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    prv[k] = prime(k);
                    if (prv[k] == false)
                    {
                        Console.Write("{0, 5}", mezera);
                    }
                    else
                        Console.Write("{0,5}", k);
                    k++;
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }

    }  
}
