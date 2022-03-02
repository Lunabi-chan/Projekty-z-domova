using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        //	1.) zobrazit
        static public void VypisSeznamu(List<int> Seznam)
        {
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine(); Console.WriteLine();

            for (int i = 0; i < Seznam.Count; i++)
            {
                Console.WriteLine("\n[{0}]: {1}", i + 1, Seznam[i]);
            }
        } 
        
        //  2.) přidat další prvek
        static private void Pridat(List<int> Seznam, int n)
        {
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine(); Console.WriteLine();

            Seznam.Add(n);
        }

        // 3.) odebrat možnost
        static private void Odebrat(List<int> Seznam, int i)
        {
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine(); Console.WriteLine();

            Seznam.Remove(i);
        }

        //  4.) smazat seznam
        static private void Smazat(List<int> Seznam)
        {
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine(); Console.WriteLine();

            Seznam.Clear();
        }

        //  5.) seřadit vzestupně
        static private void SVzestupně(List<int> Seznam)
        {
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine(); Console.WriteLine();

            Seznam.Sort();
        }

        //  6.) seřadit sestupně
        static private void SSestupně(List<int> Seznam)
        {
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine(); Console.WriteLine();

            Seznam.Sort();
            Seznam.Reverse();
        }

        //  7.) otočit seznam
        static private void Otočení(List<int> Seznam)
        {
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine(); Console.WriteLine();

            Seznam.Reverse();
        }

        //	8.) vypsat počet prvků seznamu
        static private int PP(List<int> Seznam)
        {
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine(); Console.WriteLine();

            return Seznam.Count;
        }

        // 9.) vypsat nejmenší a největší prvek
        static private void MinMax(List<int> Seznam)
        {
            Console.WriteLine(); Console.WriteLine();
            Console.WriteLine(); Console.WriteLine();

            int Max = int.MinValue; 
            for (int i = 0; i < Seznam.Count; i++)
            {
                if (Max < Seznam[i])
                {
                    Max = Seznam[i];
                }
            }

            int Min = int.MaxValue; 
            for (int i = 0; i < Seznam.Count; i++)
            {  
                if (Min > Seznam[i])
                {
                    Min = Seznam[i];
                }
            }

            Console.WriteLine("\nNejvětší prvek v seznamu je: {0}", Max);
            Console.WriteLine("\nNejmenší prvek v seznamu je: {0}", Min);
        }


        static void Main(string[] args)
        {

            // - Titulní strana -
            Console.Clear();
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            Console.WriteLine(); Console.WriteLine();

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("                                  ———————————————————————————————————————————————————");
            Console.WriteLine("                                 |                                                   |");
            Console.WriteLine("                                 |        So you want to make your own list          |");
            Console.WriteLine("                                 |         that actually is premade so you           |");
            Console.WriteLine("                                 |              can't change anything?               |");
            Console.WriteLine("                                 |                                                   |");
            Console.WriteLine("                                 |                   How wonderful!                  |");
            Console.WriteLine("                                 |  This list maker is easy to work with. I think.   |");
            Console.WriteLine("                                 |          Just press any key to continue!          |");
            Console.WriteLine("                                 |                                                   |");
            Console.WriteLine("                                 |                   Let's begin!                    |");
            Console.WriteLine("                                 |                                                   |");
            Console.WriteLine("                                  ———————————————————————————————————————————————————");

            Console.WriteLine("");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                Press ENTER to continue");

            Console.ReadLine();
            Console.Clear();

            // ---------------------------------------------------------------
  
            Random Dice = new Random();

            List<int> PlaceHolder = new List<int>();

            int x = Dice.Next(1, 30);

            for (int i = 1; i <= x; i++)
            {
                PlaceHolder.Add(Dice.Next(1, 100));
            }

            // ---------------------------------------------------------------

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();

            int Choice = 0;
           
            while (Choice != 12)
            {

                Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();

                Console.WriteLine("                     ————————————————————————————————————————————————————————————————————————————————");
                Console.WriteLine("                    |                                                                                |");
                Console.WriteLine("                    |                      Co se seznamem chcete udělat?                             |");
                Console.WriteLine("                    |                                                                                |");
                Console.Write("                    |");
                Console.Write("  1: Zobrazit"); Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("                                                                   |");
                Console.Write("                    |"); Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  2: Přidat další prvek"); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("                                                         |");
                Console.WriteLine();
                Console.Write("                    |"); Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  3: Odebrat možnost"); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("                                                            |");
                Console.WriteLine();
                Console.Write("                    |"); Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  4: Smazat seznam"); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("                                                              |");
                Console.WriteLine();
                Console.Write("                    |"); Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  5: Seřadit vzestupně"); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("                                                          |");
                Console.WriteLine();
                Console.Write("                    |"); Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  6: Seřadit sestupně"); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("                                                           |");
                Console.WriteLine();
                Console.Write("                    |"); Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  7: Otočit seznam"); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("                                                              |");
                Console.WriteLine();
                Console.Write("                    |"); Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  8: Vypsat počet prvků seznamu"); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("                                                 |");
                Console.WriteLine();
                Console.Write("                    |"); Console.ForegroundColor = ConsoleColor.White;       
                Console.Write("  9: Vypsat nejmenší a největší prvek                                          "); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(" |");
                Console.WriteLine();
                Console.Write("                    |"); Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  10: Odstraněnit duplikantů"); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("                                                    |");
                Console.WriteLine();
                Console.Write("                    |"); Console.ForegroundColor = ConsoleColor.White;
                Console.Write("  11: Ukončit program"); Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("                                                           |");
                Console.WriteLine();
                Console.WriteLine("                    |                                                                                |");
                Console.WriteLine("                     ————————————————————————————————————————————————————————————————————————————————");

                Console.WriteLine("");
                Console.WriteLine("");

                Console.Write("                                                      Vaše volba: ");
                

                bool PC = Int32.TryParse(Console.ReadLine(), out Choice);
                
                // ------------------------------  Switch  -----------------------------------------
                switch (Choice)
                {
                    case 1: 
                        VypisSeznamu(PlaceHolder); 
                        break;

                    case 2:
                        Console.Write("\nZadejte žádané číslo: ");
                        int l = int.Parse(Console.ReadLine());

                        Pridat(PlaceHolder, l);
                        VypisSeznamu(PlaceHolder);
                        break;

                    case 3:
                        VypisSeznamu(PlaceHolder);
                        Console.Write("\nZadej index čísla, které chceš odebrat: ");
                        int k = int.Parse(Console.ReadLine());

                        Odebrat(PlaceHolder, k);
                        // PlaceHolder.Remove(k);
                        VypisSeznamu(PlaceHolder);
                        break; 
                    
                    case 4:
                        Smazat(PlaceHolder);
                        Console.WriteLine("\nAktuální seznam:");
                        VypisSeznamu(PlaceHolder);
                        break;
                    
                    case 5:
                        SVzestupně(PlaceHolder);
                        VypisSeznamu(PlaceHolder);
                        break;
                    
                    case 6:
                        SSestupně(PlaceHolder);
                        VypisSeznamu(PlaceHolder);
                        break;

                    case 7:
                        Otočení(PlaceHolder);
                        VypisSeznamu(PlaceHolder);
                        break;

                    case 8:
                        int j = PP(PlaceHolder);
                        Console.WriteLine("\nPočet prvků v seznamu: {0} ", j);
                        break;

                    case 9:
                        MinMax(PlaceHolder);
                        break;

                    case 10:
                        List<int> DELETE = PlaceHolder.Distinct().ToList();
                        DELETE.ForEach(i => Console.WriteLine($"{i}"));
                        break;

                    case 11:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("\nZadali jste špatnou hodnotu. Prosím zadejte hodnotu znovu.");
                        break;

                }
            }
        }
    }
}
