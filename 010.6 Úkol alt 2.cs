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
            //Z daného souboru celých čísel vytvořte jiný, který bude obsahovat vždy každé třetí číslo z původního souboru. 

            Random Dice = new Random();
            int t;
            int n = Dice.Next(2, 25);


            FileStream LM = new FileStream(@"C:\Testing for Visual Studio\Duongová - HW 2.0.txt", FileMode.Create);
            StreamWriter nana = new StreamWriter(LM);

            for (int i = 1; i <= n; i++)
            {
                t = Dice.Next(1, 100);
                nana.WriteLine("{0}\t", t);
            }

            nana.Flush();
            nana.Close();


            FileStream fsr = new FileStream("C:\\Testing for Visual studio\\Duongová - HW 2.0.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fsr);

            FileStream fsw = new FileStream(@"C:\Testing for Visual studio\Duongová - HW 2.5.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fsw);

            string h;
            int a = 3;

            for (int i = 1; i <= n; i++)
            {
                while ((h = sr.ReadLine()) != null)
                {
                    if (i == a)
                    {
                        Console.WriteLine(h);
                        sw.WriteLine(h);
                        a = a + 2;
                    }

                    else
                        break;

                }
            }

            sr.Close();
            sw.Close();


        }
    }
}
