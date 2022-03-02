using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        /*static void _____(string[] args)
        {
            /* instanční: může být volána pouze v souvislosti s
             *    určitou instancí třídy (objektem třídy)
             * statické: může být aktivována bez nutnosti 
             *    existence statické třídy
             *    
             * public: přístup bez omezení
             * protected: uvnitř vlastní třídy a jejich předkem
             * private (implicitní hodnota): metoda pouze pro třídy stejného druhu
             *    
             * jestli není void, musí být return;  
             *    
             *    
             *
        }*/


        class Výpočty
        {   // instanční metody
            public int Součet(int a, int b)
            {
                return (a + b);
            }
            public int Součin(int a, int b)
            {
                return (a * b);
            }

            // statické metody
            public static int Rozdíl(int a, int b)
            {
                return (a - b);
            }
            public static int Podíl(int a, int b)
            {
                return (a / b);
            }
        }

        class Operace
        {
            static void Main(string[] args)
            {
                // instanciace třídy Výpočty
                Výpočty instanceVýpočty = new Výpočty();

                // volání instančních metod
                Console.WriteLine("Součet je {0}", instanceVýpočty.Součet(5, 3));
                Console.WriteLine("Součin je {0}", instanceVýpočty.Součin(5, 3));

                // volání statických metod
                Console.WriteLine("Rozdíl je {0}", Výpočty.Rozdíl(5, 3));
                Console.WriteLine("Podíl je {0}", Výpočty.Podíl(5, 3));

                Console.ReadLine();
            }
        }

       

    }
    
}
