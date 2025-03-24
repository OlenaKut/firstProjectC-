using System;
using System.Text;

class StringsLesson
{

    static void Main(string[] args)
    {
        //string myString = "My life \"is\" perfect"; // \"is\" is a double quote
        //string myString = "My life \"is\" \nperfect"; // \n is a new line
        //string myString = "My life is c:\\ perfect"; // \\ is a backslash
        //string myString = @"My life is c:\ perfect"; // @ is a verbatim string

        //string myString = String.Format("{1} = {0}", "First", "Second"); // Second = First

        //string myString = String.Format("{0:C}", 123.45); // $123.45, :C is currency
        //string myString = String.Format("{0:N}", 1234567890); // 1,234,567,890, :N is number
        //string myString = String.Format("{0:P}", .025); // 25.00%, :P is percentage")

        //string myString = String.Format("Phone number: {0:(###) ###-####}", 0760575455); // Phone number: (76) 057-5455

        //string myString = "  That summer we took threes across the board  ";
        //myString = myString.Substring(6, 6); // summer; 6 is the starting index, 6 is the length
        //myString = myString.ToUpper(); // SUMMER
        //myString = myString.Replace(" ", "*"); // *That*summer*we*took*threes*across*the*board*
        //myString = myString.Remove(6, 6);

        //myString = String.Format("Length before: {0} -- Length after: {1}", myString.Length, myString.Trim().Length); // Length before: 46 -- Length after: 42
        //myString = myString.Trim();


        /*string myString = "";
        for (int i = 0; i < 100; i++)
        {
            myString += "*" + i.ToString(); // *0*1*2*3*4*5*6*7*8*9*10*11*12*13*14*15*16*17*18*...
        }*/

        StringBuilder myString = new StringBuilder();

        for (int i = 0; i < 100; i++)
        {
            //myString.Append("--" + i.ToString()); // --0--1--2--3--4--5--6--7--8--9--10--11--12--13--14--15--16--17--18--...
            myString.Append("*");
            myString.Append(i);
        }




        Console.WriteLine(myString);
        Console.ReadLine();
    }

}

//dotnet run