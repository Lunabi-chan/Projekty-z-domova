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
            while (true)
            {
                //náhodně vygeneruje počet řádků A (1-10)
                //náhodně vygeneruje počet sloupců A(1 - 10)
                Random Dice = new Random();

                Console.WriteLine(" ---- Matice A ---- \n");

                int řádkyA = Dice.Next(1, 10);
                int sloupceA = Dice.Next(1, 10);

                int[,] matrixA = new int[řádkyA, sloupceA];


                //náhodně vygeneruje prvky matice A(1 - 99)
                //vytiskne matici A
                for (int i = 0; i < matrixA.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixA.GetLength(1); j++)
                    {
                        Console.Write("{0}\t", matrixA[i, j] = Dice.Next(1, 99));
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                //náhodně vygeneruje počet řádků B(1 - 10)
                //náhodně vygeneruje počet sloupců B(1 - 10)

                Console.WriteLine(" ---- Matice B ---- \n");

                int řádkyB = Dice.Next(1, 10);
                int sloupceB = Dice.Next(1, 10);

                int[,] matrixB = new int[řádkyB, sloupceB];


                //náhodně vygeneruje prvky matice B(1 - 99)
                //vytiskne matici B
                for (int i = 0; i < matrixB.GetLength(0); i++)
                {
                    for (int j = 0; j < matrixB.GetLength(1); j++)
                    {
                        Console.Write("{0}\t", matrixB[i, j] = Dice.Next(1, 99));
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();

                int[,] matrixC = new int[řádkyA, sloupceB];

                //zjistí, zda je možné vypočítat součin matic A *B
                //když
                //ano: vypočítá matici C = A * B, vytiskne ji a program čeká na ukončení stiskem klávesy
                //ne: celý program se opakuje

                if (sloupceA != řádkyB)
                {
                    Console.WriteLine("Matice se nedají vynásobit. Za chvíli se program znovu spustí.");
                    System.Threading.Thread.Sleep(3000);
                    Console.Clear();
                    continue;
                }

                else
                {
                    for (int i = 0; i < řádkyA; i++)
                    {
                        for (int j = 0; j < sloupceB; j++)
                        {
                            for (int k = 0; k < sloupceA; k++)
                            {
                                matrixC[i, j] += matrixA[i, k] * matrixB[k, j];
                            }
                        }
                    }

                }

                Console.WriteLine(" ---- Matice C ---- \n");
                for (int i = 0; i < řádkyA; i++)
                {
                    for (int j = 0; j < sloupceB; j++)
                    {
                        Console.Write("{0}\t", matrixB[i, j]);
                    }
                    Console.WriteLine();
                }

                Console.ReadLine();


            }
            

        }
    }
}
