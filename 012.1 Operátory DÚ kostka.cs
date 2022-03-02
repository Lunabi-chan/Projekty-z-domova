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
        // metodu vytvořKostku, která vytvoří textový soubor kostka.txt obsahující 10 000 hodů kostkou

        static public void vytvořKostku(int y)
        {
            using (StreamWriter Txt = new StreamWriter(@"C:\Testing for Visual Studio\Duongová - Úkol kostka.txt"))
            {
                Random Dice = new Random();

                for (int i = 1; i <= 10000; i++)
                {
                    Txt.WriteLine("{0}", Dice.Next(1,7));
                }
            }
        }

        // metodu sečtiKostku, která bude vracet součet všech hodnot v souboru kostka.txt

        static public void sečtiKostku(string Cesta)
        {
            using (StreamReader SR = new StreamReader(Cesta))
            {
                int x;
                int Suma = 0;

                while ((x = SR.Read()) != -1)
                {
                    Suma = Suma + x;
                }

                Console.WriteLine("Součet: {0}", Suma);
                Console.ReadLine();
            }
        }

        // metodu tiskČetnosti, která bude počítat a tisknout kolikrát padl parametr (1..6) a kolik je to procent pokusů

        static public void tiskČetnosti(string z)
        {
            using (StreamReader SR = new StreamReader(z))
            {
                int x;
                int P = 10000;

                int a = 0; int b = 0; int c = 0; int d = 0; int e = 0; int f = 0;
                int A = 0; int B = 0; int C = 0; int D = 0; int E = 0; int F = 0; 

                while ((x = SR.Read()) != -1)
                {

                    switch (x)
                    {
                        case 1: a++; break;
                        case 2: b++; break;
                        case 3: c++; break;
                        case 4: d++; break;
                        case 5: e++; break;
                        case 6: f++; break;
                        default: Console.WriteLine("WHAT???"); break;
                    }
                }

                A = 100 / P * a;
                B = 100 / P * b;
                C = 100 / P * c;
                D = 100 / P * d;
                E = 100 / P * e;
                F = 100 / P * f;

                Console.WriteLine("Parametr 1 padl: {0}x\nParametr 2 padl: {1}x\nParametr 3 padl: {2}x\nParametr 4 padl: {3}x\nParametr 5 padl: {4}x\nParametr 6 padl: {5}x\n", a, b, c, d, e, f);
                Console.WriteLine("Pokusů pro 1 bylo: {0}%\nPokusů pro 2 bylo: {1}%\nPokusů pro 3 bylo: {2}%\nPokusů pro 4 bylo: {3}%\nPokusů pro 5 bylo: {4}%\nPokusů pro 6 bylo: {5}%\n", A, B, C, D, E, F);

                Console.ReadLine();
            }
        }

        static void Main(string[] args)
        {
            int x = 0;
            vytvořKostku(x);

            string cesta = @"C:\Testing for Visual Studio\Duongová - Úkol kostka.txt";
            sečtiKostku(cesta);

            tiskČetnosti(cesta);
        }
    }
}
