using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    /*class Determinanty
    {
        public static int det2(int[,] de) 
        {
            return (de[0, 0] * de[1, 1] - de[0, 1] * de[1, 0]);
        }

        public static int det3(int[,] de) 
        {
            return (de[0, 0] * de[1, 1] * de[2, 2] + de[0, 1] * de[1, 2] * de[2, 0] + de[0, 2] * de[1, 0] * de[2, 1] 
                      - de[0, 2] * de[1, 1] * de[2, 0] - de[0, 1] * de[1, 0] * de[2, 2] - de[0, 0] * de[1, 2] * de[2, 1]);
        }
    }

    // Poté napsat nakonec:
    Console.WriteLine("Determinant 2. řádu: "+ Determinant.det2(a));
    Console.WriteLine("Determinant 3. řádu: "+ Determinant.det3(b));

    */

    class Program
    {
        /* Další způsob
         * 
         * public static int det2(int[,] de)
         *{
         *    return de[0, 0] * de[1, 1] - de[0, 1] * de[1, 0];
         *}
         *
         * public static int det3(int[,] de) 
          {
            return de[0, 0] * de[1, 1] * de[2, 2] + de[0, 1] * de[1, 2] * de[2, 0] + de[0, 2] * de[1, 0] * de[2, 1] 
                      - de[0, 2] * de[1, 1] * de[2, 0] - de[0, 1] * de[1, 0] * de[2, 2] - de[0, 0] * de[1, 2] * de[2, 1];
          }
         *
         * // Poté napsat nakonec:
              Console.WriteLine("Determinant 2. řádu: "+ det2(a));
              Console.WriteLine("Determinant 3. řádu: "+ det3(b));
        */

        static void Main(string[] args)
        {
            int[,] a = new int[,] { { 3, 2 },
                                    { 1, 2 } };

            int[,] b = new int[,] { { 1, 2, 4},
                                    { 1, 4, 3},
                                    { 2, -2, -3} };

            // 3. způsob
            int det2 = a[0, 0] * a[1, 1] - a[0, 1] * a[1, 0];

            int det3 = b[0, 0] * b[1, 1] * b[2, 2] + b[0, 1] * b[1, 2] * b[2, 0] + b[0, 2] * b[1, 0] * b[2, 1]
                            - b[0, 2] * b[1, 1] * b[2, 0] - b[0, 1] * b[1, 0] * b[2, 2] - b[0, 0] * b[1, 2] * b[2, 1];
             

            Console.WriteLine("Determinant 2. řádu: "+ det2);
            Console.WriteLine("Determinant 3. řádu: "+ det3);

            Console.ReadLine();

        }
    }
}
