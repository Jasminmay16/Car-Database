using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    class Car
    {
        private string Model { get; }
        private string Brand { get; }
        private int publishedYear { get; }
        private string Colour { get; }
        private double horsePower { get; }

        public Car(string model, string brand, int publishedyear, string colour, double horsepower)
        {
            Model = model;
            Brand = brand;
            publishedYear = publishedyear;
            Colour = colour;
            horsePower = horsepower;
        }

        public void PrintCar()
        {
            Console.WriteLine($"Model: {Model}");
			Console.WriteLine($"Brand: {Brand}");
			Console.WriteLine($"Published Year: {publishedYear}");
			Console.WriteLine($"Colour: {Colour}");
			Console.WriteLine($"Horse Power: {horsePower}");
		}
	}
}
