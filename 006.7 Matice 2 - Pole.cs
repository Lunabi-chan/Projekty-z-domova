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
            /*Napište program, který načte matici
             *typu čísel a vytiskne ji.
            */


            Console.Write("Zadej počet řádků: ");
            int početŘádků = int.Parse(Console.ReadLine());

            Console.Write("Zadej počet sloupců: ");
            int početSloupců = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[,] matrix = new int[početŘádků, početSloupců];

            // čtení matice
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("Zadej prvek [{0},{1}]: ", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            //Tisk matice
            for (int i = 0; i < početŘádků; i++)
            {
                for (int j = 0; j < početSloupců; j++)
                    Console.Write("{0,5}", matrix[i, j]);
                Console.WriteLine();
            }
            Console.ReadLine();
           
        
        }
    }
}
