using System;
using System.Collections.Generic;

namespace CollectionsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Three Basic Arrays
            int[] numbers = {0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            string[] names = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] truefalse = {true, false, true, false, true, false, true, false, true, false};

            // // Ice Cream Flavors
            List<string> flavors = new List<string>();
            flavors.Add("Cookie Dough");
            flavors.Add("Vanilla");
            flavors.Add("Chocolate");
            flavors.Add("Neopolitan");
            flavors.Add("Mint");
            System.Console.WriteLine(flavors.Count);
            Console.WriteLine(flavors[3]);
            flavors.RemoveAt(3);
            System.Console.WriteLine(flavors.Count);

            // // Favorite Flavors
            Random random= new Random();
            Dictionary<string, string> FavoriteFlavor = new Dictionary<string, string>();
            for(int i=0; i<names.Length; i++)
            {
                FavoriteFlavor.Add(names[i], flavors[random.Next(flavors.Count)]);
            }
            foreach(KeyValuePair<string,string> entry in FavoriteFlavor)
            {
                Console.WriteLine($"{entry.Key}'s favorite flavor is {entry.Value}");
            }

        }
    }
}
