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
        public delegate double PH(double a, double b);

        public static double Součet(double a, double b)
        { return a + b; }
        public static double Rozdíl(double a, double b)
        { return a - b; }
        public static double Součin(double a, double b)
        { return a * b; }
        public static double Podíl(double a, double b)
        { return a / b; }

        public static void Výpočet(double a, double b, string name, PH v)
        {
            Console.WriteLine("\t{0}: {1:f2}", name, v(a, b));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Zadej hodnoty A a B:");
            Console.Write("\ta = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("\tb = ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("\nVýpočty: ");
            Výpočet(a, b, "Součet", Součet);
            Výpočet(a, b, "Rozdíl", Rozdíl);
            Výpočet(a, b, "Součin", Součin);
            if (b == 0)
            {
                Console.WriteLine("\tPodíl: Nulou nelze dělit");
            }
                
            else if (b!=0)
            {
                Výpočet(a, b, "Podíl", Podíl);
            }
   
            

        }
    }
}
