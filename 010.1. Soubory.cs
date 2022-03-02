using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // PŘIDAT

namespace ConsoleApp_1
{
    class Program
    {
        // program zapíše do souboru 1 - 10
        static void Main(string[] args)
        {
            /* // Varianta FileStream

            FileStream FS = new FileStream(@"C:\Testing for Visual Studio\010.1 Soubory.txt", FileMode.Create);
            StreamWriter SW = new StreamWriter(FS);

            for (int i = 1; i <= 10; i++)
            {
                SW.WriteLine(i);
            }

            SW.Flush(); // Vyprázdnění buffru
            SW.Close(); // Uzavření časového proudu
            */

            using (StreamWriter SW = new StreamWriter(@"C:\Testing for Visual Studio\010.1 Soubory 3.txt"))
            {
                for (int i = 1; i <= 5; i++)
                {
                    SW.WriteLine(i);
                }
            }

            Console.ReadLine();
        
        }
    }
}
