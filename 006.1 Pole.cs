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
            int[] poleInt2 = new int[] { 8, -5, 7, 0, 4 };

            char[] pole_c = { 'a', 'b', 'c', 'd', 'e' };

            const int pocet = 5;

            Console.ReadLine();

            double[] pole = new double[5];  //definice pole

            //načtení pole
            Console.WriteLine("Zadej pět double čísel: ");
            for (int i = 0; i < 5; i++)
            {
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
