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
        //Delegát bude zastupovat parametr funkce a vracet double
        public delegate double DelFce(double x); // Deklarace delegáta; NEMÁ tělo! Musí mít stejnou signaturu jako metoda, kterou bude zastupovat

        public static double fce1(double x)
        { return Math.Pow(x, 1) + 1; }
        public static double fce2(double x)
        { return Math.Pow(x, 2) + 1; }
        public static double fce3(double x)
        { return Math.Pow(x, 3) + 1; }
        public static double fce4(double x)
        { return Math.Pow(x, 4) + 1; }

        //Parametry: dolní mez, horní mez, krok a fce
        public static void Tabelace(double dolní, double horní, double krok, DelFce f)
        {
            for (double i = dolní; i <= horní; i += krok)
            {
                Console.WriteLine("x = {0:f2} \t\t f(x) = {1:f2}", i, f(i));
            }
        }

        static void Main(string[] args)
        {
            double dolní = -5;
            double horní = 5;
            double krok = 0.5;

            Console.WriteLine("Vyber si fci: ");
            Console.WriteLine("\t\t 1) x + 1 ");
            Console.WriteLine("\t\t 2) x^2 + 1");
            Console.WriteLine("\t\t 3) x^3 + 1 ");
            Console.WriteLine("\t\t 4) x^4 + 1\n\n");

            int choice = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            if (choice == 1)
            {
                Tabelace(dolní, horní, krok, fce1);
            }
            if (choice == 2)
            {
                Tabelace(dolní, horní, krok, fce2);
            }
            if (choice == 3)
            {
                Tabelace(dolní, horní, krok, fce3);
            }
            if (choice == 4)
            {
                Tabelace(dolní, horní, krok, fce4);
            }

            Console.ReadLine();
        }
    }
}
