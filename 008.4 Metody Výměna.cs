using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        // Program vymění hodnoty dvou promněných

        public static void Vymena(ref int x, ref int y)
        {
            int pom;

            pom = x;
            x = y;
            y = pom;
        }

        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            Console.WriteLine("a = {0}, b = {1}", a, b);
            Vymena(ref a, ref b);
            Console.WriteLine("a = {0}, b = {1}", a, b);

            Console.ReadLine();

        }
    }
}
