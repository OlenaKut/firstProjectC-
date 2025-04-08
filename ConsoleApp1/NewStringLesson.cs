using System;
using System.Text;
using System.Collections.Generic;
using System.Text.Json;
using Newtonsoft.Json;
using BethanysPieShopHRM;

namespace BethanysPieShopHRM
{
    class NewStringLesson
    {
        static void Main(string[] args)
        {


            Employee olena = new Employee("Olena", "Kut", "cundrochka@gmail.com", new DateTime(1985-03-88), 25);
            string olenaJson = olena.ConvertToJson();
            Console.WriteLine(olenaJson); //{"FirstName":"Olena","LastName":"Kut","Email":"cundrochka@gmail.com","BirthDate":"0001-01-01T00:00:00.0001894","Age":25}


            // string name = "Olena";
            // string name2 = name;
            // name += " Kut";
            // Console.WriteLine(name); // Olena Kut
            // Console.WriteLine(name2); // Olena



            // string indexes = string.Empty;
            // for (int i = 0; i < 25; i++)
            // {
            //     indexes += i.ToString();
            // }
            // Console.WriteLine(indexes);
            // StringBuilderExample();
        }


        // private static void StringBuilderExample()
        // {
        //     string firstName = "Olena";
        //     string lastName = "Kut";

        //     StringBuilder builder = new StringBuilder();
        //     builder.AppendLine("My name is: ");
        //     builder.Append("First name: ");
        //     builder.AppendLine(firstName);
        //     builder.Append("Last name: ");
        //     builder.Append(lastName);
        //     string result = builder.ToString();

        //     Console.WriteLine(result);


        //     StringBuilder builder2 = new StringBuilder();
        //     for (int i = 0; i < 25; i++)
        //     {
        //         builder2.Append(i);
        //         builder2.Append(" ");

        //         string result2 = builder2.ToString();
        //         Console.WriteLine(result2);
        //     }
        // }


        public static void UsingACustomType()
        {
            List<string> list = new List<string>();
        }

        // Removed from here as it belongs to the Employee class.

        public class Employee
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public DateTime BirthDate { get; set; }
            public int Age { get; set; }

            public Employee(string firstName, string lastName, string email, DateTime birthDate, int age)
            {
                FirstName = firstName;
                LastName = lastName;
                Email = email;
                BirthDate = birthDate;
                Age = age;
            }

            public string ConvertToJson()
            {
                string json = JsonConvert.SerializeObject(this);// Newtonsoft.Json helps to convert the object to JSON
                return json;
            }
        }
    }
}

