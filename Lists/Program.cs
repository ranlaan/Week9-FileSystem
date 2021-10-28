using System;
using System.Collections.Generic;
namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> mywishes = new List<string>();
            mywishes.Add("Headphones");
            mywishes.Add("Dog");
            mywishes.Add("slave");
            mywishes.Add("Car");

            //Console.WriteLine($"There are {mywishes.Count} items on your wish list.");

            //Console.WriteLine(mywishes[0]);
            //Console.WriteLine(mywishes[mywishes.Count - 1]);

            foreach(string wish in mywishes)
            {
                Console.WriteLine($"Item on your wish list: {wish}");
            }

            Console.WriteLine();

            Console.WriteLine("Enter a wish:");
            string userwish = Console.ReadLine();

            mywishes.Add(userwish);
            foreach (string wish in mywishes)
            {
                Console.WriteLine($"Item on your wish list: {wish}");
            }

        }
    }
}
