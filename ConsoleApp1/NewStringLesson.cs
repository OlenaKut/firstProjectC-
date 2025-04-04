using System;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;


namespace MyNamespace
{
    class NewStringLesson
    {
        static void Main(string[] args)
        {
            string name = "Olena";
            string name2 = name;
            name += " Kut";
            Console.WriteLine(name); // Olena Kut
            Console.WriteLine(name2); // Olena



            string indexes = string.Empty;
            for (int i = 0; i < 25; i++)
            {
                indexes += i.ToString();
            }
            Console.WriteLine(indexes);
            StringBuilderExample();
        }


        private static void StringBuilderExample()
        {
            string firstName = "Olena";
            string lastName = "Kut";

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("My name is: ");
            builder.Append("First name: ");
            builder.AppendLine(firstName);
            builder.Append("Last name: ");
            builder.Append(lastName);
            string result = builder.ToString();

            Console.WriteLine(result);


            StringBuilder builder2 = new StringBuilder();
            for (int i = 0; i < 25; i++)
            {
                builder2.Append(i);
                builder2.Append(" ");

                string result2 = builder2.ToString();
                Console.WriteLine(result2);
            }
        }

    }
}