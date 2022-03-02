using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        public static int Děl(int a, int b)
        {
            if (a == b)
                return a;
            if (a > b)
                return Děl(a - b, b);
            else
                return Děl(a, b - a);
        }

        public static int NSD(int a, int b)
        {
            int ph;

            while (b != 0)
            {
                ph = a % b;
                a = b;
                b = ph;
            }

            return a;
        }

        static void Main(string[] args)
        {
            int x = 200;
            int y = 30;

            Console.WriteLine(Děl(x, y));
            Console.WriteLine(NSD(x, y));
            Console.ReadKey();
        }
    }
}
