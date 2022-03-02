using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp_1
{
    class Program
    {

        static void Main(string[] args)
        {
            // - Titulní strana -
            Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); 
            Console.WriteLine(""); Console.WriteLine("");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("                                  ———————————————————————————————————————————————————");
            Console.WriteLine("                                 |                                                   |");
            Console.WriteLine("                                 |    The Holy war has once again started and YOU    |");
            Console.WriteLine("                                 |       were chosen as one of the Masters to        |");
            Console.WriteLine("                                 |   participate in the great bloody battle          |");
            Console.WriteLine("                                 |         of Servants in order to win               |");
            Console.WriteLine("                                 |   the Holy Grail that grants any and all wishes.  |");
            Console.WriteLine("                                 |                                                   |");
            Console.WriteLine("                                 |                                                   |");
            Console.WriteLine("                                 |                  So let's begin!                  |");
            Console.WriteLine("                                 |     Choose a Servant that will fight for you!     |");
            Console.WriteLine("                                 |                                                   |");
            Console.WriteLine("                                  ———————————————————————————————————————————————————");

            Console.WriteLine("");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                Press ENTER to continue");

            Console.ReadLine();
            Console.Clear();

            // -------------------------------------------- strana 2 -----------------------------------------------------------
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Clear();
            

            Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine(""); Console.WriteLine("");
            
            Console.WriteLine("                                  ———————————————————————————————————————————————————");
            Console.WriteLine("                                 |                                                   |");
            Console.WriteLine("                                 |           Which gender would you prefer           |");
            Console.WriteLine("                                 |             for your fighter to have?             |");
            Console.WriteLine("                                 |                                                   |");
            Console.Write("                                 |");            
            Console.Write("             M: Male", Console.ForegroundColor = ConsoleColor.Gray); 
            Console.WriteLine("                               |", Console.ForegroundColor = ConsoleColor.Cyan);
            Console.Write("                                 |"); ;            
            Console.Write("             F: Female", Console.ForegroundColor = ConsoleColor.Gray); 
            Console.Write("                             |", Console.ForegroundColor = ConsoleColor.Cyan);
            Console.WriteLine("");
            Console.WriteLine("                                 |                                                   |");
            Console.WriteLine("                                  ———————————————————————————————————————————————————");

            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("                                                 Insert your choice: ");
            string gender = Console.ReadLine();


            // -------------------------------------------- strana 3 -----------------------------------------------------------
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Clear();

            Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine(""); Console.WriteLine("");

            Console.WriteLine("                                  ———————————————————————————————————————————————————");
            Console.WriteLine("                                 |                                                   |");
            Console.WriteLine("                                 |       From which continent would you prefer       |");
            Console.WriteLine("                                 |            your fighter to come from?             |");
            Console.WriteLine("                                 |                                                   |");
            Console.Write("                                 |"); Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("             A: America"); Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("                            |");
            Console.Write("                                 |"); Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("             B: Europe"); Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("                             |");
            Console.WriteLine("");
            Console.Write("                                 |"); Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write("             C: Asia"); Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("                               |");
            Console.WriteLine("");
            Console.WriteLine("                                 |                                                   |");
            Console.WriteLine("                                  ———————————————————————————————————————————————————");

            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("                                                 Insert your choice: ");
            string continent = Console.ReadLine();


            // -------------------------------------------- strana 4 -----------------------------------------------------------
        

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            
            Console.ForegroundColor = ConsoleColor.White; //placeholder
            Console.Clear();
            
            Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine(""); Console.WriteLine("");

            Console.WriteLine("                                  ———————————————————————————————————————————————————");
            Console.WriteLine("                                 |                                                   |");
            Console.WriteLine("                                 |    What class do you want your fighter to be?     |");
            Console.WriteLine("                                 |                                                   |");
            Console.Write("                                 |"); 
            Console.Write("             1: Saber"); Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("                              |");
            Console.Write("                                 |"); Console.ForegroundColor = ConsoleColor.White;
            Console.Write("             2: Archer"); Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("                             |");
            Console.WriteLine("");
            Console.Write("                                 |"); Console.ForegroundColor = ConsoleColor.White;
            Console.Write("             3: Caster"); Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("                             |");
            Console.WriteLine("");
            Console.Write("                                 |"); Console.ForegroundColor = ConsoleColor.White;
            Console.Write("             4: Assassin"); Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("                           |");
            Console.WriteLine(""); 
            Console.Write("                                 |"); Console.ForegroundColor = ConsoleColor.White;
            Console.Write("             5: Rider"); Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("                              |");
            Console.WriteLine(""); 
            Console.Write("                                 |"); Console.ForegroundColor = ConsoleColor.White;
            Console.Write("             6: Berserker"); Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("                          |");
            Console.WriteLine(""); 
            Console.Write("                                 |"); Console.ForegroundColor = ConsoleColor.White;
            Console.Write("             7: Lancer"); Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("                             |");                      
            Console.WriteLine("");
            Console.WriteLine("                                 |                                                   |");
            Console.WriteLine("                                  ———————————————————————————————————————————————————");

            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("                                                 Insert your choice: ");
            string cla = Console.ReadLine();


            //-------------------------------------------------------------------------------------------------------
            switch (gender)
            {
                case "Male": case "M": case "m": case "male":
                    gender = "Male"; break;

                case "Female": case "F": case "female": case "f":
                    gender = "Female"; break;

                default: Console.WriteLine("Error."); break;
            }


            //-------------------------------------------------------------------------------------------------------
            switch (continent)
            {
                case "A": case "a": case "America": case "america": case "Murica": case "murica":
                    continent = "America"; break;
                
                case "B": case "Europe": case "europe": case "Euro": case "euro": case "Eu": case "EU": case "eu": case "b":
                case "e": case "E":
                    continent = "Europe"; break;

                case "C": case "Asia": case "asia": case "As": case "as": case "c":
                    continent = "Asia"; break;

                default: Console.WriteLine("Error."); break;
            }

            //-----------------------------------------------------------------------------------------------------------
            
            

            // Finální strana
            
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Clear();
            
            Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine(""); Console.WriteLine("");

            switch (cla)
            {
                case "1":
                case "Saber":
                case "Sa":
                case "saber":
                case "sa":
                    cla = "Saber";
                    
                    break;

                case "2":
                case "Archer":
                case "archer":
                case "Ar":
                case "ar":
                    cla = "Archer"; break;

                case "3":
                case "Caster":
                case "caster":
                case "Ca":
                case "ca":
                    cla = "Caster"; break;

                case "4":
                case "Assassin":
                case "assassin":
                case "As":
                case "as":
                    cla = "Assassin"; break;

                case "5":
                case "Rider":
                case "rider":
                case "Ri":
                case "ri":
                    cla = "Rider"; break;

                case "6":
                case "Berserker":
                case "berserker":
                case "Be":
                case "be":
                    cla = "Berserker"; break;

                case "7":
                case "Lancer":
                case "lancer":
                case "La":
                case "la":
                    cla = "Lancer"; break;

                case "Ruler":
                    cla = "Ruler"; break;

                default: Console.WriteLine("Error."); break;
            }

            Console.WriteLine("                                  ———————————————————————————————————————————————————");
            Console.WriteLine("                                 |                                                   |");
            Console.WriteLine("                                 |    The name of the servant:    |");
            Console.WriteLine("                                 |       Gender: {0}        |", gender);
            Console.WriteLine("                                 |       Continent: {0}      |", continent);
            Console.WriteLine("                                 |       Class: {0}                 |", cla);
            Console.WriteLine("                                 |     |");
            Console.WriteLine("                                 |                                                   |");
            Console.WriteLine("                                 |                                                   |");
            Console.WriteLine("                                 |                                    |");
            Console.WriteLine("                                 |          |");
            Console.WriteLine("                                 |                                                   |");
            Console.WriteLine("                                  ———————————————————————————————————————————————————");

            Console.WriteLine("");
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
