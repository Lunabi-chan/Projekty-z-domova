using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class TowerOfHanoi
    {
        int Discs;
        public TowerOfHanoi()
        {
            NumberOfDiscs = 0;
        }
        public TowerOfHanoi(int Val)
        {
            NumberOfDiscs = Val;
        }
        public int NumberOfDiscs
        {
            get
            {
                return Discs;
            }
            set
            {
                if (value > 0)
                    Discs = value;
            }
        }
        public void Relocate(int n, int A, int B, int C) 
        {   
            // A - Tower number 1 (starting tower)
            // B - Tower number 2 (helping tower)
            // C - Tower number 3 (where the discs should land)
            // n - amount of discs

            if (n > 0)
            {
                Relocate(n - 1, A, C, B);
                Console.WriteLine("Move disk {0} from tower {1} to tower {2}", n, A, B);
                Relocate(n - 1, C, B, A);
            }
        }
    }

    class Final
    {
        public static int Main()
        {
            TowerOfHanoi TOH = new TowerOfHanoi();

            Console.Write("Enter the number of discs: ");
            string a = Console.ReadLine();

            TOH.NumberOfDiscs = int.Parse(a);
            TOH.Relocate(TOH.NumberOfDiscs, 1, 3, 2);
            
            Console.ReadLine();
            return 0;
        }
    }
}
