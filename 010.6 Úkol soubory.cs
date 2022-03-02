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
            // Program zkopíruje vstup.txt na vystupVelka.txt a převede všechna písmena na velká. 

            FileStream FS = new FileStream(@"C:\Testing for Visual Studio\Huh.txt", FileMode.Create);
            StreamWriter TxtS1 = new StreamWriter(FS);

            for (int i = 97; i <= 122; i++)
            {
                TxtS1.Write("{0}\t", Convert.ToChar(i));
            }

            TxtS1.Flush();
            TxtS1.Close();

            FileStream fsr = new FileStream(@"C:Testing for Visual studio\Huh.txt", FileMode.Open);
            StreamReader sr = new StreamReader(fsr);

            FileStream fsw = new FileStream(@"C:Testing for Visual studio\Huh2.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fsw);

            string řádek;
            while ((řádek = sr.ReadLine()) != null)
            {
                Console.WriteLine(řádek); 
                sw.WriteLine(řádek.ToUpper()); //Tady toto

            }

            sr.Close();
            sw.Close();

        }
    }
}
