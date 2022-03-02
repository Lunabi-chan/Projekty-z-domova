using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexovanySeznamList
{
    class Arrs
    {
        private int[] Arr { get; set; }
        
        public Arrs()
        {
            this.Arr = new int[5] { 0, 0, 0, 0, 0 };    // Or just: this.Arr = new int[5];
        }

        public void NewGrade(int n)
        {
            if (n < 1 || n > 5)
            {
                Console.WriteLine("Grade " + n + " is unknown. Nothing was changed.");                
            }
            else
            {
                this.Arr[n - 1]++;
            }            
        }

        public void ShowGradeStatistics()
        {
            int sum = 0;
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Grade statistics:");
            Console.WriteLine();
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Grade " + i + " was given " + this.Arr[i - 1] + " times.");
                sum += this.Arr[i - 1];
            }
            Console.WriteLine();
            Console.WriteLine("The total of " + sum + " grades were given.");
            Console.WriteLine();
            Console.WriteLine("The end of grade statistics.");
            Console.WriteLine("------------------------------------------");
        }
    }

    class Program
    {
        static public Random random = new Random();

        static public void MyPetsFromOldest(List<string> myPets, int year)
        {
            Console.WriteLine("My pets from oldest in {0}:", year);
            for (int i = 0; i < myPets.Count; i++)
            {
                Console.WriteLine(i + 1 + ") " + myPets[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        static public void MyPetsOldest(List<string> myPets, int year)
        {
            Console.WriteLine("Who is my oldest living pet in {0}?", year);
            Console.WriteLine(myPets.First());
            Console.WriteLine();
            Console.ReadKey();
        }
        static public void MyPetsNewest(List<string> myPets, int year)
        {
            Console.WriteLine("Who is my newest living pet in {0}?", year);
            Console.WriteLine(myPets.Last());
            Console.WriteLine();
            Console.ReadKey();
        }
        static public void MyPetsCount(List<string> myPets, int year)
        {
            Console.WriteLine("How many pets do I have in {0}?", year);
            Console.WriteLine("I have a total of " + myPets.Count + " pets.");
            Console.WriteLine();
            Console.ReadKey();
        }      
        static public void MyNthOldestPet(List<string> myPets, int year, int n)
        {            
            if (n <= 0)
            {
                Console.WriteLine("The value n = {0} is invalid.", n);
                Console.WriteLine();
                Console.ReadKey();
                return;
            }

            string th;
            switch (n % 10)
            {
                case 1:
                    th = "st";
                    break;
                case 2:
                    th = "nd";
                    break;
                case 3:
                    th = "rd";
                    break;
                default:
                    th = "th";
                    break;
            }

            Console.WriteLine("Who is my {1}{2} oldest living pet in {0}?", year, n, th);

            if (myPets.Count < n)
            {
                Console.WriteLine("I have only {0} pets in {1}, therefore none.", myPets.Count, year);
            }
            else
            {
                Console.WriteLine(myPets[n - 1]);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
        static public void MyPetsContain(List<string> myPets, int year, string pet)
        {
            Console.WriteLine("Do I have a pet {0} in {1}?", pet, year);
            if (myPets.Contains(pet))
            {
                Console.WriteLine("Yes, I do.");
            }
            else
            {
                Console.WriteLine("No, I don't.");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
        static public void HowManyOlderPetsThan(List<string> myPets, int year, string pet)
        {
            Console.WriteLine("How many living pets that are older than my pet {0} do I have in {1}?", pet, year);

            if (!myPets.Contains(pet))
            {
                Console.WriteLine("I don't have a pet {0} in {1}.", pet, year);
            }
            else
            {
                int olderPets = myPets.IndexOf(pet);
                Console.WriteLine("I have {0} older pets than my pet {1} in {2}.", olderPets, pet, year);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
        static public void MyPetsAlphabetically(List<string> myPets, int year)
        {
            Console.WriteLine("My pets in {0} sorted alphabetically according to their species:", year);
            myPets.Sort();
            for (int i = 0; i < myPets.Count; i++)
            {
                Console.WriteLine(i + 1 + ") " + myPets[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        static public void MyPetsFromNewest(List<string> myPets, int year)
        {
            Console.WriteLine("My pets from newest to oldest in {0}:", year);

            myPets.Reverse();            
            for (int i = 0; i < myPets.Count; i++)
            {
                Console.WriteLine(i + 1 + ") " + myPets[i]);
            }

            Console.WriteLine();
            Console.ReadKey();
        }
        static public void MyPetsFromNewestBetter(List<string> myPets, int year)
        {
            Console.WriteLine("My pets from newest to oldest in {0}:", year);

            for (int i = 0; i < myPets.Count; i++)
            {
                Console.WriteLine(i + 1 + ") " + myPets[myPets.Count - i - 1]);
            }

            Console.WriteLine();
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            #region Arrays
            {
                // Creating a grade array, generating random grades.
                Arrs arrs = new Arrs();
                int grade;
                for (int i = 1; i <= 50; i++)
                {
                    grade = random.Next(1, 6);
                    arrs.NewGrade(grade);
                }

                // Showing grade statistics.
                arrs.ShowGradeStatistics();
                Console.WriteLine();
            }

            Console.ReadKey();
            Console.WriteLine();
            #endregion

            #region Lists
            // Creating a pet list and adding pets.
            List<string> myPets = new List<string>();
            // List<T> name = new List<T>();

            myPets.Add("Hamster");
            myPets.Add("Dog");
            myPets.Add("Cat");

            MyPetsFromOldest(myPets, 2015);

            myPets.Add("Parrot");
            myPets.Add("Horse");
            MyPetsFromOldest(myPets, 2017);

            myPets.Remove("Hamster");
            for (int i = 0; i < 10; i++)
                myPets.Add("Ant");
            myPets.Add("Fish");
            myPets.Add("Ant");
            MyPetsFromOldest(myPets, 2019);

            myPets.RemoveAll(s => s == "Ant");
            MyPetsFromOldest(myPets, 2020);

            MyPetsOldest(myPets, 2020);

            MyPetsNewest(myPets, 2020);

            MyPetsCount(myPets, 2020);

            MyNthOldestPet(myPets, 2020, 2);

            MyPetsContain(myPets, 2020, "Dog");
            MyPetsContain(myPets, 2020, "Ant");

            HowManyOlderPetsThan(myPets, 2020, "Parrot");
            HowManyOlderPetsThan(myPets, 2020, "Dog");
            HowManyOlderPetsThan(myPets, 2020, "Donkey");

            #region Case 1
            /**/
            {
                MyPetsAlphabetically(myPets, 2020);
                // What is the disadvantage of doing it this way?

                MyPetsFromOldest(myPets, 2020);
            }
            /**/
            #endregion
            #region Case 2
            // How about this?
            /*/
            {
                List<string> myPetsSorted = myPets;
                MyPetsAlphabetically(myPetsSorted, 2020);
                MyPetsIn(myPets, 2020);
            }
            /*/
            #endregion
            #region Case 3
            // Uhh... Arrays, huh?
            /*/
            {
                string[] myPetsSorted = new string[myPets.Count];
                myPets.CopyTo(myPetsSorted);
                // myPetsSorted.Sort();
                // We need to code the sorting algorithm too...
                List<string> myPetsSortedList = myPetsSorted.ToList();
                MyPetsAlphabetically(myPetsSortedList, 2020);
                MyPetsIn(myPets, 2020);
            }
            /*/
            #endregion
            #region Case 4
            // Nice!
            /*/
            {
                List<string> myPetsSorted = new List<string>();
                foreach (string pet in myPets)
                {
                    myPetsSorted.Add(pet);
                }
                MyPetsAlphabetically(myPetsSorted, 2020);
                MyPetsIn(myPets, 2020);
            }
            /*/

            // Etc.
            #endregion

            myPets.RemoveAt(2);
            MyPetsFromOldest(myPets, 2021);

            #region Reverse
            List<string> myPetsReversed = new List<string>();
            foreach (string pet in myPets)
            {
                myPetsReversed.Add(pet);
            }
            MyPetsFromNewest(myPetsReversed, 2021);
            MyPetsFromOldest(myPets, 2021);

            MyPetsFromNewestBetter(myPets, 2021);
            #endregion
            #endregion

            #region Finish
            // Unnecessary if pressing <Ctrl> + <F5>.
            Console.WriteLine();
            Console.Write("Press any key to continue... ");
            Console.ReadKey();
            #endregion
        }
    }
}
