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

        static double What(double a, double e)
        {
            return (a / e);
        }

        static double LichoběžníkovoPravidlo(double a, double b, double n)
        {
            double součet = 0;      // součet fčních hodnot
            double x = a;           // bod, ve kterém se počítá fční hodnota pomocné proměnné pro výpočet

            double krokH = (b - a) / n;     // dělení intervalu
            součet = (f(a) + f(b)) / 2;     // 

            for (int i = 1; i < n; i++)
            {
                x += krokH;
                součet += f(x);
            }

            return součet * krokH;
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

            double d = (b-a) / c; // Krok
            double výsledek = 0;
            double ow = a;

            for (int i = 1; i < c; i++)
            {
                ow += d;
                výsledek += f(ow);
            }

            výsledek += What(f(a) + f(b), 2);

            double výs = d * výsledek;
            
            Console.WriteLine($"\n\nObsah obrazce ohraničeném grafem fce a osou x na intervalu <{a}; {b}> je: ");
            Console.WriteLine("lichoběžníkovou metodou: {0}", LichoběžníkovoPravidlo(a,b,c));
            Console.WriteLine($"Oof: {výs}");

        }
    }
}
