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


        PerformWork(myFirstName, myLastName);
    }

    static void PerformWork(string myFisrtName, string myLastName)
    {
        var addName = myFisrtName + " " + myLastName;
        Console.WriteLine("Hello, " + addName);
        // Add your work logic here
    }
}





