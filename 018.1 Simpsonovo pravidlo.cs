using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleApp_1
{
    class Program
    {
        static double f(double a)
        {
            return Math.Sin(a);
        }

        static double SimpsonovoPravidlo(double a, double b, double n)
        {
            double součet = 0;      // součet fčních hodnot
            double x = a;           // bod, ve kterém se počítá fční hodnota pomocné proměnné pro výpočet

            double krokH = (b - a) / n;     // dělení intervalu
            součet = f(a) + f(b);           // vložení fčních hodnot v krajních bodech intervalu

            for (int i = 1; i < n; i++)
            {
                x += krokH;

                if (i % 2 == 0) // (modulo)
                    součet += 2 * f(x);
                if (i % 2 != 0) // else
                    součet += 4 * f(x);
            }

            return součet * krokH/3;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\t NUMERICKÁ INTEGRACE");

            Console.Write("\n Zadej horní mez intervalu: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("\n Zadej dolní mez intervalu: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("\n Zadej dělení intervalu: ");
            double c = double.Parse(Console.ReadLine());

            Console.WriteLine($"\n\nObsah obrazce ohraničeném grafem fce a osou x na intervalu <{a}; {b}> je: ");
            Console.WriteLine("lichoběžníkovou metodou: {0}", SimpsonovoPravidlo(a,b,c));

        }
    }
}
