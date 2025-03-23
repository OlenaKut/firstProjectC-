// See https://aka.ms/new-console-template for more information
using System;
using System.Runtime.CompilerServices;

class MethodsLesson
{

    // Declare class-level fields
    private static string? myFirstName;
    private static string? myLastName;
    private static string? myLocation;
    static void Main(string[] args)
    {
        HelloWorld();
    }

    private static void HelloWorld()
    {
        Console.WriteLine("What is your name?");
        Console.Write("Type your first name: ");
        myFirstName = Console.ReadLine() ?? string.Empty;

        Console.Write("Type your last name: ");
        myLastName = Console.ReadLine() ?? string.Empty;

        Console.Write("Where do you live: ");
        myLocation = Console.ReadLine() ?? string.Empty;

        //Console.WriteLine("Hello, " + myFirstName + " " + myLastName + " from " + myLocation);
        //Console.ReadLine();

        ReverseMethod();

    }

    private static void ReverseMethod()
    {
        string result = myFirstName + " " + myLastName + " " + myLocation;
        char[] charArray = result.ToCharArray();
        Array.Reverse(charArray);


        foreach (char input in charArray)
        {
            Console.Write(input);
        }
    }


}