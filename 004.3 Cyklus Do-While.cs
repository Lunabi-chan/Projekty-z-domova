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
            int počítadlo = 1;
            int součet = 0;

            do
            {
                součet += počítadlo;
                počítadlo++;
            } 
            
            while (počítadlo <= 100);
            Console.WriteLine("Součet čísel 1 - 100 je " + součet);
            Console.ReadLine();

            // ?????????????????


        }
    }
}
