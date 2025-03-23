// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        int x;
        int y;

        x = 7;
        y = x + 3;

        Console.WriteLine(y);


        Console.WriteLine("What is your name?");
        Console.Write("Type your first name: ");
        string myFirstName;
        myFirstName = Console.ReadLine() ?? string.Empty;

        Console.Write("Type your last name: ");
        string myLastName;
        myLastName = Console.ReadLine() ?? string.Empty;
        /*Explanation:
        Console.ReadLine():

        This method reads a line of input from the user in the console.
        It returns the input as a string or null if no input is provided (e.g., if the user presses Enter without typing anything).
        ?? (Null-Coalescing Operator):

        This operator checks if the value on the left side (Console.ReadLine()) is null.
        If it is null, the value on the right side (string.Empty) is used instead.
        string.Empty:

        This is a shorthand for an empty string ("").
        It ensures that myLastName is assigned an empty string if the user provides no input.*/
        Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
        Console.ReadLine();
    }
}





