using System.Drawing;
using System.Reflection;

namespace CarProject
{
    internal class Program
	{
		public static List<Car> cars;

		static void Main(string[] args)
		{
			cars = new List<Car>();

			bool isProgramRunning = true;
			GenerateRandomCar(100);

			while (isProgramRunning)
			{
				Console.WriteLine("Velkommen til bilbasen!\n");
				Console.WriteLine("Valgmuligheder:");
				Console.WriteLine("1. Udskriv alle biler som deler mærke med den første bil");
				Console.WriteLine("2. Udskriv alle biler som har over 200HK");
				Console.WriteLine("3. Udskriv alle biler som er røde");
				Console.WriteLine("4. Udskriv antallet af biler som har samme mærke som den første bil");
				Console.WriteLine("5. Udskriv alle biler som er mellem årgangen 1980 og 1999");
				int input = Convert.ToInt32(Console.ReadLine());

				DifferentOptions(input);
				Console.ReadKey();
				Console.Clear();
			}

		}
		public static void GenerateRandomCar(int amount)
		{
			CarDatabase carDatabase = new CarDatabase();
			Random random = new Random();

			// Generate 100 random cars
			for (int i = 0; i < amount; i++)
			{ 
				string model = carDatabase.models[random.Next(0, 5)];
				string brand = carDatabase.brands[random.Next(0, 5)];
				int publishedYear = carDatabase.publishedYears[random.Next(0, 5)];
				string colour = carDatabase.colours[random.Next(0, 5)];
				double horsepower = carDatabase.horsePower[random.Next(0, 5)];
				int cylinders = carDatabase.cylinders[random.Next(0, 5)];
				//Console.WriteLine($"Model: {model}\nBrand: {brand}\nYear published: {publishedYear}\nColour: {colour}\nHorsepower: {horsepower}\n Cylinders: {cylinders}");
				//Console.WriteLine("-----------------");

				cars.Add(new Car(model, brand, publishedYear, colour, horsepower, cylinders));
			}
		}

		public static void DifferentOptions(int input)
		{
			switch (input)
			{
				case 1:
					PrintAllCarsWithSameBrandAsFirstCar();
					break;
				case 2:
					PrintAllCarsWithMoreThan200HorsePower();
					break;
				case 3:
					PrintAllCarsWithSameColour();
					break;
				case 4:
					PrintAmountOfSameBrand();
					break;
				case 5:
					PrintAllCarsPublished();
					break;
			}
		}

		public static void PrintAllCarsWithSameBrandAsFirstCar()
		{
			Car targetCar = cars[0];
			foreach (Car car in cars)
			{
				if (car.Brand == targetCar.Brand)
				{
					Console.WriteLine($"Model: {car.Model}\nBrand: {car.Brand}\nYear published: {car.PublishedYear}\nColour: {car.Colour}\nHorsepower: {car.Horsepower}\nCylinders: {car.Cylinders}");
					Console.WriteLine("-----------------");
				}
			}
		}

		public static void PrintAmountOfSameBrand()
		{
			int totalAmount = 0;
			Car targetCar = cars[0];
			foreach (Car car in cars)
			{
				if (car.Brand == targetCar.Brand)
				{
					totalAmount++;
				}
			}
			Console.WriteLine($"Total amount of cars with the brand: {targetCar.Brand}: {totalAmount}");
		}
		public static void PrintAllCarsWithMoreThan200HorsePower()
		{
			foreach (Car car in cars)
			{
				if(car.Horsepower >= 200)
				{
					Console.WriteLine($"Model: {car.Model}\nBrand: {car.Brand}\nYear published: {car.PublishedYear}\nColour: {car.Colour}\nHorsepower: {car.Horsepower}\nCylinders: {car.Cylinders}");
					Console.WriteLine("-----------------");
				}
			}
		}

		public static void PrintAllCarsWithSameColour()
		{
			foreach(Car car in cars)
			{
				if(car.Colour == "Red")
				{
					Console.WriteLine($"Model: {car.Model}\nBrand: {car.Brand}\nYear published: {car.PublishedYear}\nColour: {car.Colour}\nHorsepower: {car.Horsepower}\n Cylinders: {car.Cylinders}");
					Console.WriteLine("-----------------");
				}
			}
		}

		public static void PrintAllCarsPublished()
		{
			foreach(Car car in cars)
			{
				if(car.PublishedYear >= 1980 && car.PublishedYear <= 1990)
				{
					Console.WriteLine($"Model: {car.Model}\nBrand: {car.Brand}\nYear published: {car.PublishedYear}\nColour: {car.Colour}\nHorsepower: {car.Horsepower}\n Cylinders: {car.Cylinders}");
					Console.WriteLine("-----------------");
				}
			}
		}
	}
}
