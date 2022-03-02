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
            Console.ReadKey;

        }

        static public void MyPetsOldest(List<string> myPets, int year)
        {
            Console.WriteLine("Who is my oldest pet in {0}", year);
            myPets.Last
            Console.WriteLine();
            Console.ReadKey;

        }

        static public void MyPetsNewest(List<string> myPets, int year)
        {
            Console.WriteLine("Ny pets from oldest in {0}", year);
            for (int i = 0; i < myPets.Count; i++)
            {
                Console.WriteLine(i + 1 + ") " + myPets[i]);
            }
            Console.WriteLine();
            Console.ReadKey;

        }

        static void Main(string[] args)
        {
            // Creating a pet list and adding pets
            List<string> myPets = new List<string>();
            // List<T> name = new List<T>();

            myPets.Add("Dog");
            myPets.Add("Cat");
            myPets.Add("Parrot");






        }
    }
}
