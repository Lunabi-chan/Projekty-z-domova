using System;
using System.IO;

namespace ConsoleApp_1
{
    class Program
    {
        static public int ph = 0;

        static void Main(string[] args)
        {
            /* V daném textovém souboru určete počet slov, která začínají a končí stejným písmenem. 
             * Jednotlivá slova jsou od sebe oddělena mezerami a konci řádek.
             */

            string cesta = @"C:\Testing for Visual studio\Nový textový dokument.txt"; // Cesta do textu

            if (!File.Exists(cesta)) // Určení existence souboru
            {
                Console.WriteLine("Soubor neexistuje.");
                return;
            }

            using (StreamReader SR = new StreamReader(cesta)) 
            {            
                string řádek;
                while ((řádek = SR.ReadLine()) != null)
                {
                    řádek = řádek.ToLower();
                    string[] pole = řádek.Split(' ', '\n', '\t');

                    foreach (string pp in pole)
                    {
                        if (pp.Length < 2)
                            continue;
                        if (pp[0] == pp[pp.Length - 1])
                            Console.WriteLine("{0,5}. Slovo: {1}", ++ph, pp);
                    }
                }
            }

            Console.WriteLine("\n Počet slov se stejným znakem na začátku i na konci je: {0}", ph);
            Console.ReadLine();

        }
    }
}
