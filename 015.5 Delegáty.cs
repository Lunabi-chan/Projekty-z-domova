using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections; // potřebný pro ArrayList

namespace ConsoleApp_1
{

    

    class Program
    {
        public delegate void Del();

        static void Main(string[] args)
        {
            Del egate = new Del(Pozdrav);
        
            egate += Mezera;
            egate += Koho;
            egate -= Koho;

            egate();
            Console.ReadLine();
        }

        static void Pozdrav()
        {
            Console.Write("Ahoj");
        }

        static void Mezera()
        {
            Console.Write(" ");
        }

        static void Koho()
        {
            Console.Write("všichni");
        }
    }

    class A
    {
        private ArrayList pole = new ArrayList();


    }
}
