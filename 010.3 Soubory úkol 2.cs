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
            // DÚ: Napište program, který vytvoří soubor n desetinných čísel. Vše určuje náhoda (obě verze: s FileStream, s příkazem using).

            Random Dice = new Random();
            float t;
            int n = Dice.Next(2, 100);
            int l = Dice.Next(2, 100);

            // Verze FileStream

            FileStream FS = new FileStream(@"C:\Testing for Visual Studio\Duongová - Úkol 2v1 Filestream.txt", FileMode.Create);
            StreamWriter TxtS3 = new StreamWriter(FS);

            for (int i = 1; i <= n; i++)
            {
                int Divisor = Dice.Next(1, 3);
                {
                    switch (Divisor)
                    {
                        case 1: Divisor = 10; break;
                        case 2: Divisor = 100; break;
                        case 3: Divisor = 1000; break;
                    }
                }
                t = Dice.Next(1, 100);
                TxtS3.Write("{0:f2}\t", t / Divisor);
            }

            TxtS3.Flush(); 
            TxtS3.Close(); 



            // Verze s příkazem using

            using (StreamWriter TxtS4 = new StreamWriter(@"C:\Testing for Visual Studio\Duongová - Úkol 2v2 příkaz using.txt"))
            {
                for (int i = 1; i <= l; i++)
                {
                    int Divisor = Dice.Next(1, 3);
                    {
                        switch (Divisor)
                        {
                            case 1: Divisor = 10; break;
                            case 2: Divisor = 100; break;
                            case 3: Divisor = 1000; break;
                        }
                    }
                    t = Dice.Next(1, 100);
                    TxtS4.Write("{0:f2}\t", t / Divisor);
                }
            }

            Console.ReadLine();

        }
    }
}
