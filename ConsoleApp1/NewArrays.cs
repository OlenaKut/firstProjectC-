namespace MyMethod;

class NewArrays
{
    static void Main(string[] args)
    {
        int[] sampleArray1 = new int[5];


        int[] sampleArray2 = new int[] { 1, 2, 3, 4, 5 };

        // int[] sampleArray3 = new int[5] { 1, 2, 3, 4, 5 };
        //int[] sampleArray4 = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Enter the number of employees: ");

        int lenght = int.Parse(Console.ReadLine() ?? string.Empty);

        int[] employeesIds = new int[lenght];



        for (int i = 0; i < lenght; i++) // set the employees ID
        {
            Console.WriteLine("Enter the employee ID: ");
            int id = int.Parse(Console.ReadLine() ?? string.Empty);

            employeesIds[i] = id;
        }

        for (int i = 0; i < employeesIds.Length; i++) // print the employees ID
        {
            Console.WriteLine($"Employee ID: {employeesIds[i]}");
        }


        Array.Sort(employeesIds); // sort the array
        Console.WriteLine("Sorted employee IDs: ");
        for (int i = 0; i < employeesIds.Length; i++) // print the employees ID
        {
            Console.WriteLine($"Employee ID: {employeesIds[i]}");
        }

        int[] employeesIdsCopy = new int[lenght]; // create a new array with the same length as employeesIds
        employeesIds.CopyTo(employeesIdsCopy, 0); // copy the employeesIds array to employeesIdsCopy

        Array.Reverse(employeesIds); // reverse the employeesIds array

    }
}