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
            Random Dice = new Random();

            int[] Pole = new int[20];

            int a = Dice.Next(1, 19);

            for (int i = 0; i < a; i++)
            {
                Pole[i] = Dice.Next(1, 99);
               Console.Write("{0,5}", Pole[i]);
            }

            int poč = 0;
            int Max = int.MinValue;
            for (int i = 0; i < a; i++)
            {
                if (Max < Pole[i])
                {
                    Max = Pole[i];
                    poč = 1;
                }
                else if (Max == Pole[i])
                    poč++;
            }

            Console.WriteLine();
            Console.WriteLine("\nMaximální číslo: {0}", Max);
            Console.WriteLine("\nvyskytuje se zde {0}-krát", poč);

            Console.ReadLine();

        }
    }
}
