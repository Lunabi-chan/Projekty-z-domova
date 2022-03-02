using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kruh0 k0 = new Kruh0(); //Kruh0() metoda = konstruktor třídy
            k0.poloměr = 10;
            Console.WriteLine("Plocha kruhu je " + k0.PLocha());

        }
    }
}
