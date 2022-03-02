using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_1
{
    class Program
    {
        static public void MyPetsFromOldest(List<string> myPets, int year)
        {
            Console.WriteLine("My pets from oldest in {0}", year);
            for (int i = 0; i < myPets.Count; i++)
            {
                Console.WriteLine(i + 1 + ") " + myPets[i]);
            }
            Console.WriteLine();

        }

        static public void MyPetsOldest(List<string> myPets, int year)
        {
            Console.WriteLine("Who is my oldest pet in {0}", year);
            myPets.Last();
            Console.WriteLine();

        }

        static public void MyPetsNewest(List<string> myPets, int year)
        {
            Console.WriteLine("Ny pets from oldest in {0}", year);
            for (int i = 0; i < myPets.Count; i++)
            {
                Console.WriteLine(i + 1 + ") " + myPets[i]);
            }
            Console.WriteLine();

        }

        static void Main(string[] args)
        {
            /*// Creating a pet list and adding pets
            List<string> myPets = new List<string>();
            // List<T> name = new List<T>();

            myPets.Add("Dog");
            myPets.Add("Cat");
            myPets.Add("Parrot");

            // V seznamu může být jen string
            var seznam = new List<string>();
            var seznam3 = new List<string> {"a", "b"};

            var sez = new List<string>();
            sez = seznam3;

            // Nevím co mi dojde, může tam být cokoliv - číslo/text
            dynamic seznam2 = new List<int>();

            var rnd = new Random();
            Random rnd2 = new Random();

            rnd.ZískejNáhodnéČíslo();*/


            var oop = new Random(5, 5, 5);
            if (oop is BaseRandom brandom)
            {
            }

        }

        public class Random : BaseRandom
        {
            /*internal int ZískejNáhodnéČíslo()
            {
                return 5;
            }*/

            public Random(int num1, int num2, int num3) : base(num1, num2)
            {
                this.num3 = num3;
            }
        }

        public class BaseRandom
        {

            internal int _num1;
            internal int _num2;

            public BaseRandom(int num1, int num2)
            {
                _num1 = num1;
                _num2 = num2;
            }
        }
    }
}
