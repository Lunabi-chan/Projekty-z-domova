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
            //Napište program, který vytvoří matici 5x5 náhodných celých čísel 1 - 99 a vytiskne ji.
            // a který vytiskne maximální prvek matice a jeho indexy. [matice6.cs]

            Console.Write("Matice vytvoří 5x5 náhodných celých čísel");

            Console.WriteLine();
            Console.WriteLine();

            int[,] matrix = new int[5, 5];

            Random Dice = new Random();

            // Tisk matice
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("[{0}, {1}]: {2}\t", i, j, matrix[i, j] = Dice.Next(1, 99));
                }
                Console.WriteLine();
            }

            //Určení maxima
            int x = 0;
            int y = 0;
            int maxN = int.MinValue;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (maxN < matrix [i, j])
                    {
                        maxN = matrix[i, j];
                        x = i;
                        y = j;
                    }

                }
            }

            Console.WriteLine();
            Console.WriteLine("\nMaximální prvek je: [{0},{1}] = {2}", x, y, maxN);
            Console.ReadLine();

        }
    }
}
