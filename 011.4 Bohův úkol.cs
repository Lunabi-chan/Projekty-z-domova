using System;
using System.Collections.Generic;


namespace IndexovanéSeznamyCvičení
{
    class Program
    {


        //	2)Naprogramujte proceduru static public void VypisSeznam(List<int> sez),
        //    která vypíše daný seznam sez v pořadí od indexu 0 po poslední.
        static public void VypisSeznam(List<int> sez)
        {
            for (int i = 0; i < sez.Count; i++)
            {
                Console.Write("{0,4}", sez[i]);
            }
            Console.WriteLine();
        }

        //	3)Naprogramujte funkci static private int PocetPrvku(List<int> sez), která vrátí počet prvků seznamu sez.


        static private int PocetPrvku(List<int> sez)
        {
            return sez.Count;

        }

        //  4)smazat seznam

        static private void smazSeznam(List<int> sez)
        {
            sez.Clear();
        }

        //  5)přidat čísla do seznamu

        static private void Pridat(List<int> sez, int cislo)
        {
            sez.Add(cislo);
        }



        static void Main(string[] args)
        {
            List<int> poleCisel = new List<int>();
            poleCisel.Add(3);
            poleCisel.Add(7);
            poleCisel.Add(1);

            Console.WriteLine("Aktuální stav seznamu:");

            VypisSeznam(poleCisel);
            int volba = 0;
            
            while (volba != 99) 
            {
                Console.WriteLine("\nCo chcete provést?");
                Console.WriteLine("\t1) vypsat všechny prvky seznamu");
                Console.WriteLine("\t2) vypsat počet prvků seznamu");
                Console.WriteLine("\t3) vymazat celý seznam");
                Console.WriteLine("\t4) přidat číslo do seznamu");
                Console.WriteLine("\t99) ukončit program");
                Console.Write("zadejte volbu: ");
                bool vysledek = Int32.TryParse(Console.ReadLine(), out volba);
                if (!vysledek)
                {
                    volba = -1;
                }

                switch (volba)
                {
                    case 1:
                        VypisSeznam(poleCisel);
                        break;
                    case 2:
                        int velikost = PocetPrvku(poleCisel);
                        Console.WriteLine("velikost seznamu je: {0} ", velikost);
                        break;

                    case 3:
                        smazSeznam(poleCisel);
                        Console.WriteLine("aktuální seznam je:");
                        VypisSeznam(poleCisel);
                        break;


                    case 4:
                        Console.Write("jaké číslo chcete přidat? ");
                        int cislo = int.Parse(Console.ReadLine());
                        Pridat(poleCisel, cislo);
                        VypisSeznam(poleCisel);
                        break;



                    case 99:
                        Console.WriteLine("zdar");
                        break;

                    default:
                        Console.WriteLine("Zadal jste špatnou hodnotu");
                        break;


                }
            }



         






            

        }




     













    }
}
