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
            // První úkol 

            while (true)
            {
                //Program pro čtení a tisk součinu matic. Rozměry matic si volí uživatel. 
                //Vše pomocí metod. Hlavní metoda bude obsahovat pouze volání metod

                Console.Write("Zadej počet řádků 1. matice: ");
                int řádky1 = int.Parse(Console.ReadLine());

                Console.Write("Zadej počet sloupců 1. matice: ");
                int sloupce1 = int.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Zadej počet řádků 2. matice: ");
                int řádky2 = int.Parse(Console.ReadLine());

                Console.Write("Zadej počet sloupců 2. matice: ");
                int sloupce2 = int.Parse(Console.ReadLine());

                Console.WriteLine();

                int[,] matrix1 = new int[řádky1, sloupce1];

                Random Dice = new Random();

                // Tisk matice
                Console.WriteLine(" ---- Matice 1 ---- \n");

                for (int i = 0; i < matrix1.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix1.GetLength(1); j++)
                    {
                        Console.Write("[{0}, {1}]: {2}\t", i, j, matrix1[i, j] = Dice.Next(1, 99));
                    }
                    Console.WriteLine();
                }

                int[,] matrix2 = new int[řádky2, sloupce2];

                // Tisk matice
                Console.WriteLine(" ---- Matice 2 ---- \n");

                for (int i = 0; i < matrix2.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix2.GetLength(1); j++)
                    {
                        Console.Write("[{0}, {1}]: {2}\t", i, j, matrix2[i, j] = Dice.Next(1, 99));
                    }
                    Console.WriteLine();
                }


                Console.WriteLine();
                Console.WriteLine(" ---- Matice C ---- \n");

                if (sloupce1 != řádky2)
                {
                    Console.WriteLine("Matice se nedají vynásobit. Za chvíli se program znovu spustí.");
                    Console.WriteLine("Sloupec v matici 1 musí být stejně velký jako řádky v 2. matici.");

                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    continue;
                }

                else
                {
                    for (int i = 0; i < řádky1; i++)
                    {
                        for (int j = 0; j < sloupce2; j++)
                        {
                            Console.Write("{0}\t", matrix2[i, j]);
                        }
                        Console.WriteLine();
                    }

                }

                Console.ReadLine();
            }


        }
    }
}
