using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp_1
{

    class MatRov
    {        
        public static double fce1(double x)
        { return ((x + 1) / 3) + 1; }
        public static double fce2(double x)
        { return 2 * Math.Pow(x, 2) -11 * x + 14; }
        public static double fce3(double x)
        { return 4 * Math.Pow(x, 3) + 8 * Math.Pow(x, 2) -12 * x - 24; }
        public static double fce4(double x)
        { return -4 * Math.Pow(x, 4) + 2 * Math.Pow(x, 3) - 2 * Math.Pow(x, 2) + 3 * x - 1; }
    }

    class Program
    {
        //Delegát bude zastupovat parametr funkce a vracet double
        public delegate double DelFce(double x); // Deklarace delegáta;
                                                 // NEMÁ tělo! Musí mít stejnou signaturu jako metoda,
                                                        //kterou bude zastupovat

        //Parametry: dolní mez, horní mez, krok a fce
        public static void Hodnota(double x, string n, DelFce f)
        {
            Console.Write(n);
            Console.WriteLine(" = {0:f2}\n", f(x));
        }

        static void Main(string[] args)
        {
            string f1 = "\n\n\t\t 1) ((x + 1) / 3) + 1";
            string f2 = "\t\t 2)  2x^2 - 11x + 14";
            string f3 = "\t\t 3)  4x^3 + 8x^2 - 12x - 24";
            string f4 = "\t\t 4) -4x^4 + 2x^3 - 2x^2 + 3x - 1";

            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.WriteLine(f3);
            Console.WriteLine(f4 + "\n\n");

            Console.Write("\t\tZadej x: ");
            double x = double.Parse(Console.ReadLine());

            Hodnota(x, f1, MatRov.fce1);
            Hodnota(x, f2, MatRov.fce2);
            Hodnota(x, f3, MatRov.fce3);
            Hodnota(x, f4, MatRov.fce4);

            Console.ReadLine();
        }
    }
}
