using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{    
    class Program
    {
        static public void VypisSeznamu(List<int> seznam)
        {
            Console.Write("Seznam: [ ");
            for (int i = 0; i < seznam.Count; i++)
            {
                Console.WriteLine("{0} ", seznam[i]);
            }
            Console.Write("]");

        }

        static public void PocetPrvku(List<int> seznam)
        {

        }

        static void Main(string[] args)
        {
            Random Dice = new Random();
            List<int> seznam = new List<int>();
            
            for (int i = 1; i <= 30; i++)
            {               
                seznam.Add(Dice.Next(1, 100));
            }

            Console.ReadLine();
        
        }
    }
}
