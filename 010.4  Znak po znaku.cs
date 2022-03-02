using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp_1
{
    class Program
    {
        // Čtení znak po znaku 
        private static void ČteníZnakPoZnaku(string cesta)
        {
            using (StreamReader sr = new StreamReader(cesta))
            {
                int znak;
                while ((znak = sr.Read()) != -1)
                {
                    Console.WriteLine("{0} . . {1}", znak, (char)znak);
                }
            }
        }

        // Čtení řádek po řádku
        private static void ČteníŘádekPoŘádku(string cesta)
        {
            using (StreamReader sr = File.OpenText(cesta))
            {
                string input;
                while ((input = sr.ReadLine()) != null)
                {
                    Console.WriteLine(input);
                }
                Console.WriteLine("Konec streamu bylo dosaženo");
            }
        }

        //Čtení celého souboru najednou
        private static void ČteníCeléhoSouboru(string cesta)
        {
            using (StreamReader sr = new StreamReader(cesta, Encoding.Default))
            {
                string input = sr.ReadLine();
                string input2 = sr.ReadToEnd();
                string input3 = sr.ReadToEnd();

                Console.WriteLine("Input: |{0}|", input);
                Console.WriteLine("Input2: |{0}|", input2);
                Console.WriteLine("Input3: |{0}|", input3);
            }
        }

        static void Main(string[] args)
        {
            // Po spuštění zmáčkni CTRL + F5

            string cesta = @"C:\Testing for Visual studio\Něco.txt";
            ČteníZnakPoZnaku(cesta);
            //ČteníŘádekPoŘádku(cesta);

            /*string NázevSouboru = @"C:\Testing for Visual studio\Něco.txt";

            if (! File.Exists(NázevSouboru))
            {
                Console.WriteLine("{0} neexistuje!", NázevSouboru);
                Console.ReadLine();
                return;
            }

            ČteníCeléhoSouboru(NázevSouboru);
            */
        }


    }
}
