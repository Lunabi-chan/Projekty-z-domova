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
            Console.WriteLine();
            Console.WriteLine();

            //Náhodně vygeneruje počet řádků + sloupců 
            Random Dice = new Random();

            int řádky = Dice.Next(1, 10);
            int sloupce = Dice.Next(1, 10);

            int[,] matrix = new int[řádky, sloupce];


            // Náhodně vygeneruje prvky matice + tisk
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("[{0}, {1}]: {2}\t", i, j, matrix[i, j] = Dice.Next(1, 99));
                }
                Console.WriteLine();
            }

            //Určení minima + kolikrát se vyskytuje
            int o = 0;
            int p = 0;
            int minN = int.MaxValue;
            int poč = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (minN > matrix[i, j])
                    {
                        minN = matrix[i, j];
                        o = i;
                        p = j;
                    }

                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (minN == matrix[i, j])
                    {
                        poč++;
                    }

                }
            }


            //Určení maxima + kolikrát se vyskytuje
            int x = 0;
            int y = 0;
            int maxN = int.MinValue;
            int počet = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (maxN < matrix[i, j])
                    {
                        maxN = matrix[i, j];
                        x = i;
                        y = j;
                    }
                    
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if  (maxN == matrix[i, j])
                    {
                        počet++;
                    }

                }
            }

            // vytiskne součet všech prvků matice.
            int sou = 0;
            for (int j = 0; j < matrix.GetLength(1); j++)
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    if (matrix[i, j] != 0)
                        sou += matrix[i, j];
                    else
                        break;
                }
            
            
            // Finále
            Console.WriteLine();
            Console.WriteLine("\nMinimální prvek je: [{0},{1}] = {2}", o, p, minN);
            Console.WriteLine("Vyskytuje se v matici: {0}-krát", počet);
            Console.WriteLine();
            Console.WriteLine("\nMaximální prvek je: [{0},{1}] = {2}", x, y, maxN);
            Console.WriteLine("Vyskytuje se v matici: {0}-krát", počet);
            Console.WriteLine();
            Console.WriteLine("\nSoučet všech prvků matice je: {0}", sou);
            Console.ReadLine();


        

        }
    }
}
