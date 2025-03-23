// See https://aka.ms/new-console-template for more information
using System;


class IfElseLesson
{
    static void Main(string[] args)
    {


        Console.WriteLine("Olena's Big Giveaway");
        Console.Write("Choose a door: 1, 2, or 3: ");
        string userValue = Console.ReadLine() ?? string.Empty;

        if (userValue == "1")
        {
            string message = "You won a new car!";
            Console.WriteLine(message);
        }
        else if (userValue == "2")
        {
            string message = "You won a new boat!";
            Console.WriteLine(message);
        }
        else if (userValue == "3")
        {
            string message = "You won a new cat!";
            Console.WriteLine(message);
        }
        else
        {
            string message = "Sorry, we didn't understand. You lose!";
            Console.WriteLine(message);
        }

    }
}