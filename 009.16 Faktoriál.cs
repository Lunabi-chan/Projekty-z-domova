using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        public static int Fakt(int n)
        {
            if (n == 1)
                return 1;
            else
                return n * Fakt(n - 1);
        }

        public static int Fak(int ph, int a)
        {
            for (int i = 1; i <= ph; i++)
            {
                a = a * i;
            }

            return a;
        }

        static void Main(string[] args)
        {
            int x = 5;
            int y = 1;

            Console.WriteLine(Fakt(x));
            Console.WriteLine(Fak(x, y));
            Console.ReadKey();
        }
    }
}
