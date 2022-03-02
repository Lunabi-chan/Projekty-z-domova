using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    { 
        // Tisk pole v obráceném pořadí
        /*static void Ehehe(int[] pole, int a)
        {
            


        }*/

        static void Main(string[] args)
        {
            Console.WriteLine("Kolik řad po čtyřech chcete zadat do hodnot?");
            Console.Write("Odpověď: ");
            int číslo = int.Parse(Console.ReadLine());

            int[] pole = new int[číslo];  // Definice pole       
            int[] mati = new int[číslo];  // Definice pole
            int[] answ = new int[číslo + 1];

            int o = 0;
            int p = 0;

            string mezera = " ";

            // Načtení pole
            for (int i = 0; i < číslo; i++)
            {
                Console.Write("Zadej {0}. číslo ze začátku 1. řady binárních čísel: ", i + 1);
                pole[i] = int.Parse(Console.ReadLine());

                if (pole[i] != 1 && pole[i] != 0 || číslo < 4)
                {
                    Console.WriteLine("Zadali jste nesprávnou hodnotu.");
                    return;
                }
            }

            Console.WriteLine();

            //Ehehe(pole, číslo);

            Array.Reverse(pole);

            for (int i = 0; i < číslo; i++)
            {
                Console.Write("Zadej {0}. číslo ze začátku 2. řady binárních čísel: ", i + 1);
                mati[i] = int.Parse(Console.ReadLine());

                if (mati[i] != 1 && mati[i] != 0 || číslo < 4)
                {
                    Console.WriteLine("Zadali jste nesprávnou hodnotu.");
                    return;
                }
            }

            for (int i = 0; i < číslo; i++)
            {
                if (i % 4 == 0)
                {
                    Console.Write("{0,5}", mezera);
                }
                Console.Write("{0,2}", pole[i]);
            }

            Console.WriteLine();

            for (int i = 0; i < číslo; i++)
            {
                if (i % 4 == 0)
                {
                    Console.Write("{0,5}", mezera);
                }
                Console.Write("{0,2}", mati[i]);
            }

            //Ehehe(mati, číslo);
            Array.Reverse(mati);


            for (int i = číslo - 1; i > 0; i--)
            {
                o = pole[i] + mati[i] + p;
                switch (o)
                {
                    case 1: answ[i] = 1; p = 0; break;
                    case 2: answ[i] = 0; p = 1; break;
                    case 3: answ[i] = 1; p = 1; break;
                    case 0: answ[i] = 0; p = 0; break;
                }
            }

            Console.WriteLine();

            for (int i = 0; i < číslo + 1; i++)
            {
                if (i % 4 == 0)
                {
                    Console.Write("{0,5}", mezera);
                }
                Console.Write("{0,2}", answ[i]);
            }

            Console.ReadLine();


        }
    }
}
