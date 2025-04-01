// See https://aka.ms/new-console-template for more information
using System;

class ClassesLesson
{
    static void Main(string[] args)
    {

        Car myCar = new Car();
        myCar.Make = "Toyota";
        myCar.Model = "Corolla";
        myCar.Year = 2020;
        //myCar.Color = "Red";
        Console.WriteLine(myCar.Make);
        Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);

        /*decimal value = DetermineMarektValue(myCar);
        Console.WriteLine("Market value: {0:C}", value);
        //Console.WriteLine("Market value: {0:C}", DetermineMarektValue(myCar));

        Console.WriteLine("{0} {1} {2} {3} {4:C}", myCar.Make, myCar.Model, myCar.Year, myCar.Color, value);*/

        Console.WriteLine("{0} {1} {2} {3} {4:C}", myCar.Make, myCar.Model, myCar.Year, myCar.Color, myCar.DetermineMarektValue());
    }

    private static decimal DetermineMarektValue(Car car)
    {
        decimal carValue = 100.0M;
        return carValue;
    }
    class Car
    {
        public string? Make { get; set; }
        public string? Model { get; set; }
        public int? Year { get; set; }
        public string? Color { get; set; }

        public decimal DetermineMarektValue()
        {
            decimal carValue;
            if (Year > 1990)
            {
                carValue = 10000.0M;
            }
            else
            {
                carValue = 5000.0M;
            }
            return carValue;
        }
    }
}