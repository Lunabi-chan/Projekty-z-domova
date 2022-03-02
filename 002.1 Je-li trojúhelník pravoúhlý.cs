using Microsoft.Win32;
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

            Console.WriteLine("Jedná se o pravoúhlý trojúhelník?");

            Console.Write("Zadej stranu a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Zadej stranu b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Zadej stranu c: ");
            double c = double.Parse(Console.ReadLine());
            double pom;

            if (c < b)
            { pom = c;
                c = b;
                b = pom; 
            }
            if (c < a) 
            { pom = c;
                c = a;
                a = pom;
            }

            if (Math.Pow(c, 2) == (Math.Pow(a, 2) + Math.Pow(b, 2)))
                Console.WriteLine("Ano, jedná se o pravoúhlý trojúhelník.");
            else
                Console.WriteLine("Ne, nejedná se o pravoúhlý trojúhelník.");
            Console.ReadLine();


           
        
        }
    }
}
