using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        class Volat
        {   
            public string Test(int porovnání)
            {
                if (porovnání == 0)
                    return "0";
                else if (porovnání < 0)
                    return "-1";
                else
                    return "1";
            }
            static void Swap(ref int x, ref int y)
            {
                if (x > y)
                {
                    int pom = x;
                    x = y;
                    y = pom;
                }
            }

            static void Main(string[] args)
            {
                Console.Write("Zadej 1. celé číslo: ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Zadej 2. celé číslo: ");
                int b = int.Parse(Console.ReadLine());

                Console.Write("Zadej 3. celé číslo: ");
                int c = int.Parse(Console.ReadLine());

                Console.WriteLine("\n--------------------------------------");

                Volat yes = new Volat();

                Console.WriteLine("\nSignum pro a = {0} je {1}", a, yes.Test(Math.Sign(a)));
                Console.WriteLine("Signum pro b = {0} je {1}", b, yes.Test(Math.Sign(b)));
                Console.WriteLine("Signum pro c = {0} je {1}", c, yes.Test(Math.Sign(c)));

                Console.WriteLine("\n--------------------------------------");

                if (a > b)
                    Swap(ref a, ref b);
                if (a > c)
                    Swap(ref a, ref c); 
                if (b > c)
                    Swap(ref b, ref c); 

                Console.WriteLine("\nNejvětši číslo je {0}", c);
                
                Console.ReadLine();

            }
        }
    }
}
