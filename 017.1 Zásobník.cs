using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;

namespace ConsoleApp_1
{
    class Program
    {
        public static void Init(List<int> zásob)
        {
            zásob.Clear();  // Vymazání obsahu zásobníku
            zásob.Capacity = 5;
        }

        public static void Push(List<int> zásob, int x)
        {
            if (Full(zásob))
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write(" Error! Zásobník je plný!");     //Zásobník je prázdný
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;

                Console.ReadLine();
            }
            else
                zásob.Add(x);                                       //Přidání prvku na vrchol zásobníku
        }

        public static bool Empty(List<int> zásob)
        {
            return zásob.Count == 0;
        }

        public static bool Full(List<int> zásob)
        {
            return zásob.Capacity == zásob.Count;
        }

        public static int Pop(List<int> zásob)
        {
            int temp;

            if(Empty(zásob))
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Write("Error! Zásobník je prázdný!");   //Zásobník je prázdný
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;

                Console.ReadLine();
                return int.MinValue;
            }
            else
            {
                temp = zásob[zásob.Count - 1];      //Uschování prvku na vrcholu zásobníku
                zásob.RemoveAt(zásob.Count - 1);    //Odebírání prvku z vrcholu zásobníku
                return temp;
            }
        }

        static void Main(string[] args)
        {
            var List = new List<int>();

            Random dice = new Random();

            Init(List);

            int Choice = 0;

            while (Choice != 3)
            {
                Console.Clear();
                Console.WriteLine("## Práce se zásobníkem LIFO ##\n\n\t 1 .... Přidat prvek\n\t 2 .... Odebrat prvek\n\t 3 .... Ukončení programu");
                Console.WriteLine("\n");

                for (int i = List.Count - 1; i >= 0; i--)
                {
                    Console.Write("{0,5}", List[i]);
                }

                Console.Write("\n\nVáš výběr: ");
                Choice = int.Parse(Console.ReadLine());

                switch (Choice)
                {
                    case 1:
                        Push(List, dice.Next(1,100));
                        break;
                    case 2:
                        Pop(List);
                        break;
                    case 3: Environment.Exit(0);
                        break;
                    default: Console.WriteLine("Špatná hodnota."); break;
                }
            }

            Console.ReadLine();
        }

    }
}
