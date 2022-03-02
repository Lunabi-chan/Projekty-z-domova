using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        public class TowersOfHanoi
        {
            private static void Tower(int n, int A, int C, int B)
            {
                if (n > 0)
                {
                    Tower(n - 1, A, B, C);
                    Console.WriteLine("Move disk from " + A + " to " + C);
                    Tower(n - 1, B, C, A);

                }
            }

            public static void Main(String[] args)
            {
                /*
                char A = 'A'; // start tower in output
                char C = 'C'; // end tower in output
                char B = 'B'; // temporary tower in output
                int Disks = 3; // number of disks

                Tower(Disks, A, C, B);
                */

                Console.Write("Zadej počet disků: ");
                int Number = int.Parse(Console.ReadLine());

                TowersOfHanoi.Tower(Number, 1, 3, 2);

                Console.ReadLine();
            }

            
        }

        
    }
}
