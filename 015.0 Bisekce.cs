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
        public static double Bisekce(double a, double b, int poč)
        {
            double s = (a + b) / 2;
            double x = (b - a) / 2;

            Console.WriteLine("\t" + poč + "\n\t\ta: \t" + a + "\n\t\tc: \t" + s + "\n\t\tb: \t" + b + "\n\t\tfa: \t" + f(a) + "\n\t\tfs: \t" + f(s) + "\n\t\tfb: \t" + f(b) + "\n\t\tx: \t" + x);
            Console.WriteLine("\n");
            poč++;

            if (x < 0.03)
            {
                return 1;
            }
            if ((f(a) * f(s)) > 0)
            {
                a = s;
                return Bisekce(a, b, poč);
            }
            if ((f(b) * f(s)) > 0)
            {
                b = s;
                return Bisekce(a, b, poč);
            }
            else
                return 1;
        }

        static public double f(double x)
        {
            return Math.Pow(x, 3) + x - 1;
        }

        static void Main(string[] args)
        {
            double a = 0;
            double b = 1;
            
            int poč = 1;

            if (a > b)
                Console.WriteLine("Špatná hodnota, a musí být menší jak b.");
            else
                Bisekce(a, b, poč);
            
            Console.ReadLine();
        }
    }
}
