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
            // - Titulní strana -
            Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine(""); Console.WriteLine("");
            Console.WriteLine(""); Console.WriteLine("");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkRed;

            Console.WriteLine("                                  ———————————————————————————————————————————————————");
            Console.WriteLine("                                 |                                                   |");
            Console.WriteLine("                                 |    The Holy war has once again started and YOU    |");
            Console.WriteLine("                                 |      were chosen as one of the 7 Masters to       |");
            Console.WriteLine("                                 |      participate in the great bloody battle       |");
            Console.WriteLine("                                 |         of Heroic Spirits in order to win         |");
            Console.WriteLine("                                 |   the Holy Grail that grants any and all wishes.  |");
            Console.WriteLine("                                 |                                                   |");
            Console.WriteLine("                                 |                                                   |");
            Console.WriteLine("                                 |                  So let's begin!                  |");
            Console.WriteLine("                                 |  Choose a Heroic Spirit that will fight for you!  |");
            Console.WriteLine("                                 |                                                   |");
            Console.WriteLine("                                  ———————————————————————————————————————————————————");

            Console.WriteLine("");

            Console.WriteLine("                      Heroic Spirits are spirits of heroes/people who achieved great deeds in life,", Console.ForegroundColor = ConsoleColor.DarkGray);
            Console.WriteLine("                                 having become objects of worship after their deaths.");

            Console.WriteLine("");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("                                                 Press ENTER to continue");

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
            Console.Write("                                 |");
            Console.Write("         Unfortunately there is no neutral", Console.ForegroundColor = ConsoleColor.DarkGray);
            Console.Write("         |", Console.ForegroundColor = ConsoleColor.Cyan);
            Console.WriteLine("");
            Console.Write("                                 |");
            Console.Write("               gender to pick from.", Console.ForegroundColor = ConsoleColor.DarkGray);
            Console.Write("                |", Console.ForegroundColor = ConsoleColor.Cyan);
            Console.WriteLine("");
            Console.WriteLine("                                 |                                                   |");
            Console.WriteLine("                                  ———————————————————————————————————————————————————");

            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("                                         Insert your choice (Letter, Gender): ");
            string gender = Console.ReadLine();

            // -------------------------------------------- strana 3 -----------------------------------------------------------
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.ForegroundColor = ConsoleColor.DarkYellow; //placeholder
            Console.Clear();

            Console.WriteLine(""); Console.WriteLine("");

            Console.WriteLine("                   —————————————————————————————————————————————————————————————————————————————————");
            Console.WriteLine("                  |                                                                                 |");
            Console.WriteLine("                  |                  What class do you want your fighter to have?                   |");
            Console.WriteLine("                  |                                                                                 |");
            Console.Write("                  |");
            Console.Write("             1: Saber", Console.ForegroundColor = ConsoleColor.Gray);
            Console.WriteLine("                                                            |", Console.ForegroundColor = ConsoleColor.DarkYellow);
            Console.WriteLine("                  |       A jack-of-all-trades warrior. Agile and powerful in close quarters;       |");
            Console.WriteLine("                  |                        extremely adept at swordsmanship.                        |");
            Console.Write("                  |");
            Console.Write("             2: Archer", Console.ForegroundColor = ConsoleColor.Gray);
            Console.WriteLine("                                                           |", Console.ForegroundColor = ConsoleColor.DarkYellow);
            Console.WriteLine("                  |       Excellent scouts that excel in possessing powerful Noble Phantasms.       |");
            Console.WriteLine("                  |                        Masters of long ranged warfare.                          |");
            Console.Write("                  |");
            Console.Write("             3: Caster", Console.ForegroundColor = ConsoleColor.Gray);
            Console.WriteLine("                                                           |", Console.ForegroundColor = ConsoleColor.DarkYellow);
            Console.WriteLine("                  |       Adept in magecraft, being one of the few able to use                      | ");
            Console.WriteLine("                  |                       sorceries of the highest caliber.                         | ");
            Console.Write("                  |");
            Console.Write("             4: Assassin", Console.ForegroundColor = ConsoleColor.Gray);
            Console.WriteLine("                                                         |", Console.ForegroundColor = ConsoleColor.DarkYellow);
            Console.WriteLine("                  |       Extremely skilled at covert, stealthy, and silent operations.             |");
            Console.Write("                  |");
            Console.Write("             5: Rider", Console.ForegroundColor = ConsoleColor.Gray);
            Console.WriteLine("                                                            |", Console.ForegroundColor = ConsoleColor.DarkYellow);
            Console.WriteLine("                  |       Experts of the mount able to tame any beast,                              |");
            Console.WriteLine("                  |                       be it mythical or mechanical.                             |");
            Console.Write("                  |");
            Console.Write("             6: Berserker", Console.ForegroundColor = ConsoleColor.Gray);
            Console.WriteLine("                                                        |", Console.ForegroundColor = ConsoleColor.DarkYellow);
            Console.WriteLine("                  |       Crazed warriors that have lost almost all traces                          |");
            Console.WriteLine("                  |                       of their sanity in exchange for great power.              |");
            Console.Write("                  |");
            Console.Write("             7: Lancer", Console.ForegroundColor = ConsoleColor.Gray);
            Console.WriteLine("                                                           |", Console.ForegroundColor = ConsoleColor.DarkYellow);
            Console.WriteLine("                  |       Gifted with extreme agility and proficient in hit-and-run tactics as      |");
            Console.WriteLine("                  |                       well as ranged melee weapons such as spears and lances.   |");
            Console.Write("                  |");
            Console.Write("                Ruler", Console.ForegroundColor = ConsoleColor.Blue);
            Console.WriteLine("                                                            |", Console.ForegroundColor = ConsoleColor.DarkYellow);
            Console.WriteLine("                   —————————————————————————————————————————————————————————————————————————————————");

            Console.WriteLine("");
            Console.WriteLine("");

            Console.Write("                                      Insert your choice (Number, Class name): ");
            string cla = Console.ReadLine();

            // Finální strana ---------------------------------------------------------------------
            string name = "Error"; string desc = "Error"; string sour = "Error"; string regi = "Error";
            int Str = 0; int End = 0; int Agi = 0; int Mag = 0; int Sns = 0; int Int = 0;

            Console.Clear();
            switch (cla)
            {
                case "1":
                case "Saber":
                case "Sa":
                case "saber":
                case "sa":
                case "2":
                case "Archer":
                case "archer":
                case "Ar":
                case "ar":
                case "3":
                case "Caster":
                case "caster":
                case "Ca":
                case "ca":
                case "4":
                case "Assassin":
                case "assassin":
                case "As":
                case "as":
                case "5":
                case "Rider":
                case "rider":
                case "Ri":
                case "ri":
                case "6":
                case "Berserker":
                case "berserker":
                case "Be":
                case "be":
                case "7":
                case "Lancer":
                case "lancer":
                case "La":
                case "la":
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.Clear();
                    break;

                case "Ruler":
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Clear();
                    break;
            }

            switch (cla)
            {
                case "1":
                case "Saber":
                case "Sa":
                case "saber":
                case "sa":
                    cla = "Saber                                              ";


                    Console.WriteLine("");
                    Console.WriteLine("                                                         __ ");
                    Console.WriteLine("                                                        /  \\ ");
                    Console.WriteLine("                                                        ||||");
                    Console.WriteLine("                                                        ||||");
                    Console.WriteLine("                                                        ||||");
                    Console.WriteLine("                                                        ||||");
                    Console.WriteLine("                                                        ||||");
                    Console.WriteLine("                                                        ||||");
                    Console.WriteLine("                                                        ||||");
                    Console.WriteLine("                                                        ||||");
                    Console.WriteLine("                                                        |||| ");
                    Console.WriteLine("                                                    ____||||____");
                    Console.WriteLine("                                                   )___ _)(_ ___(");
                    Console.WriteLine("                                                        \\  /");
                    Console.WriteLine("                                                        |  |");
                    Console.WriteLine("                                                        /  \\");
                    Console.WriteLine("                                                        (__)");

                    Random staS = new Random();
                    Str = staS.Next(3, 5);
                    End = staS.Next(1, 4);
                    Agi = staS.Next(3, 5);
                    Mag = staS.Next(1, 3);
                    Sns = staS.Next(2, 5);
                    Int = staS.Next(1, 5);

                    switch (gender)
                    {
                        case "Female":
                        case "F":
                        case "female":
                        case "f":
                            gender = "Female                                             ";
                            name = "Tomoe Gozen                                   ";
                            desc = "The Female Martial artist                        ";
                            sour = "Historical fact                                    ";
                            regi = "Japan                                              ";

                            break;

                        case "Male":
                        case "M":
                        case "m":
                        case "male":
                            gender = "Male                                               ";
                            name = "Arthur Pendragon                              ";
                            desc = "The King of Knights                              ";
                            sour = "Arthurian Legends                                  ";
                            regi = "Britain                                            ";

                            break;
                    }
                    break;

                case "2":
                case "Archer":
                case "archer":
                case "Ar":
                case "ar":
                    cla = "Archer                                             ";

                    Console.WriteLine("");
                    Console.WriteLine("                                                      * ");
                    Console.WriteLine("                                                      |\\  ");
                    Console.WriteLine("                                                      | \\    ");
                    Console.WriteLine("                                                      |  \\       ");
                    Console.WriteLine("                                                      |   \\          ");
                    Console.WriteLine("                                                      |    || ");
                    Console.WriteLine("                                                      |    || ");
                    Console.WriteLine("                                                      |    || ");
                    Console.WriteLine("                                           >>>>>===========##======>  ");
                    Console.WriteLine("                                                      |    ||  ");
                    Console.WriteLine("                                                      |    ||  ");
                    Console.WriteLine("                                                      |    ||  ");
                    Console.WriteLine("                                                      |   /  ");
                    Console.WriteLine("                                                      |  / ");
                    Console.WriteLine("                                                      | / ");
                    Console.WriteLine("                                                      |/ ");
                    Console.WriteLine("                                                      * ");

                    Random stat = new Random();
                    Str = stat.Next(2, 4);
                    End = stat.Next(1, 3);
                    Agi = stat.Next(3, 5);
                    Mag = stat.Next(2, 5);
                    Sns = stat.Next(3, 5);
                    Int = stat.Next(1, 5);

                    switch (gender)
                    {
                        case "Female":
                        case "F":
                        case "female":
                        case "f":
                            gender = "Female                                             ";
                            name = "Atalanta                                      ";
                            desc = "The Chaste Huntress                              ";
                            sour = "Greek Mythology                                    ";
                            regi = "Greece                                             ";

                            break;

                        case "Male":
                        case "M":
                        case "m":
                        case "male":
                            gender = "Male                                               ";
                            name = "Arjuna                                        ";
                            desc = "The Endowed Hero                                 "; //Obdarovaný hrdina
                            sour = "Mahabharata                                        "; //Velké vyprávění o Bháratovcích
                            regi = "India                                              ";

                            break;
                    }
                    break;

                case "3":
                case "Caster":
                case "caster":
                case "Ca":
                case "ca":
                    cla = "Caster                                             ";

                    Console.WriteLine("");
                    Console.WriteLine("                                                        ____");
                    Console.WriteLine("                                                __,-~~/~    `---.");
                    Console.WriteLine("                                              _ /_,---(      ,    )");
                    Console.WriteLine("                                          __ /        <    /   )   )___   ");
                    Console.WriteLine("                           - ------===;;;'====------------------===;;;===----- -  -");
                    Console.WriteLine("                                            (  ~~~~~~~~)~/    )     )      ");
                    Console.WriteLine("                                            (_ (     (     >       )     ");
                    Console.WriteLine("                                               ( _ <         >_>' ) ");
                    Console.WriteLine("                                                  ~ `-i' ::>|--~    ");
                    Console.WriteLine("                                                      I;|.|.|      ");
                    Console.WriteLine("                                                     <|i::|i|`.     ");
                    Console.WriteLine("                                                   (` ^'  ^'  )     ");

                    Random staC = new Random();
                    Str = staC.Next(1, 3);
                    End = staC.Next(1, 3);
                    Agi = staC.Next(2, 4);
                    Mag = staC.Next(4, 5);
                    Sns = staC.Next(1, 5);
                    Int = staC.Next(3, 5);

                    switch (gender)
                    {
                        case "Female":
                        case "F":
                        case "female":
                        case "f":
                            gender = "Female                                             ";
                            name = "Medea                                         ";
                            desc = "The Witch of Colchis                             ";
                            sour = "Greek Mythology                                    ";
                            regi = "Greece                                             ";

                            break;

                        case "Male":
                        case "M":
                        case "m":
                        case "male":
                            gender = "Male                                               ";
                            name = "Gilgamesh                                     ";
                            desc = "The King of Heroes                               ";
                            sour = "Epic of Gilgamesh                                  ";
                            regi = "Ancient Mesopotamia                                ";

                            break;
                    }
                    break;

                case "4":
                case "Assassin":
                case "assassin":
                case "As":
                case "as":
                    cla = "Assassin                                           ";

                    Console.WriteLine("");
                    Console.WriteLine("                                                       .---. ");
                    Console.WriteLine("                                                       |---| ");
                    Console.WriteLine("                                                       |---| ");
                    Console.WriteLine("                                                   :---^ - ^---: ");
                    Console.WriteLine("                                                      |  |//| ");
                    Console.WriteLine("                                                      |  |//| ");
                    Console.WriteLine("                                                      |  |//| ");
                    Console.WriteLine("                                                      |  |//| ");
                    Console.WriteLine("                                                      |  |//| ");
                    Console.WriteLine("                                                      |  |//| ");
                    Console.WriteLine("                                                      |  |.-| ");
                    Console.WriteLine("                                                      |.-'**| ");
                    Console.WriteLine("                                                       \\***/ ");
                    Console.WriteLine("                                                        \\*/ ");
                    Console.WriteLine("                                                         V ");
                    Console.WriteLine("");
                    Console.WriteLine("                                                         ^ ' ");
                    Console.WriteLine("                                                        (_) ");

                    Random staA = new Random();
                    Str = staA.Next(1, 3);
                    End = staA.Next(1, 3);
                    Agi = staA.Next(2, 5);
                    Mag = staA.Next(3, 5);
                    Sns = staA.Next(1, 5);
                    Int = staA.Next(1, 5);

                    switch (gender)
                    {
                        case "Female":
                        case "F":
                        case "female":
                        case "f":
                            gender = "Female                                             ";
                            name = "Semiramis                                     ";
                            desc = "The Wise Queen of Assyria                        ";
                            sour = "Legend of the Assyrian empire                      ";
                            regi = "Middle East                                        ";

                            break;

                        case "Male":
                        case "M":
                        case "m":
                        case "male":
                            gender = "Male                                               ";
                            name = "Jack the Ripper                               ";
                            desc = "The Legendary Serial Killer                      ";
                            sour = "Historical fact                                    ";
                            regi = "Britain                                            ";

                            break;
                    }
                    break;

                case "5":
                case "Rider":
                case "rider":
                case "Ri":
                case "ri":
                    cla = "Rider                                              ";

                    Console.WriteLine("");
                    Console.WriteLine("                                              _____,    _..-=-=-=-=-====--, ");
                    Console.WriteLine("                                           _.'    /  .-',___,..=--=--==-'`");
                    Console.WriteLine("                                          ( _     \\ /  //___/-=---=----'");
                    Console.WriteLine("                                           ` `\\    /  //---/--==----=-'");
                    Console.WriteLine("                                        ,-.    | / \\_//-_.'==-==---='");
                    Console.WriteLine("                                       (.-.`\\  | |'../-'=-=-=-=--'");
                    Console.WriteLine("                                        (' `\\`\\| //_|-\\.`;-~````~,        _");
                    Console.WriteLine("                                             \\ | \\_,_,_\\.'        \\     .'_`\\ ");
                    Console.WriteLine("                                              `\\            ,    , \\    || `\\\\");
                    Console.WriteLine("                                                \\    /   _.--\\    \\ '._.'/  / | ");
                    Console.WriteLine("                                                /  /`---'   \\ \\   |`'---'   \\/ ");
                    Console.WriteLine("                                                / /'         \\ ;-. \\ ");
                    Console.WriteLine("                                            __ / /          __) \\ )`| ");
                    Console.WriteLine("                                          ((='--;)         (,___/(,_/ ");

                    Random staR = new Random();
                    Str = staR.Next(1, 4);
                    End = staR.Next(1, 4);
                    Agi = staR.Next(2, 4);
                    Mag = staR.Next(3, 5);
                    Sns = staR.Next(4, 5);
                    Int = staR.Next(1, 5);

                    switch (gender)
                    {
                        case "Female":
                        case "F":
                        case "female":
                        case "f":
                            gender = "Female                                             ";
                            name = "Europa                                        ";
                            desc = "The Princess of Phoenicia                        ";
                            sour = "Greek Mythology                                    ";
                            regi = "Europe                                             ";


                            break;

                        case "Male":
                        case "M":
                        case "m":
                        case "male":
                            gender = "Male                                               ";
                            name = "Quetzalcoatl                                  ";
                            desc = "The Feathered Serpent                            ";
                            sour = "Aztec Mythology                                    ";
                            regi = "Central and South America                          ";

                            break;
                    }
                    break;

                case "6":
                case "Berserker":
                case "berserker":
                case "Be":
                case "be":
                    cla = "Berserker                                          ";

                    Console.WriteLine("");
                    Console.WriteLine("                                          |\\ ");
                    Console.WriteLine("                                          | \\        /|");
                    Console.WriteLine("                                          |  \\____  / |");
                    Console.WriteLine("                                         /|__/AMMA\\/  |");
                    Console.WriteLine("                                       /AMMMMMMMMMMM\\_|");
                    Console.WriteLine("                                   ___/AMMMMMMMMMMMMMMA");
                    Console.WriteLine("                                   \\   | MVKMMM/ .\\MMMMM\\ ");
                    Console.WriteLine("                                    \\__ /MMMMMM\\  /MMMMMM--- ");
                    Console.WriteLine("                                    | MMMMMMMMMMMMMMMMMM|  /");
                    Console.WriteLine("                                    | MMMM/. \\MM.--MMMMMM\\/");
                    Console.WriteLine("                                   /\\ MMMM\\  /M\\  |MMMMMM   ___");
                    Console.WriteLine("                                  /__| MMMMMMMMM\\ |MMMMMM--/ ___\\-.");
                    Console.WriteLine("                                       \\VMM/\\MMMMMMM\\  |      /\\\\/");
                    Console.WriteLine("                                        \\V /  \\MMMMMMM\\ |     /_ /");
                    Console.WriteLine("                                           | /MMMV'    \\|      / _/");
                    Console.WriteLine("                                           |/                   | \\'");


                    Random staB = new Random();
                    Str = staB.Next(4, 5);
                    End = staB.Next(4, 5);
                    Agi = staB.Next(1, 4);
                    Mag = staB.Next(1, 3);
                    Sns = staB.Next(1, 4);
                    Int = staB.Next(1, 3);

                    switch (gender)
                    {
                        case "Female":
                        case "F":
                        case "female":
                        case "f":
                            gender = "Female                                             ";
                            name = "Elizabeth of Pomerania                        ";
                            desc = "The Strong Empress                               ";
                            sour = "Historical fact                                    ";
                            regi = "Czech Republic                                     ";



                            break;

                        case "Male":
                        case "M":
                        case "m":
                        case "male":
                            gender = "Male                                               ";
                            name = "Lu Bu Fengxian                                ";
                            desc = "The General of Repetition                        ";
                            sour = "Historical fact                                    ";
                            regi = "China                                              ";

                            break;
                    }
                    break;

                case "7":
                case "Lancer":
                case "lancer":
                case "La":
                case "la":
                    cla = "Lancer                                             ";

                    Console.WriteLine("");
                    Console.WriteLine("                                    /`-..___  ");
                    Console.WriteLine("                        ___________/        ````-----......_______ ");
                    Console.WriteLine("                       (___________|                       _______::::::::=========---------- ");
                    Console.WriteLine("                                   \\     ___,,,,-----'''''' ");
                    Console.WriteLine("                                    \\, -''                ");

                    Random staL = new Random();
                    Str = staL.Next(2, 4);
                    End = staL.Next(3, 5);
                    Agi = staL.Next(3, 5);
                    Mag = staL.Next(2, 4);
                    Sns = staL.Next(1, 4);
                    Int = staL.Next(1, 5);

                    switch (gender)
                    {
                        case "Female":
                        case "F":
                        case "female":
                        case "f":
                            gender = "Female                                             ";
                            name = "Brynhildr                                     ";
                            desc = "The Scandinavian Goddess of war                  ";
                            sour = "Norse Mythology                                    ";
                            regi = "Europe                                             ";

                            break;

                        case "Male":
                        case "M":
                        case "m":
                        case "male":
                            gender = "Male                                               ";
                            name = "Karna                                         ";
                            desc = "The Hero of Charity                              ";
                            sour = "Mahabharata                                        "; //Velké vyprávění o Bháratovcích
                            regi = "India                                              ";

                            break;
                    }
                    break;

                case "Ruler":
                    cla = "Ruler                                              ";

                    Console.WriteLine("");
                    Console.WriteLine("                                 ,ggg,                   gg                   ,ggg,   ");
                    Console.WriteLine("                                d8P'''8b               ,d88b,               d8'''Y8b ");
                    Console.WriteLine("                                Y8b,__,,aadd88888bbaaa,888888,aaadd88888bbaa,,__,d8P ");
                    Console.WriteLine("                                  88888888888888888888I888888I88888888888888888888 ");
                    Console.WriteLine("                                 /|\\  `YY8888888PP`    888888    'YY8888888PP'  /|\\ ");
                    Console.WriteLine("                                / | \\                  `WWWW'                  / | \\ ");
                    Console.WriteLine("                               /  |  \\                 ,dMMb,                 /  |  \\ ");
                    Console.WriteLine("                              /   |   \\                I8888I                /   |   \\ ");
                    Console.WriteLine("                             /    |    \\               `Y88P'               /    |    \\ ");
                    Console.WriteLine("                            /     |     \\               `YP'               /     |     \\ ");
                    Console.WriteLine("                           /      |      \\               88               /      |      \\ ");
                    Console.WriteLine("                          /       |       \\             i88i             /       |       \\ ");
                    Console.WriteLine("                         /        |        \\            8888            /        |        \\ ");
                    Console.WriteLine("                      Y88888888888888888888888P        i8888i        Y88888888888888888888888P ");
                    Console.WriteLine("                         `Y888888888888888P'          ,888888,          `Y888888888888888P' ");
                    Console.WriteLine("                                                      I888888I ");
                    Console.WriteLine("                                                      `Y8888P' ");
                    Console.WriteLine("                                                       `WWWW' ");
                    Console.WriteLine("                                                        dMMb ");
                    Console.WriteLine("                                                    _,ad8888ba,_ ");
                    Console.WriteLine("                                         __,,aaaadd888888888888888bbaaaa,,__ ");
                    Console.WriteLine("                                       d8888888888888888888888888888888888888b ");

                    Str = 6;
                    End = 6;
                    Agi = 6;
                    Mag = 6;
                    Sns = 6;
                    Int = 6;

                    switch (gender)
                    {
                        case "Female":
                        case "F":
                        case "female":
                        case "f":
                            gender = "Female                                             ";
                            cla = "Ruler                                              ";
                            name = "Jeanne d'Arc                                  ";
                            desc = "The Holy Maiden                                  ";
                            sour = "Historical fact                                    ";
                            regi = "France                                             ";

                            break;

                        case "Male":
                        case "M":
                        case "m":
                        case "male":
                            name = "Shirou Tokisada Amakusa                       ";
                            gender = "Male                                               ";
                            desc = "The teenage leader of Shimabara Rebellion        ";
                            sour = "Historical fact                                    ";
                            regi = "Japan                                              ";

                            break;
                    }
                    break;

                default: Console.WriteLine("Error. You have failed to pick a Heroic Spirit."); break;
            }

            Console.WriteLine("");

            Console.WriteLine("                         ——————————————————————————————————————————————————————————————————");
            Console.WriteLine("                        |                                                                  |");
            Console.WriteLine("                        |              NAME: {0}|", name);
            Console.WriteLine("                        |                                                                  |");
            Console.WriteLine("                        |       Nickname: {0}|", desc);
            Console.WriteLine("                        |       Class: {0} |", cla);
            Console.WriteLine("                        |       Gender: {0}|", gender);
            Console.WriteLine("                        |       Source: {0}|", sour);
            Console.WriteLine("                        |       Region: {0}|", regi);
            Console.WriteLine("                        |                                                                  |");
            Console.WriteLine("                         ——————————————————————————————————————————————————————————————————");

            Console.WriteLine("");

            // ----------------------------------------------------------------------------------------------
            Console.WriteLine("                         ——————————————————————————————————————————————————————————————————");
            Console.WriteLine("                        |                                                                  |");
            Console.WriteLine("                        |                        STATS                                     |");
            Console.WriteLine("                        |       Strength: {0}                Sense: {1}                        |", Str, Sns);
            Console.WriteLine("                        |       Endurance: {0}               Intelligence: {1}                 |", End, Int);
            Console.WriteLine("                        |       Agility: {0}                 Magic proficiency: {1}            |", Agi, Mag);
            Console.WriteLine("                        |                                                                  |");
            Console.WriteLine("                         ——————————————————————————————————————————————————————————————————");

            Console.ReadLine();



        }
    }
}
