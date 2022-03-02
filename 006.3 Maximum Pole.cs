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
            int[] poleInt = new int[100];

            Random Dice = new Random();

            int poč = 0;
            for (int i = 0; i < 100; i++)
            {
                poleInt[i] = Dice.Next(1, 1001);
                Console.Write("{0, 4}", poleInt[i]);
            }

            //určení maxima
            int max = int.MinValue; //poleInt[0];
            for (int i = 0; i < 100; i++)
            {
                if (max < poleInt[i])
                {
                    max = poleInt[i];
                    poč = 1;

                }
                else if (max == poleInt[i])
                    poč++;
            }

            Console.WriteLine();
            Console.WriteLine("\nMaximální číslo je: {0}", max);
            Console.WriteLine("\nMaximální číslo se vyskytuje {0}-krát.", poč);

            Console.ReadLine();



        }
    }
}
