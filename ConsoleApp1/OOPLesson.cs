namespace MyMethod;

class OOPLesson
{
    static void Main(string[] args)
    {
        Car car = new Car();
        car.Make = "Toyota";
        car.Model = "Corolla";
        car.Year = 2020;
        car.Color = "Red";

    }

    class Car
    {
        private string? Make { get; set; } // private
        public string? Model { get; set; }
        public int? Year { get; set; }
        public string? Color { get; set; }


        public string GetMake() // make Make public
        {
            get
            {
                return Make;
            }
            set
            {
                Make = value;
            }
        }


    }
}
