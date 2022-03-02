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

            Console.WriteLine();
            Console.WriteLine("                                                      ASCII TABULKA");
            Console.WriteLine();
            Console.WriteLine("     ------------------------------------------------------------------------------------------------------------------");
            
            Console.Write("\t");

            for (int i = 32; i <= 255; i++)
            {
                Console.Write("{0}: {1}", i, Convert.ToChar(i));
                if (i == 255)
                    break;
                Console.Write(" \t");
            }
            Console.WriteLine("       ------------------------------------------------------------------------------------------------------------------");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadLine();

            /*for (int i = 32; i < 255; i++)
            {
                Console.Write((char)i);  //přetypování (typecasting)
                Console.Write(" ");
            }

            Console.ReadLine();
            */
        
        
        
        
        }   
        

        


    }
}
