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
            
            int[] pole = new int[20];  //definice pole

            //Na vstupu je zadáno 20 celých čísel, načtěte je do pole a vytiskněte.
            Console.WriteLine("Zadej 20 celých čísel: ");
            for (int i = 0; i < 20; i++)
            {
                pole[i] = int.Parse(Console.ReadLine());
            }

            //Pak vypište nejprve dvojnásobky všech kladných čísel
            Console.WriteLine("\nDvojnásobky kladných čísel: ");
            for (int i = 0; i <= 19; i++)
            {
                if (pole[i] > 0)
                {
                    Console.WriteLine("{0} * 2 = {1}", pole[i], pole[i] * 2);
                }
            }


            //, a pak absolutní hodnoty všech záporných čísel.
            Console.WriteLine("\nAbsolutní hodnoty záporných čísel: ");
            for (int i = 0; i <= 19; i++)
            {   
                if (pole[i] < 0)
                {
                    int num = pole[i];
                    int abs = Math.Abs(num);
                    Console.WriteLine("|{0}| => {1}", pole[i], abs);
                }
            }
            Console.ReadLine();
            
            
           
            //*************************************************************************************************


            int[] Pole = new int[20];  //definice pole

            //Na vstupu je zadáno 20 celých čísel, načtěte je do pole a vytiskněte.
            Console.WriteLine("Zadej 20 celých čísel: ");
            for (int i = 0; i < 20; i++)
            {
                Pole[i] = int.Parse(Console.ReadLine());
            }

            //Pak vypište tato čísla uspořádána do následujícího pořadí: první, třetí, páté, ... , 
            //devatenácté, druhé, čtvrté, ... , dvacáté.
            for (int i = 0; i <= 19; i++)
            {
                if(i % 2 != 0)
                    Console.Write("{0}, ", Pole[i]);
            }

            for (int i = 0; i <= 19; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("{0}, ", Pole[i]);
                }
            }
            Console.ReadLine();
            
        }
    }
}
