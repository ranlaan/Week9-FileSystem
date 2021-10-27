using System;
using System.IO;

namespace FileCreate
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\opilane\Samples\Wishlist";
            Console.WriteLine("enter file name:");
            string fileName = Console.ReadLine();
            string fullFilepath = $@"{rootDirectory}\{fileName}.txt";

            bool directoryExists = Directory.Exists(rootDirectory);
            bool fileExists = File.Exists(fullFilepath);

            if(directoryExists && fileExists)
            {
                Console.WriteLine($"File {fileName} already exists in {rootDirectory}.");
            }
            else if (!directoryExists)
            {
                Console.WriteLine($"wishlist directory does not exist.");
                Directory.CreateDirectory(rootDirectory);
                File.Create(fullFilepath);
            }
            else
            {
                File.Create(fullFilepath);
                Console.WriteLine($"File {fileName}.txt has been created.");
            }

            

        }
    }
}
