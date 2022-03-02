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
        {return Math.Pow(x, 2) + 8;}
        public static double fce2(double x)
        {return Math.Pow(x, 3) - 3;}

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
            int choice = 0;

            Console.WriteLine("Vyber si fci: ");
            Console.WriteLine("\t\t 1) x^2 + 8 ");
            Console.WriteLine("\t\t 2) x^3 - 3");

            choice = int.Parse(Console.ReadLine());

            Console.WriteLine();

            //Instanciace delegáta
            DelFce deleg = new DelFce(fce1);

            if (choice == 1)
            {
                Tabelace(-1, 1, 0.2, fce1);
            }
            if (choice == 2)
            {
                Tabelace(-1, 1, 0.2, fce2);
            }

            Console.ReadLine();
        }
    }
}
