using System;

class DateTimeLesson
{
    static void Main(string[] args)
    {
        DateTime myValue = DateTime.Now;
        //Console.WriteLine(myValue.ToString());
        //Console.WriteLine(myValue.ToShortDateString());
        //Console.WriteLine(myValue.ToLongDateString());
        //Console.WriteLine(myValue.ToLongTimeString());
        //Console.WriteLine(myValue.ToShortTimeString());

        //Console.WriteLine(myValue.AddDays(3));
        //Console.WriteLine(myValue.AddHours(5));

        //Console.WriteLine(myValue.AddDays(5).ToLongDateString());

        //Console.WriteLine(myValue.AddHours(-5));

        //DateTime myBirthDay = new DateTime(1985, 03, 08);
        //Console.WriteLine(myBirthDay.ToShortDateString());

        //DateTime myBirthDay = DateTime.Parse("1985-03-08");
        //Console.WriteLine(myBirthDay.ToShortDateString());


        DateTime myBirthDay = DateTime.Parse("1984-01-18");
        DateTime myDay = DateTime.Parse("1900-01-01");
        TimeSpan myAge = myBirthDay - myDay;
        //TimeSpan myAge = DateTime.Now.Subtract(myBirthDay); 


        Console.WriteLine(myAge.TotalDays);
        //Console.WriteLine(myAge.TotalHours);


        Console.ReadLine();




    }
}