using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static void ČtiOsobu(out string name, out int age)
        {
            Console.Write("Zadej své jméno: ");
            name = Console.ReadLine();
            Console.Write("Zadej svůj věk: ");
            age = int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {

            string jméno;
            int věk;
            ČtiOsobu(out jméno, out věk);
            Console.WriteLine();
            Console.WriteLine(jméno + " " + věk);

            Console.ReadLine();
        
        }
    }
}
