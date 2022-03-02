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
        private static void ČteníZnakPoZnaku(string cesta)
        {
            using (StreamReader sr = new StreamReader(cesta))
            {
                // Program zkopíruje vstup.txt na vystupVelka.txt a převede všechna písmena na velká. 

                FileStream fsw = new FileStream(@"C:\Testing for Visual studio\Duongová HW - 1.5.txt", FileMode.Create);
                StreamWriter sw = new StreamWriter(fsw);

                int znak;
                while ((znak = sr.Read()) != -1)
                {
                    znak = znak - 32;
                    sw.Write("{0}\t", (char)znak);
                }

                sr.Close();
                sw.Close();

            }
        }
       
   

        static void Main(string[] args)
        {
            // Program zkopíruje vstup.txt na vystupVelka.txt a převede všechna písmena na velká. 
            
            FileStream FS = new FileStream(@"C:\Testing for Visual Studio\Duongová HW - 1.0.txt", FileMode.Create);
            StreamWriter TxtS1 = new StreamWriter(FS);

            for (int i = 97; i <= 122; i++)
            {
                TxtS1.Write("{0}\t", Convert.ToChar(i));
            }

            TxtS1.Flush();
            TxtS1.Close();


            string cesta = @"C:\Testing for Visual studio\Duongová HW - 1.0.txt";
            ČteníZnakPoZnaku(cesta);
            


        }
    }
}
