using System;

namespace LSS
{
    /*
     * Vytvoř lineární spojový seznam s prvky 2, 16, 22 přidáváním na začátek a vytiskni ho
     */
    public class Prvek
    {
        public int hodnota;
        public Prvek p_dalsi;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Prvek p_novy = null;
            Prvek p_seznam = null;

            //Vytvoření prvního prvku
            p_novy = new Prvek();
            p_novy.hodnota = 2;
            p_novy.p_dalsi = null;          //nebo p_novy.p_dalsi = p_seznam;
            p_seznam = p_novy;

            //Vytvoření druhého prvku - *** deklarace class s inicializací ***
            p_novy = new Prvek() { hodnota = 16, p_dalsi = p_seznam };

            /*
             * p_novy = new Prvek();
             * p_novy.hodnota = 16
             * p_novy.p_dalsi = p_seznam;
             */

            p_seznam = p_novy;

            //Vytvoření třetího prvku
            p_novy = new Prvek();
            p_novy.hodnota = 2;
            p_novy.p_dalsi = null;
            p_seznam = p_novy;

            while (p_seznam != null)
            {
                Console.Write("{0,5}", p_seznam.hodnota);
                p_seznam = p_seznam.p_dalsi;
            }

            Console.ReadLine();
        }
    }
}
