using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class MyClass
    {
        public int Val = 20; // ke 3.
    }
    class Program
    {
        //1 -----------------------------------------------------------------------------------

        public static void parHod(int x)
        {
            Console.WriteLine("x = " + x);
            x = 9;
          
        }
        static void Main(string[] args)
        {
            int y = 5;
            parHod(y);
            Console.WriteLine("y = " + y);
        
        }


        //2 ------------------------------------------------------------------------------------

        static void Zvetsi(int cislo)
        {
            Console.WriteLine("Tisk ve funkci {0}\n", cislo);
            cislo++;
            Console.WriteLine();
            Console.WriteLine("Tisk ve funkci {0}\n", cislo);

        }

        static void Somehow(string[] args)
        {
            int i = 5;
            Console.WriteLine("i = " + i);
            Zvetsi(i);
            Console.WriteLine("i = " + i);
        }


        //3 --------------------------------------------------------------------------------------

        static void MyMethod(MyClass f1, int f2)
        {
            f1.Val = f1.Val + 5;
            f2 = f2 + 5;
            Console.WriteLine("f1.Val: {0}, f2: {1}", f1.Val, f2);
        }

        static void What()
        {
            MyClass a1 = new MyClass();
            int a2 = 10;
            MyMethod(a1, a2);
            Console.WriteLine("f1.Val: {0}, f2: {1}", a1.Val, a2);
        }
    }
}
