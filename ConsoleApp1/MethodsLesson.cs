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

        Console.Write("Result: ");
        Console.WriteLine(ReverseMethod(myFirstName + " " + myLastName + " " + myLocation));

        //Console.Write(ReverseMethod(String.Format("{0} {1} {2}", myFirstName, myLastName, myLocation)));
        Console.Write(ReverseMethod(String.Format("{0}", myFirstName)));
    }

    private static string ReverseMethod(string result)
    {
        //string result = myFirstName + " " + myLastName + " " + myLocation;
        char[] charArray = result.ToCharArray();
        Array.Reverse(charArray);
        return String.Concat(charArray);


        /*foreach (char input in charArray)
        {
            Console.Write(input);
        }*/
    }

}