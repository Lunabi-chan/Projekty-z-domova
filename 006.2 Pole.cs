using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] pole = new double[5];  //definice pole

            //načtení pole
            //Console.Write("Zadej pět double čísel: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Zadej {0}. číslo: ", i + 1);
                pole[i] = double.Parse(Console.ReadLine());
            }

            //Tisk pole v obráceném pořadí
            for (int i = 4; i >= 0; i--)
            {
                Console.Write("{0,10}", pole[i]);
            }

            Console.ReadLine();


        }
    }
}
