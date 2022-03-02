using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    // 2. úkol - Naprogramujte metodu, která na základě kartézských souřadnic dvou bodů v rovině spočítá jejich vzdálenost. 
    // S pomocí této metody vytvořte program, který ze vstupu přečte souřadnice vrcholů trojúhelníka v rovině a spočítá velikosti všech tří jeho stran.

    class Program
    {
        public double Vzdálenost(double x1, double y1, double x2, double y2)
        {
            double x = Math.Abs(x2 - x1);
            double y = Math.Abs(y2 - y1);
            return (Math.Sqrt(x * x + y * y));
        }

        public void Test(double x1, double x2, double x3, double y1, double y2, double y3)
        {
            double C = Vzdálenost(x1, y1, x2, y2);
            double B = Vzdálenost(x1, y1, x3, y3);
            double A = Vzdálenost(x2, y2, x3, y3);

            Console.WriteLine("Délka strany A je: {0:F3}", A);
            Console.WriteLine("Délka strany B je: {0:F3}", B);
            Console.WriteLine("Délka strany C je: {0:f3}", C);
        }
    }

    class Výsledek
    {
        static void Main(string[] args)
        {
            Program Závěr = new Program();
            Console.WriteLine("Výsledek: {0:F4}", Závěr.Vzdálenost(5, 6, 7, 8));

            Závěr.Test(1, 2, 3, 4, 5, 6);

            Console.ReadLine();
        }
    }

  

}   

