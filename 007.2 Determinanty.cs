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
            static void Tisk(int[,] mat)
            {
                for (int i = 0; i < mat.GetLength(0); i++)
                {
                    for (int j = 0; j < mat.GetLength(1); j++)
                    {

                        Console.Write("{0,5}", mat[i, j]);
                    }
                    Console.WriteLine();
                }
            }

            static void Main(string[] args)
            {
                const int m = 3;
                const int p = 4;
                const int n = 2;

                int[,] A = { { 2, -8, 7, 5 }, { -5, 12, 7, 6 }, { -6, -1, 0, -3 } };
                int[,] B = { { 7, -4 }, { 4, -11, }, { -1, 0, }, { 2, -1, } };
                int[,] C = new int[m, n];

                Random rnd = new Random();

                // A
                Console.WriteLine(" ---- Matice A: {0}/{1} ---- \n", m, p);
                Tisk(A);

                // B
                Console.WriteLine(" ---- Matice B: {0}/{1} ---- \n", p, n);
                Tisk(B);


                for (int i = 0; i < m; i++) //Součin matic
                {
                    for (int j = 0; j < n; j++)
                    {
                        for (int k = 0; k < p; k++)
                        {
                            C[i, j] += A[i, k] * B[k, j];
                        }
                    }
                }

                Console.WriteLine(" ---- Matice C = A * B {0}/{1} ---- \n", m, n);
                Tisk(C);


            }
    }
}
