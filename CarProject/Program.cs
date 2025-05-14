using System.Drawing;
using System.Reflection;

namespace CarProject
{
    internal class Program
	{
		//Changed all the Car objects to ICar, as I've now implemented an interface
		//Changed all the ICar to Vehicle, as I've created a superclass
		public static List<Vehicle> cars;
		
		static void Main(string[] args)
		{
			cars = new List<Vehicle>();

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
				Console.WriteLine("6. Udskriv alle elbiler");
				Console.WriteLine("7. Udskriv alle motorcykler");
				int input = Convert.ToInt32(Console.ReadLine());

				DifferentOptions(input);
				Console.ReadKey();
				Console.Clear();
			}

		}
		public static void GenerateRandomCar(int amount)
		{
			VehicleDatabase carDatabase = new VehicleDatabase();
			Random random = new Random();

			// Generate 100 random cars
			for (int i = 0; i < amount; i++)
			{
				string model = carDatabase.models[random.Next(0, 5)];
				string brand = carDatabase.brands[random.Next(0, 5)];
				int publishedYear = carDatabase.publishedYears[random.Next(0, 5)];
				string colour = carDatabase.colours[random.Next(0, 5)];
				double horsepower = carDatabase.horsePower[random.Next(0, 5)];
				int cylinders = carDatabase.cylinders[random.Next(carDatabase.cylinders.Count)];
				double price = random.Next(1000, 10000);

				if (carDatabase.motorcycleBrands.Contains(brand))
				{
					string modelForMotorcycle = carDatabase.models[random.Next(0, 5)];
					bool hasSidecar = random.Next(0, 2) == 1;
					cars.Add(new Motorcycle(modelForMotorcycle, brand, publishedYear, colour, horsepower, price, hasSidecar));
				}
				else if(brand == "Tesla")
				{
					cars.Add(new Elcar(model, brand, publishedYear, colour, horsepower, cylinders, price));
				}
				else
				{
					cars.Add(new Car(model, brand, publishedYear, colour, horsepower, cylinders, price));
				}
					

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
				case 6:
					PrintElectricalCars();
					break;
				case 7:
					PrintMotorcycles();
					break;

			}
		}

		//Cylinders??
		//Prints all cars with the same brand as the first car
		public static void PrintAllCarsWithSameBrandAsFirstCar()
		{
			Vehicle targetCar = cars[0];
			foreach (Vehicle car in cars)
			{
				if (car.Brand == targetCar.Brand)
				{
					
					Console.WriteLine($"Model: {car.Model}\nBrand: {car.Brand}\nYear published: {car.PublishedYear}\nColour: {car.Colour}\nHorsepower: {car.Horsepower}\n Price: {car.Price}");
					Console.WriteLine("-----------------");
				}
			}
		}

		//Prints the amount of cars with the same brand as the first car
		public static void PrintAmountOfSameBrand()
		{
			int totalAmount = 0;
			Vehicle targetCar = cars[0];
			foreach (Vehicle car in cars)
			{
				if (car.Brand == targetCar.Brand)
				{
					totalAmount++;
				}
			}
			Console.WriteLine($"Total amount of cars with the brand: {targetCar.Brand}: {totalAmount}");
		}

		//Prints all cars with more than 200 horsepower
		public static void PrintAllCarsWithMoreThan200HorsePower()
		{
			//ICar
			foreach (Vehicle car in cars)
			{
				if(car.Horsepower >= 200)
				{
					Console.WriteLine($"Model: {car.Model}\nBrand: {car.Brand}\nYear published: {car.PublishedYear}\nColour: {car.Colour}\nHorsepower: {car.Horsepower}\n Price: {car.Price}");
					Console.WriteLine("-----------------");
				}
			}
		}

		//Prints all cars with the colour red
		public static void PrintAllCarsWithSameColour()
		{
			//ICar
			foreach(Vehicle car in cars)
			{
				if(car.Colour == "Red")
				{
					Console.WriteLine($"Model: {car.Model}\nBrand: {car.Brand}\nYear published: {car.PublishedYear}\nColour: {car.Colour}\nHorsepower: {car.Horsepower}\n Price: {car.Price}");
					Console.WriteLine("-----------------");
				}
			}
		}

		//Prints all cars published between 1980 and 1990
		public static void PrintAllCarsPublished()
		{
			foreach(Vehicle car in cars)
			{
				if(car.PublishedYear >= 1980 && car.PublishedYear <= 1990)
				{
					Console.WriteLine($"Model: {car.Model}\nBrand: {car.Brand}\nYear published: {car.PublishedYear}\nColour: {car.Colour}\nHorsepower: {car.Horsepower}\n Price: {car.Price}");
					Console.WriteLine("-----------------");
				}
			}
		}

		//Prints all electrical cars
		public static void PrintElectricalCars()
		{
			foreach(Vehicle car in cars)
			{
				//GetType() or is?
				if(car.GetType() == typeof(Elcar))
				{
					Console.WriteLine($"Model: {car.Model}\nBrand: {car.Brand}\nYear published: {car.PublishedYear}\nColour: {car.Colour}\nHorsepower: {car.Horsepower}\n Price: {car.Price}");
					Console.WriteLine("-----------------");
				}
			}
		}

		//Prints all motorcycles
		public static void PrintMotorcycles()
		{
			foreach (Vehicle motorcycle in cars)
			{
				if (motorcycle is Motorcycle)
				{
					Console.WriteLine($"Model: {motorcycle.Model}\nBrand: {motorcycle.Brand}\nYear published: {motorcycle.PublishedYear}\nColour: {motorcycle.Colour}\nHorsepower: {motorcycle.Horsepower}\n Price: {motorcycle.Price}");
					Console.WriteLine("-----------------");
				}
			}
		}
	}
}
