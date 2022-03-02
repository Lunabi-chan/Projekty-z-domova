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
        static void Main(string[] args)
        {            
            var List = new List<int> { 44, 55, 12, 42, 94, 18, 10, 6 };
            var Pub = new List<int>();
            var PC = new List<int>();


            Console.WriteLine("                                  ——————————————————————————————————————————————————");
            Console.WriteLine("                                 |                                                  |");
            Console.WriteLine("                                 |       1: Přidej číslo do Haldy                   |");
            Console.WriteLine("                                 |       2: Odeber nejmenší číslo z haldy           |");
            Console.WriteLine("                                 |       3: Odeber největší číslo z haldy           |");
            Console.WriteLine("                                 |       4: Připrav už hotovou Haldu                |");
            Console.WriteLine("                                 |       5: Uprav Haldu podle pravidla Otec-Syn     |");
            Console.WriteLine("                                 |       6: Odeber poslední číslo z Haldy           |");
            Console.WriteLine("                                 |       7: Zavřít program                          |");
            Console.WriteLine("                                 |                                                  |");
            Console.WriteLine("                                  ——————————————————————————————————————————————————");

            /*int Choice = Int32.Parse(Console.ReadLine());

            while (Choice != 0)
            {
                switch (Choice)
                {
                    case 1: 
                        Pub.Add(List[0]);
                        List.Remove(0);
                        break;
                    case 2: 
                        break;
                    case 3: 
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    default: break;
                }


            }*/

            Console.ReadLine();

            
            bool k = false;
            int pom;

            int r = List.Capacity / 2;
            int t = List.Capacity % 2;
            int o = t / 2;
            int p = t % 2;

            while(k == false)
            {
                PC = List;

                for (int u = 0; u < (r-1); u++)
                {
                    if (List[u] > List[2*u])
                    {
                        pom = List[u];
                        List[u] = List[2*u];
                        List[2*u] = pom;
                    }

                    if (List[u] > List[2 * u + 1])
                    {
                        pom = List[u];
                        List[u] = List[2 * u + 1];
                        List[2 * u + 1] = pom;
                    }
                }

                if (PC == List)
                {
                    k = true;
                }
            }

            for (int i = 0; i < List.Capacity; i++)
            {
                Console.Write("{0}\t", List[i]);
            }

            Console.ReadLine();
        }
    }
}
