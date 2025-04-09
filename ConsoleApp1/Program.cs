using System;
using System.IO;

class Program
{
    private static string directory = @"C:/Users/olenakutasevych/Desktop/Lexicon/";
    private static string fileName = "test.txt";

    static void Main(string[] args)
    {
        Console.WriteLine("What is your name?");
        Console.Write("Type your first name: ");
        string myFirstName = Console.ReadLine() ?? string.Empty;

        Console.Write("Type your last name: ");
        string myLastName = Console.ReadLine() ?? string.Empty;

        PerformWork(myFirstName, myLastName);

        // Call CheckForFile to demonstrate file handling
        CheckForFile();
    }

    static void PerformWork(string myFirstName, string myLastName)
    {
        var addName = myFirstName + " " + myLastName;
        Console.WriteLine("Hello, " + addName);
        // Add your work logic here
    }

    internal static void CheckForFile()
    {
        string filePath = directory + fileName;
        bool fileExists = File.Exists(filePath);

        if (fileExists)
        {
            Console.WriteLine("File exists.");
        }
        else
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            File.Create(filePath).Close();
            Console.WriteLine("File created: " + filePath);
        }
    }
}