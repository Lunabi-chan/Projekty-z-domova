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
            //Zapište do textového souboru kompletní tabulku ASCII. Pro každý znak uložte jeho kód v desítkové i šestnáctkové soustavě.

            FileStream FS = new FileStream(@"C:\Testing for Visual Studio\Duongová - HW 3.txt", FileMode.Create);
            StreamWriter TxtS1 = new StreamWriter(FS);

            for (int i = 0; i <= 255; i++)
            {
                TxtS1.WriteLine("{0} . . . {1} . . . {2}\t", i, i.ToString("X"), Convert.ToChar(i));
            }

            TxtS1.Flush(); // Vyprázdnění buffru
            TxtS1.Close(); // Uzavření časového proudu
            


        }
    }
}
