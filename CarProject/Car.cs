using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    class Car
    {
        public string Model { get; set; }
        public string Brand { get; }
        public int publishedYear { get; }
        public string Colour { get; }
        public double horsePower { get; }

        //public Car(string model, string brand, int publishedyear, string colour, double horsepower)
        //{
        //    Model = model;
        //    Brand = brand;
        //    publishedYear = publishedyear;
        //    Colour = colour;
        //    horsePower = horsepower;
        //}


        public void GenerateRandomCar()
        {
			CarDatabase carDatabase = new CarDatabase();
			Random random = new Random();

			// Generate 100 random cars
			for (int i = 0; i < 100; i++)
			{
				string model = carDatabase.models[random.Next(0, 5)];
				string brand = carDatabase.brands[random.Next(0, 5)];
				int publishedYear = carDatabase.publishedYears[random.Next(0, 5)];
				string colour = carDatabase.colours[random.Next(0, 5)];
				double horsepower = carDatabase.horsePower[random.Next(0, 5)];
				Console.WriteLine($"Model: {model}\nBrand: {brand}\nYear published: {publishedYear}\nColour: {colour}\nHorsepower: {horsepower}");
				Console.WriteLine("-----------------");
			}
		}

        public void DifferentOptions(int input)
        {
            //if(input == 2)
            //{

            //}
        }

		public void PrintAllCarsWithSameBrandAsFirstCar(string input)
		{

		}

		public void PrintAllCarsWithMoreThan200HorsePower(string input)
        {

        }

		public void PrintAllCarsWithSameColour(string input)
        {
			//CarDatabase carDatabase = new CarDatabase();
			//string colour = input;

			//         if(colour == "Red")
			//         {
			//	GenerateRandomCar();
			//}
		}

		public void PrintAllCarsPublished()
        {

        }
	}
}
