namespace MyMethod;
class CollectionAndList
{
    static void Main(string[] args)
    {
        List<int> employeeIds = new List<int>();
        employeeIds.Add(1);
        employeeIds.Add(2);
        employeeIds.Insert(1, 3); // insert 3 at index 1
        employeeIds.Add(4);


        if (employeeIds.Contains(2))
        {
            Console.WriteLine("Employee ID 2 exists in the list.");
        }
        else
        {
            Console.WriteLine("Employee ID 2 does not exist in the list.");
        }

        int amount = employeeIds.Count;
        Console.WriteLine($"The number of employees is: {amount}");
        employeeIds.Remove(2);

        var empArray = employeeIds.ToArray(); // convert the list to an array
        Console.WriteLine("Employee IDs in the array:");
        foreach (var id in empArray)
        {
            Console.WriteLine(id);
        }

        employeeIds.Clear(); // clear the list




        Console.WriteLine("Enter the number of employees: ");
        int length = int.Parse(Console.ReadLine() ?? string.Empty);

        for (int i = 0; i < length; i++) // set the employees ID
        {
            Console.WriteLine("Enter the employee ID: ");
            int id = int.Parse(Console.ReadLine() ?? string.Empty);
            employeeIds.Add(id);
        }
        for (int i = 0; i < employeeIds.Count; i++) // print the employees ID
        {
            Console.WriteLine($"Employee ID: {employeeIds[i]}");
        }
    }


}

