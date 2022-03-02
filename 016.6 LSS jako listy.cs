using System;
using System.Collections.Generic;

namespace LSS
{
    class Program
    {
        public static void TiskSeznamu(List<int> seznam)
        {
            foreach (int c in seznam)
                Console.Write("{0,5}", c);
        }
        public static List<int> PřidáníNaZačátek(int kolik)
        {
            var list = new List<int>();

            while (0 < kolik)
            {
                list.Add(kolik);
                kolik--;
            }
            list.Reverse();
            return list;
        }
        public static List<int> PřidáníNaKonec(int kolik)
        {
            var list = new List<int>();

            while (kolik < 0)
            {
                kolik--;
                list[kolik] = kolik;
            }
            return list;
        }
        public static void VlozZa(List<int> seznam, int zaktery, int vkladany)
        {
            seznam.Insert(zaktery, vkladany);
        }
        public static void VlozPred(List<int> seznam, int predktery, int vkladany)
        {
            seznam.Insert(predktery - 1, vkladany);
        }
        public static int NajdiPaty(List<int> seznam)
        {
            return seznam[4];
        }
        public static void VypustZa(List<int> seznam, int zakterym)
        {
            seznam.Remove(zakterym);
        }
        public static void VypustPred(List<int> seznam, int predkterym)
        {
            seznam.RemoveAt(predkterym - 2);
        }
        public static int Zmena(int cislo)
        { return 2 * cislo; }
        public static void PruchodZmena(List<int> seznam)
        {
            for (int i = 0; i < seznam.Count; i++)
            {
                seznam[i] = Zmena(seznam[i]);
            }
        }
        public static void Vyhledej(List<int> seznam, int x)
        {
            Console.WriteLine("Prvek s hodnotou {0} existuje: {1}", x, seznam.Exists(a => a == x));
        }
        public static void VypustPrvekSHodnotou(List<int> seznam, int vypusteny) 
        {
            seznam.Remove(vypusteny);
        }

        
        static void Main(string[] args)
        {
            var List = new List<int>();
            var list = new List<int>();

            const int n = 10;

            List = PřidáníNaZačátek(n);
            TiskSeznamu(List);

            list = PřidáníNaKonec(n);
            TiskSeznamu(list);
            Console.WriteLine("\n");

            VlozZa(List, 3, 100);
            TiskSeznamu(List);
            Console.WriteLine("\nVložen prvek 100 za 3. prvkem\n");

            VlozPred(List, 7, -100);
            TiskSeznamu(List);
            Console.WriteLine("\nVložen prvek -100 před 7. prvkem\n");

            Console.WriteLine("Pátý prvek v seznamu je {0}", NajdiPaty(List));
            Console.WriteLine();

            VypustZa(List, 6);
            TiskSeznamu(List);
            Console.WriteLine("\nVypuštěn prvek za 7. prvkem s hodnotou 6\n");

            VypustPred(List, 9);
            TiskSeznamu(List);
            Console.WriteLine("\nVypuštěn prvek před 8. prvkem s hodnotou 7\n");

            PruchodZmena(List);
            TiskSeznamu(List);
            Console.WriteLine("\n");

            Vyhledej(List, 14);
            Console.WriteLine("\n");

            VypustPrvekSHodnotou(List, 14);
            TiskSeznamu(List);
            Console.WriteLine("\nSmazán prvek 14");

            Console.ReadLine();
        }
    }
}
