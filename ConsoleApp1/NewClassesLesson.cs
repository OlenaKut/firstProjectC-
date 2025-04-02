namespace MyNamespace
{
    class NewClassesLesson
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            Car.MyMethod();

            /*myCar.Make = "Toyota";
            myCar.Model = "Corolla";
            myCar.Year = 2020;
            myCar.Color = "Red";
            */
            Console.WriteLine(myCar.Make);

            //Car myCar3 = new Car("Volvo", "XC60", 2016, "Black");
            //Console.WriteLine("{0} {1} {2} {3}", myCar3.Make, myCar3.Model, myCar3.Year, myCar3.Color);

            Car myCar2 = new Car();
            myCar2 = myCar;

            Console.WriteLine("{0} {1} {2} {3}", myCar2.Make, myCar2.Model, myCar2.Year, myCar2.Color);

            myCar2.Make = "Honda";
            myCar2.Color = "Blue";
            Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);

            //myCar = null;
            //Console.WriteLine("{0} {1} {2} {3}", myCar.Make, myCar.Model, myCar.Year, myCar.Color);



        }


        class Car
        {
            public string? Make { get; set; }
            public string? Model { get; set; }
            public int? Year { get; set; }
            public string? Color { get; set; }

            /*public Car()
            {
                Make = "Nissan";
            }

            public Car(string make, string model, int year, string color)
            {
                Make = make;
                Model = model;
                Year = year;
                Color = color;
            }*/

            public static void MyMethod()
            {
                Console.WriteLine("MyMethod");
            
            }

        }
    }
}