using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
       
        
        //To samé, ale znovu
        class Solution
        {
            public static int Add(int a, int b)
            {
                return (a + b);
            }

            public static int Multip(int a, int b)
            {
                return (a * b);
            }

            public static int Minus(int a, int b)
            {
                return (a - b);
            }

            public static int Divide(int a, int b)
            {
                return (a / b);
            }
        }

        class Prog
        {
            static void Main(string[] args)
            {
                // instanciace třídy Výpočty
                Solution v = new Solution();

                // volání instančních metod
                Console.WriteLine("Součet je {0}", v.Součet(5, 3)); //nefunguje protože v Solutions nemůže být static
                Console.WriteLine("Součin je {0}", v.Součin(5, 3)); //nefunguje protože v Solutions nemůže být static

                // volání statických metod
                Console.WriteLine("Rozdíl je {0}", Solution.Minus(5, 3));
                Console.WriteLine("Podíl je {0}", Solution.Divide(5, 3));

                Console.ReadLine();
            }
        }


    
    }
}
