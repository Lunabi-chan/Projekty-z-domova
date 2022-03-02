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
            // válec, V = pí*r^2*v, S= 2*pí*r*(r+v)
            Console.Write("Zadej poloměr válce: ");
            float r = float.Parse(Console.ReadLine());
            Console.Write("Zadej výšku válce: ");
            float v = float.Parse(Console.ReadLine());

            double objem = Math.PI * r * r * v;
            double obsah = 2 * Math.PI * r * (r + v);
            
            Console.WriteLine("Výsledek pro objem jehlanu je: {0:F3} cm3", objem);
            Console.WriteLine("Výsledek pro obsah jehlanu je: {0:F3} cm2", obsah);
            Console.WriteLine();


            // kvádr, V = a.b.c, S = 2.(ab+ac+bc)
            Console.Write("Zadej stranu a kvádru: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Zadej stranu b kvádru: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Zadej stranu c kvádru: ");
            int c = int.Parse(Console.ReadLine());

            int oBjem = a * b * c;
            int oBsah = 2 * (a * b + a * c + b * c);

            Console.WriteLine("Výsledky pro objem a obsah kvádru jsou {0} cm3 a {1}cm2", oBjem, oBsah);
            Console.WriteLine();


            //hranol V = Sp.v (a.b.v), S = 2.a.a + 4.a.v
            Console.Write("Zadej stranu a podstavce hranolu: ");
            int aa = int.Parse(Console.ReadLine());
            Console.Write("Zadej výšku hranolu: ");
            int vv = int.Parse(Console.ReadLine());

            int obJem = aa * aa * vv;
            int obSah = 2 * aa * aa + 4 * aa * vv;

            Console.WriteLine("Výsledek pro objem hranolu je: {0} cm3", obJem);
            Console.WriteLine("Výsledek pro obsah hranolu je: {0} cm2", obSah);
            Console.WriteLine();


            //???? jehlan, V = 1/3.a.a.v, S = a.a + 4.[v(troj).a]/2
            Console.Write("Zadej stranu a podstavce jehlanu: ");
            float aaa = float.Parse(Console.ReadLine());
            Console.Write("Zadej výšku jehlanu: ");
            float vvv = float.Parse(Console.ReadLine());
            Console.Write("Zadej výšku boční strany jehlanu: ");
            float vbs = float.Parse(Console.ReadLine());

            double objEm = (1 / 3) * aaa * aaa * vvv;
            double obsAh = aaa * aaa + 4 * vbs * aaa / 2;

            Console.WriteLine("Výsledek pro objem jehlanu je: {0} cm3", objEm);
            Console.WriteLine("Výsledek pro obsah jehlanu je: {0} cm2", obsAh);
            
            Console.ReadLine();
            Console.WriteLine();
        }
    }
}
