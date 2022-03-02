using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    // 3. úkol - Napište program s metodou pro výpočet aritmetického průměru z hodnot uložených v poli (pole jako parametr).
    class Program
    {
        public double Průměr(double a, double b, double c, double d)
        {
            return (float)(a + b + c + d) / 4;
        }
        
    }

    class Výsledek
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Aritmetický průměr ze 4 čísel: 5, 6, 7, 8");

            Program Závěr = new Program();
            Console.WriteLine("Výsledek: {0}", Závěr.Průměr(5, 6, 7, 8));

            Console.ReadLine();

        }
    }
}
