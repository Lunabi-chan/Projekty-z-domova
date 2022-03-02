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
            // Házení kostkou 
            Random Dice = new Random();

            for (int i = 1; i <= 100; i++)
            {
                
                Console.Write("{0, 5}", Dice.Next(1, 7));
            }

            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Vygenerovat náhodných 100 random čísel od 0 do 1000
            //Vytisknout max číslo a kolikrát se opakuje



        }
    }
}
