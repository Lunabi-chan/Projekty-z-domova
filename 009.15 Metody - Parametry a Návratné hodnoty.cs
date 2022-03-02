using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        /*
        public static void BPBNH()
        {
            Console.WriteLine("Metoda bez parametrů a bez návratové hodnoty");
        }

        public static int BPSNH()
        {
            Console.WriteLine("Metoda bez parametrů s návratovou hodnotou");
            int ph = 13;
            return 2 * ph;
        }

        public static void SPBNH(int ph)
        {
            Console.WriteLine("Metoda s parametry a bez návratové hodnoty");
            bool answer = true;
            if (ph < 10)
                answer = true;
            else
                answer = false;
            Console.WriteLine("{0}", answer);
        }

        public static int SPSNH(int ph, int pp)
        {
            Console.WriteLine("Metoda s parametrem s návratovou hodnotou ");
            return ph + pp;
        }*/

        public static double Met(int ph, int pp, double hp)
        {
            hp = ph / pp;
            return hp;
        }


        static void Main(string[] args)
        {
            int x = 5;
            int y = 2;
            double z = 10;

            double b = x / y;
            
            Console.WriteLine(Met(x, y, z));
            Console.WriteLine(b);
            Console.ReadLine();
        
        }
    }
}
