// See https://aka.ms/new-console-template for more information
using System;

class ArraysLesson
{
    static void Main(string[] args)
    {
        /*int[] numbers = new int[5];
        numbers[0] = 4;
        numbers[1] = 8;
        numbers[2] = 15;
        numbers[3] = 16;
        numbers[4] = 23;
        //numbers[5] = 33;

        Console.WriteLine(numbers[1]);
        Console.WriteLine(numbers.Length);*/

        int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };
        string[] names = new string[] { "Olena", "Alex", "Michael", "David" };

        Console.WriteLine(names[1]);
        Console.WriteLine(names.Length);

        //for
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }
        //foreach
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        string zig = "You can get what you want out of life" +
            "if you help enough other people get what they want.";
        char[] charArray = zig.ToCharArray();
        Array.Reverse(charArray);

        foreach (char zigChar in charArray)
        {
            Console.Write(zigChar);
        }
        /*ToCharArray():

        This is a method of the string class in C#.
        It converts the string into an array of characters (char[]), where each element of the array represents a single character from the string.
        char[] charArray:

        This declares a character array (char[]) named charArray.
        The result of zig.ToCharArray() is assigned to this array.
        */
    }
}