using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static public void Č1(int[,] A, int[,] B)
        {
            int[,] MATICE = { { B[0, 0], A[0, 1], A[0, 2] }, 
                              { B[1, 0], A[1, 1], A[1, 2] }, 
                              { B[2, 0], A[2, 1], A[2, 2] } };

            int výsledek = 0;
            
            int A1 = B[0, 0] * A[1, 1] * A[2, 2] 
                   + B[1,0] * A[1, 2] * A[2, 0] 
                   + B[2, 0] * A[1, 0] * A[2, 1]
                            - B[2, 0] * A[1, 1] * A[0, 2] 
                            - B[1, 0] * A[0, 1] * A[2, 2] 
                            - B[0, 0] * A[1, 2] * A[2, 1];

            int a = A[0, 0] * A[1, 1] * A[2, 2]
                  + A[1, 0] * A[1, 2] * A[2, 0] 
                  + A[2, 0] * A[1, 0] * A[2, 1]
                            - A[2, 0] * A[1, 1] * A[0, 2] 
                            - A[1, 0] * A[0, 1] * A[2, 2]
                            - A[0, 0] * A[1, 2] * A[2, 1];

            Console.WriteLine("x = {0}", výsledek = A1 / a);

        }

        static public void Č2(int[,] A, int[,] B)
        {
            int[,] MATICE = { { A[0, 0], B[0, 0], A[0, 2] }, 
                              { A[1, 0], B[1, 0], A[1, 2] }, 
                              { A[2, 0], B[2, 0], A[2, 2] } };

            int výsledek = 0;

            int A2 = A[0, 0] * B[1, 0] * A[2, 2] 
                   + A[1, 0] * B[2, 0] * A[0, 2] 
                   + A[2, 0] * B[0, 0] * A[1, 2]
                            - A[0, 0] * B[2, 0] * A[1, 2] 
                            - A[1, 0] * B[0, 0] * A[2, 2] 
                            - A[2, 0] * B[1, 0] * A[0, 2];

            int a = A[0, 0] * A[1, 1] * A[2, 2] 
                  + A[1, 0] * A[1, 2] * A[2, 0] 
                  + A[2, 0] * A[1, 0] * A[2, 1]
                            - A[2, 0] * A[1, 1] * A[0, 2] 
                            - A[1, 0] * A[0, 1] * A[2, 2] 
                            - A[0, 0] * A[1, 2] * A[2, 1];

            Console.WriteLine("y = {0}", výsledek = A2 / a);

        }

        static public void Č3(int[,] A, int[,] B)
        {
            int[,] MATICE = { { A[0, 0], A[0, 1], B[0, 0] },
                              { A[1, 0], A[1, 1], B[1, 0] }, 
                              { A[2, 0], A[2, 1], B[2, 0] } };

            int výsledek = 0;

            int A3 = A[1, 0] * A[2, 1] * B[0, 0]
                   + A[2, 0] * A[0, 1] * B[1, 0]
                   + A[0, 0] * A[1, 1] * B[2, 0]
                            - A[2, 0] * A[1, 1] * B[0, 0]
                            - A[0, 0] * A[2, 1] * B[1, 0]
                            - A[1, 0] * A[0, 1] * B[2, 0];

            int a = A[0, 0] * A[1, 1] * A[2, 2]
                  + A[1, 0] * A[1, 2] * A[2, 0]
                  + A[2, 0] * A[1, 0] * A[2, 1]
                            - A[2, 0] * A[1, 1] * A[0, 2]
                            - A[1, 0] * A[0, 1] * A[2, 2]
                            - A[0, 0] * A[1, 2] * A[2, 1];

            Console.WriteLine("z = {0}", výsledek = A3 / a);

        }

        static void Main(string[] args)
        {
            // Read and Print Matrix A ----------------------------------------------------------------------------------------------------------------

            int[,] A = new int[3, 3];
           
            Console.WriteLine("Zadej prvky soustavy matice A");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("[{0},{1}]: ", i, j);
                    A[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write("{0,5}", A[i, j]);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            // Read and Print Matrix B ----------------------------------------------------------------------------------------------------------------

            int[,] B = new int[3, 1];

            Console.WriteLine("Zadej vektory B pravé strany soustavy matice");

            for (int k = 0; k < 3; k++)
            {
                for (int l = 0; l < 1; l++)
                {
                    Console.Write("[{0},{1}]: ", k, l);
                    B[k, l] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();

            for (int k = 0; k < 3; k++)
            {
                for (int l = 0; l < 1; l++)
                    Console.Write("{0,5}", B[k, l]);
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Kořeny zadané soustavy jsou:");
            Č1(A, B);
            Č2(A, B);
            Č3(A, B);

            Console.ReadLine();

        }
    }
}
