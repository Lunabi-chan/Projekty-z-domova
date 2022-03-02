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
             *typu 2/2 celých čísel a vytiskne ji.
            */

            int[,] matrix = new int[2, 2];

            // čtení matice
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("Zadej prvek [{0},{1}]: ", i, j);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            //Tisk matice
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write("{0,5}", matrix[i, j]);
                Console.WriteLine();
            }
            Console.ReadLine();
           
        
        }
    }
}
