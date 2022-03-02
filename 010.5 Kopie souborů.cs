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
        /*
         *  Program vytvoří kopii txt souboru
         *  po řádcích
         *  
         */

        static void Main(string[] args)
        {
            FileStream FSR = new FileStream("C:\\Testing for Visual studio\\010.1 Soubory.txt", FileMode.Open);
            FileStream FSM = new FileStream("C:\\Testing for Visual studio\\test kopie.txt", FileMode.Create);
            StreamReader SR = new StreamReader(FSR);
            StreamWriter SW = new StreamWriter(FSM);

            string sValue;
            while ((sValue = SR.ReadLine()) != null)
                SW.WriteLine(sValue);

            SW.Flush();

            SR.Close();
            SW.Close();


        }
    }
}
