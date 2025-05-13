namespace CarProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Model A", "Toyota", 2000, "White", 200);

			car.PrintCar();
		}
    }
}
