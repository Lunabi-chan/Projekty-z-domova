using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        public static int Fib(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;
            else
                return (Fib(n - 1) + Fib(n - 2));
        }
        
        public static int Fibo(int ph)
        {
            int a = 0;
            int b = 1;
            int c = 0;

            for (int i = 2; i < ph; ++i)
            {
                c = a + b;
                a = b;
                b = c;
            }

            return c;
        }

        static void Main(string[] args)
        {
            int x = 1;

            Console.WriteLine(Fib(x));
            Console.WriteLine(Fibo(x));
            Console.ReadKey();
        }
    }
}
