using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class MyClass
    {
        public int Val = 20; // inicializace satové složky
    }

    class Program
    {
        static void MyMethod(out MyClass f1, out int f2)
        {
            f1 = new MyClass();  // vytvoření instance třídy
            f1.Val = 25;         // přiřazení do datové složky
            f2 = 15;             // přiřazení do parametru
        }
        static void Main(string[] args)
        {
            MyClass a1 = null;
            int a2;
            MyMethod(out a1, out a2); // volání metody

            Console.ReadLine();
        }
    }
}
