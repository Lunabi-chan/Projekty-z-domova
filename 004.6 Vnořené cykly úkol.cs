using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hello - H
            for (int hello = 0; hello <= 4; hello++)
            {
                for (int h1 = 0; h1 <= 4; h1++)
                {
                    Console.Write(" ");
                }
                for (int h2 = 1; h2 < 3; h2++)
                {
                    Console.Write(" *");
                }
                for (int h3 = 0; h3 <= 4; h3++)
                {
                    Console.Write(" ");
                }
                for (int h4 = 1; h4 < 3; h4++)
                {
                    Console.Write(" *");
                }
                System.Threading.Thread.Sleep(25);

                Console.WriteLine();
            }

            for (int hello = 0; hello <= 2; hello++)
            {
                for (int h1 = 0; h1 <= 2; h1++)
                {
                    Console.Write(" ");
                }
                for (int h2 = 1; h2 < 10; h2++)
                {
                    Console.Write(" *");
                    System.Threading.Thread.Sleep(25);
                }
                Console.WriteLine();
            }

            for (int hello = 0; hello <= 4; hello++)
            {
                for (int h1 = 0; h1 <= 4; h1++)
                {
                    Console.Write(" ");
                }
                for (int h2 = 1; h2 < 3; h2++)
                {
                    Console.Write(" *");
                }
                for (int h3 = 0; h3 <= 4; h3++)
                {
                    Console.Write(" ");
                }
                for (int h4 = 1; h4 < 3; h4++)
                {
                    Console.Write(" *");
                }
                System.Threading.Thread.Sleep(25);
                Console.WriteLine();
            }

            Console.WriteLine();

            // Hello - I
            for (int hello = 0; hello <= 10; hello++)
            {
                for (int h1 = 0; h1 <= 8; h1++)
                {
                    Console.Write(" ");
                }
                for (int h2 = 1; h2 < 3; h2++)
                {
                    Console.Write(" *");
                    System.Threading.Thread.Sleep(25);
                }
                
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();


            for (int i = 0; i <= 14; i++)
            {
                for (int j = 1; j <= 15 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" *");
                    System.Threading.Thread.Sleep(10);
                }

                Console.WriteLine();
            } 

            for (int řádek = 1; řádek <= 15; řádek++)
            {
                for (int sloupec = 1; sloupec <= 15; sloupec++)
                {
                    Console.Write(" *");
                    System.Threading.Thread.Sleep(5);

                }
                Console.WriteLine();
            }

            for (int i = 14; i > 0; i--)
            {
                for (int j = 15; j >= 1 + i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" *");
                    System.Threading.Thread.Sleep(10);
                }

                Console.WriteLine();

            }

            for (int i = 0; i <= 10; i++)
            {
                for (int j = 1; j <= 10 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" *");
                    System.Threading.Thread.Sleep(50);
                }

                Console.WriteLine();
            }

            for (int i = 9; i > 0; i--)
            {
                for (int j = 10; j >= 1 + i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" *");
                    System.Threading.Thread.Sleep(10);
                }

                Console.WriteLine();

            }

            for (int i = 0; i <= 10; i++)
            {
                for (int j = 1; j <= 10 + i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" *");
                    System.Threading.Thread.Sleep(25);
                }

                Console.WriteLine();

            }

            for (int i = 9; i > 0; i--)
            {
                for (int j = 1; j <= 10 + i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" *");
                    System.Threading.Thread.Sleep(25);
                }

                Console.WriteLine();

            }

            for (int i = 15; i > 0; i--)
            {
                for (int j = 1; j <= 10 + i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" *");
                    System.Threading.Thread.Sleep(10);
                }

                Console.WriteLine();

            }

            for (int i = 0; i <= 15; i++)
            {
                for (int j = 1; j <= 10 + i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" *");
                    System.Threading.Thread.Sleep(10);
                }

                Console.WriteLine();

            }

            // Lazy - L - copy kek

            for (int hello = 0; hello <= 8; hello++)
            {
                for (int h1 = 0; h1 <= 4; h1++)
                {
                    Console.Write(" ");
                }
                for (int h2 = 1; h2 < 4; h2++)
                {
                    Console.Write(" *");
                    System.Threading.Thread.Sleep(25);
                }

                Console.WriteLine();
            }

            for (int hello = 0; hello <= 2; hello++)
            {
                for (int h1 = 0; h1 <= 4; h1++)
                {
                    Console.Write(" ");
                }
                for (int h2 = 1; h2 < 10; h2++)
                {
                    Console.Write(" *");
                    System.Threading.Thread.Sleep(25);
                }
                Console.WriteLine();
            }


            // LAZY - A
            for (int i = 0; i <= 12; i++)
            {
                for (int j = 1; j <= 15 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" *");
                    System.Threading.Thread.Sleep(10);
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            // LAZY - Z
            for (int hello = 0; hello <= 2; hello++)
            {
                for (int h1 = 0; h1 <= 3; h1++)
                {
                    Console.Write(" ");
                }
                for (int h2 = 1; h2 < 8; h2++)
                {
                    Console.Write(" *");
                    System.Threading.Thread.Sleep(25);
                }
                Console.WriteLine();
            }


            for (int hello = 0; hello <= 8; hello++)
            {
                for (int h1 = 0; h1 <= 11 - hello; h1++)
                {
                    Console.Write(" ");
                }
                for (int h2 = 1; h2 < 4; h2++)
                {
                    Console.Write(" *");
                    System.Threading.Thread.Sleep(25);
                }

                Console.WriteLine();
            }

            for (int hello = 0; hello <= 2; hello++)
            {
                for (int h1 = 0; h1 <= 3; h1++)
                {
                    Console.Write(" ");
                }
                for (int h2 = 1; h2 < 8; h2++)
                {
                    Console.Write(" *");
                    System.Threading.Thread.Sleep(25);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            // LAZY - Y
            for (int i = 5; i > 0; i--)
            {
                for (int j = 3; j >= 2; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" *");
                    System.Threading.Thread.Sleep(10);
                }
                for (int j = 3; j >= 1 - i; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(" *");
                    System.Threading.Thread.Sleep(10);
                }
                Console.WriteLine();
            }

            for (int hello = 0; hello <= 8; hello++)
            {
                for (int h1 = 0; h1 <= 1; h1++)
                {
                    Console.Write(" ");
                }
                for (int h2 = 1; h2 < 5; h2++)
                {
                    Console.Write(" *");
                    System.Threading.Thread.Sleep(25);
                }

                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
