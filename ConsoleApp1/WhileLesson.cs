using System;
using System.Runtime.CompilerServices;

class WhileLesson
{

    /*// Declare class-level fields
    private static string? myFirstName;
    private static string? myLastName;
    private static string? myLocation;*/

    static void Main(string[] args)
    {

        /*int i = 10;
        while (i > 0) 
        {
            Console.WriteLine( i);
            i--;
        }*/

        /*int i = 0;
        int j = 0;
        while (i < 10)
        {
           while (j < 10)
            {
                Console.WriteLine("i = {0}, j = {1}", i, j);
                j++;
            }
            i++;
            j = 0;
        }*/

        bool displayMenu = true;
        while (displayMenu)
        {
            displayMenu = MainMenu();
        }
        //MainMenu();
        //PrintNumbers();
        //GuessingGame();
    }

    private static bool MainMenu()
    {
        Console.Clear();
        Console.WriteLine("Choose an option from the menu:");
        Console.WriteLine("1) Print numbers");
        Console.WriteLine("2) Guessing Game");
        Console.WriteLine("3) Exit");
        Console.Write("Enter your choice: ");
        string result = Console.ReadLine() ?? string.Empty;

        if (result == "1")
        {
            PrintNumbers();
            return true;
        }
        else if (result == "2")
        {
            GuessingGame();
            return true;
        }
        else if (result == "3")
        {
            return false;
        }
        else
        {
            return true;
        }

        /*switch (result)
        {
            case "1":
                Console.WriteLine("You chose Option 1");
                PrintNumbers();
                return true;
            case "2":
                Console.WriteLine("You chose Option 2");
                GuessingGame();
                return true;
            case "3":
                Console.WriteLine("Goodbye!");
                return false;
            default:
                Console.WriteLine("Invalid choice");
                return true;
        }*/

    }

    private static void PrintNumbers()
    {
        Console.Clear();
        Console.WriteLine("Print numbers!");
        Console.Write("Type a number: ");
        int result = int.Parse(Console.ReadLine() ?? string.Empty);
        int counter = 1;

        while (counter < result + 1)
        {
            Console.Write(counter);
            Console.Write("-");
            counter++;
        }
        Console.ReadLine();
    }
    private static void GuessingGame()
    {
        //Console.Clear();
        Console.WriteLine("Guessing Game!");
        Console.Write("Type a number: ");
        Random myRandom = new Random();
        int randomNumber = myRandom.Next(1, 11);

        int guesses = 0;
        bool incorrect = true;

        do
        {
            Console.WriteLine("Guess a number between 1 and 10: ");
            string result = Console.ReadLine() ?? string.Empty;
            guesses++;
            if (result == randomNumber.ToString())
                incorrect = false;
            else
                Console.WriteLine("Wrong! Try again!");

        } while (incorrect);
        Console.WriteLine("Correct! It took {0} guesses.", guesses);
        Console.WriteLine("The correct number was {0}.", randomNumber);
        Console.ReadLine();


        /*int i = 0;
        do
        {
            Console.WriteLine(i);
            i++;
        } while (i < 10);*/
    }

}

