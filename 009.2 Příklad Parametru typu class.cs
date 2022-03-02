﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class MyClass
    {
        public int Val = 20;
    }

    class Program
    {
        static void MyMethod(ref MyClass f1, ref int f2)
        {
            f1.Val = f1.Val + 5;
            f2 = f2 + 5;
            Console.WriteLine("f1.Val: {0}, f2: {1}", f1.Val, f2);
        }

        static void Main(string[] args)
        {
            MyClass a1 = new MyClass();
            int a2 = 10;
            MyMethod(ref a1, ref a2);
            Console.WriteLine("f1.Val: {0}, f2: {1}", a1.Val, a2);

            Console.ReadLine();

        }
    }
}
