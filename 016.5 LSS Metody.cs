using System;

namespace LSS
{
    /*
     * Vytvoření spojového 
     */
    public class Prvek
    {
        public int hodnota;
        public Prvek p_dalsi;
    }

    class Program
    {
        public static void TiskSeznamu(Prvek p_seznam)
        {
            while (p_seznam != null)
            {
                Console.Write("{0,5}", p_seznam.hodnota);
                p_seznam = p_seznam.p_dalsi;
            }
        }

        public static Prvek PřidáníNaZačátek(int kolik)
        {
            Prvek p_novy = null;
            Prvek p_seznam = null;

            while (kolik > 0)
            {/*
                p_novy = new Prvek();           //vytvořím nový vagón
                p_novy.hodnota = kolik;         //nastavím počet cestujících
                p_novy.p_dalsi = p_seznam;      //zapojíme ho do vlaku
                p_seznam = p_novy;              //lokomotivu zapojím před novým
                kolik--;*/

                p_novy = new Prvek() {hodnota = kolik, p_dalsi = p_seznam};
                p_seznam = p_novy;
                kolik--;
                
            }
            return p_seznam;
        }

        public static Prvek PřidáníNaKonec(int kolik)
        {
            Prvek p_novy = null;        //Ukazuje se na nový prvek
            Prvek p_seznam = null;      //Ukazuje se na začátek seznamu
            Prvek p_konec = null;       //Ukazuje na konec seznamu
            
            //První prvek musí být vytvořený samostatně
            p_seznam = new Prvek();
            p_seznam.hodnota = 1;
            p_seznam.p_dalsi = null;          //nebo p_novy.p_dalsi = p_seznam;
            p_konec = p_seznam;

            //Další prvky se vytvoří v cyklu
            for (int i = 2; i <= kolik; i++)
            {
                p_novy = new Prvek();
                p_novy.hodnota = i;
                p_konec.p_dalsi = p_novy;
                p_konec = p_novy;
            }
            return p_seznam;
        }

        public static /*Prvek*/ void VlozZa(Prvek zaktery, Prvek vkladany)//(int zaktery, int vkladany, int kolik)
        {
            vkladany.p_dalsi = zaktery.p_dalsi;
            zaktery.p_dalsi = vkladany;

            // zaktery ukazuje na prvek seznamu, zaktery se ma vkladat
            // vkladany ukazuje na nove vkladany prvek

            /*
            Prvek p_novy = null;
            Prvek p_seznam = null;

            p_novy = new Prvek();
            p_novy.hodnota = kolik;
            p_novy.p_dalsi = null;          //nebo p_novy.p_dalsi = p_seznam;
            p_seznam = p_novy;

            for (int i = (kolik -1); i > zaktery; i--)
            {
                p_novy = new Prvek();
                p_novy.hodnota = i;
                p_novy.p_dalsi = p_seznam;
                p_seznam = p_novy;
            }

            p_novy = new Prvek();
            p_novy.hodnota = vkladany;
            p_novy.p_dalsi = p_seznam;          //nebo p_novy.p_dalsi = p_seznam;
            p_seznam = p_novy;

            for (int i = zaktery; i > 0; i--)
            {
                p_novy = new Prvek();
                p_novy.hodnota = i;
                p_novy.p_dalsi = p_seznam;
                p_seznam = p_novy;
            }
            return p_seznam;*/
        }

        public static void VlozPred(Prvek predktery, Prvek vkladany)
        {
            //predktery ukazuje na prvek seznamu, pred ktery se ma vkladat
            //vkladany ukazuje na nove vkladany prvek

            vkladany.p_dalsi = predktery.p_dalsi;
            predktery.p_dalsi = vkladany;

            //vlozim ho za predktery a pak vyměním hodnoty...
            int hodnota = predktery.hodnota;
            predktery.hodnota = predktery.p_dalsi.hodnota;
            predktery.p_dalsi.hodnota = hodnota;

            //dalsi moznost - 1. vymena, pote prirazeni
            /*int pom = vkladany.hodnota;
            vkladany.hodnota = predktery.hodnota;
            vkladany.p_dalsi = predktery.p_dalsi;
            predktery.hodnota = pom;
            predktery.p_dalsi = vkladany;
            */

        }

        public static Prvek VypustZa(Prvek predchudce)
        {
            //předchůdce ukazuje na předchůdce rušeného prvku
            //metoda vrací ukazatel na vypuštěný prvek případně nevrací hodnotu
            //pokud byl p_pred posledním pvkem seznamu

            Prvek p_pom;

            //1. varianta
            p_pom = predchudce.p_dalsi;
            if(p_pom != null)
            {
                predchudce.p_dalsi = p_pom.p_dalsi;
                p_pom.p_dalsi = null;
            }
            return p_pom;
        }

        public static Prvek VypustPred(Prvek p_seznam, Prvek p_nasl)
        {
            /* Musíme projít celým seznamem od začátku a nalézt předchůdce vypuštěného prvku
             * a dále postupovat jako v metodě VypustZa()
             * p_nasl ukazuje na následníka rušeného prvku
             * metoda vrací ukazatel na vypuštěný prvek případně vrací hodnotu null,
             * pokud byl p_pred posledním prvkem seznamu
             */

            Prvek p_pom, p_pred;

            p_pred = p_seznam;
            while (p_pred.p_dalsi.p_dalsi != p_nasl)
            {
                p_pred = p_pred.p_dalsi;
            }

            p_pom = p_pred.p_dalsi;         // metoda VypustZa()

            if (p_pom != null)
            {
                p_pred.p_dalsi = p_pom.p_dalsi;
                p_pom.p_dalsi = null;
            }

            return p_pom;
        }

        public static int Zmena(int cislo)
        {return 2 * cislo;}
        
        public static void PruchodZmena(Prvek p_seznam)
        {
            // Metoda pruchod - projde seznamem a s polozkou hodnota provede akci zmena 

            Prvek p_pom;

            p_pom = p_seznam;
            while (p_pom != null)
            {
                p_pom.hodnota = Zmena(p_pom.hodnota);
                p_pom = p_pom.p_dalsi;
            }
        }

        public static Prvek Vyhledej(Prvek p_seznam, int x)
        {
            /* Hledání prvku s danou vlastností. V lineárním spojovém seznamu máme nalézt první prvek takový, jehož položka hodnota je rovné dané hodnotě X
             * 
             * p_seznam - začátek seznamu,
             * X - hledaná hodnota,
             * 
             * vrací ukazatel na první prvek s hodnotou rovnou X
             * pokud X není v seznamu, vrací null
             */

            Prvek p_pom;

            p_pom = p_seznam;
            while((p_pom != null) && (p_pom.hodnota != x))
            {
                p_pom = p_pom.p_dalsi;
            }

            return p_pom;
        }


        
        static void Main(string[] args)
        {

            const int n = 11;

            Prvek sez = null;
            Prvek sez2 = null;

            Prvek cislo = new Prvek();
            cislo.hodnota = 100;

            /*Prvek cislo2 = new Prvek();
            cislo.hodnota = 4;*/

            Console.WriteLine();
            sez2 = PřidáníNaKonec(n);
            TiskSeznamu(sez2);
            Console.WriteLine("\n");

            sez = PřidáníNaZačátek(n);
            TiskSeznamu(sez);
            Console.WriteLine("\n");

            VlozZa(sez.p_dalsi.p_dalsi.p_dalsi.p_dalsi, cislo);
            TiskSeznamu(sez);
            Console.WriteLine("\n\tNový prvek byl vložen za 5. prvek\n");
            
            VlozPred(sez2.p_dalsi.p_dalsi.p_dalsi.p_dalsi, cislo);
            TiskSeznamu(sez2);
            Console.WriteLine("\n\tNový prvek byl vložen před 5. prvek\n");

            cislo.hodnota = 1;
            
            VypustZa(cislo);
            TiskSeznamu(sez);
            Console.WriteLine("\n\tPrvek byl vypuštěn za 5. prvek s hodnotou 5\n");

            VypustPred(sez, sez.p_dalsi.p_dalsi.p_dalsi.p_dalsi.p_dalsi);
            TiskSeznamu(sez);
            Console.WriteLine("\n\tPrvek byl vypuštěn za 5. prvek s hodnotou 5\n");

            while (sez != null)
            {
                Console.Write("{0,5}", Zmena(sez.hodnota));
                sez = sez.p_dalsi;
            }
            Console.WriteLine("\n\tSe všemi prvky byla provedena Zmena()\n");

            Vyhledej(sez, 12);
            Console.WriteLine("\n\tNalezen prvek s hodnotou 12?\n");

            Console.ReadLine();
        }
    }
}
