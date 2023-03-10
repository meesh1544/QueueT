using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace QueueT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List < string> foods = new List<string> { "Spaghetti and Meatballs", "Sushi", "yellow fin Tuna", "Carne Asada", "taco" };
            string tempName = "Casada Cake";
            foods.Add (tempName);
            foods.Insert(0, "Steak Salad");

            Console.WriteLine($"The original food list has {foods.Count()} foods");
            string[] foodsArr = new string[] { "Burger", "Truffle Fries", "Chicken Mexicali", "Pepper Steak", "Chicken Picata" };
            foods.AddRange(foodsArr);
            Console.WriteLine($"THe new food list now has {foods.Count()} foods");

            Console.WriteLine("---------Original List----------");
            for (int i = 0; i < foods.Count(); i++)
                Console.WriteLine(foods[i]);

            foods.Remove("Casada Cake");
            foods.Remove(foods[2]);
            foods.RemoveRange(4, 1);

            Console.WriteLine($"The revised list now includes {foods.Count()} foods");
            Console.WriteLine("------------Revised List------------");
            for (int i = 0; i < foods.Count(); i++) 
            Console.WriteLine(foods[i]);
            

            foods.Sort();
            Console.WriteLine("--------Sorted List--------");
            foreach (string f in foods)
                Console.WriteLine (f);
            foods.Reverse();
            Console.WriteLine("-------Reverse Sorted--------");
            foreach (string f in foods)
                Console.WriteLine (f);
           
        }
    }
}