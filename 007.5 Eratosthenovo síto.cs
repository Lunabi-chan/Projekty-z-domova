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
            /*
            // Zobrazíme prvočísla v rozmezí 1-1000
            int x = 1000;
            Prvocislo p = new Prvocislo(x);
            p.zobrazit();*/


            //ČZPZ(matrix[10,10]);

            int[,] matrix = new int[11, 11];
            bool[] prv = new bool[101];            
            int k = 1;

            // Vytvoření matice
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matrix[i, j] = k;
                    k++;
                }
            }
            Console.WriteLine("1");

            // Tisk matice
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                    if (matrix[i, j] != 1)
                    {
                        Console.Write("{0,5}", matrix[i, j]);
                    }
                    else
                        Console.Write("Jedna");
                Console.WriteLine();
            }
            Console.WriteLine("2");
         
            for(k = 1; k < 101; k++)
            {
                if (k < 2)
                    prv[k] = false;
                else if (k == 2)
                    prv[k] = true;
                else 
                    for (int l = 2; l <= Math.Sqrt(k); l++)
                    {
                        if ((k % l) == 0)
                        { prv[k] = false; }
                        else
                            prv[k] = true;
                    }
            }
            Console.WriteLine("4");

            k = 1;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write("{0,5} = {1}", matrix[i, j], prv[k]);
                    k++;
                }
                Console.WriteLine();
            }
            Console.WriteLine("5");

            int[] array = { 1, 3, 4, 5, 4, 2 };
            int item = 4;

            array = array.Where(e => e != item).ToArray();
            Console.WriteLine(String.Join(",", array));

            Console.ReadLine();
        }

    }  
}
