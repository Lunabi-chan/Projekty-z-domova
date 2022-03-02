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
        static void Main(string[] args)
        {
            // DÚ: Napište program, který zapíše do textového souboru 20 náhodných malých písmen (obě verze: s FileStream, s příkazem using)

            Random Dice = new Random();

            // Verze FileStream

           FileStream FS = new FileStream(@"C:\Testing for Visual Studio\Duongová - Úkol 1v1 Filestream.txt", FileMode.Create);
           StreamWriter TxtS1 = new StreamWriter(FS);

           for (int i = 1; i <= 20; i++)
           {
               TxtS1.Write("{0}\t", Convert.ToChar(Dice.Next(97, 122)));
           }

           TxtS1.Flush(); // Vyprázdnění buffru
           TxtS1.Close(); // Uzavření časového proudu
           


            // Verze s příkazem using

            using (StreamWriter TxtS2 = new StreamWriter(@"C:\Testing for Visual Studio\Duongová - Úkol 1v2 příkaz using.txt"))
            {
                for (int i = 1; i <= 20; i++)
                {
                    TxtS2.Write("{0}\t", Convert.ToChar(Dice.Next(97, 122)));
                }
            }

            Console.ReadLine();
        }
    }
}
