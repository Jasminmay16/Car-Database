using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
	class Vehicle
	{
		private double price;
		public double Price { get { return price; } }
		private string model;
		public string Model { get { return model; } }
		private string brand;
		public string Brand { get { return brand; } }
		private int publishedYear;
		public int PublishedYear { get { return publishedYear; } }
		private string colour;
		public string Colour { get { return colour; } }
		private double horsePower;
		public double Horsepower { get { return horsePower; } }

		public Vehicle(string model, string brand, int publishedyear, string colour, double horsepower, double price)
		{
			this.model = model;
			this.brand = brand;
			this.publishedYear = publishedyear;
			this.colour = colour;
			this.horsePower = horsepower;
			this.price = price;
		}
		//private int cylinders;
		//public int Cylinders { get { return cylinders; } }
	}

	class Car : Vehicle
	{
		private int cylinders;
		public int Cylinders { get { return cylinders; } }
		public Car(string model, string brand, int publishedyear, string colour, double horsepower, int cylinders, double price) : base(model, brand, publishedyear, colour, horsepower, price)
		{
			this.cylinders = cylinders;
		}
	}

	class Elcar : Vehicle
	{
		private int cylinders;
		public int Cylinders { get { return cylinders; } }
		public Elcar(string model, string brand, int publishedyear, string colour, double horsepower, int cylinders, double price) : base(model, brand, publishedyear, colour, horsepower, price)
		{
			this.cylinders = cylinders;
		}
	}

	class Motorcycle : Vehicle
	{
		private bool hasSidecar;
		public bool HasSidecar { get { return hasSidecar; } }
		public Motorcycle(string model, string brand, int publishedyear, string colour, double horsepower, double price, bool hasSidecar) : base(model, brand, publishedyear, colour, horsepower, price)
		{
			this.hasSidecar = hasSidecar;
		}
	}


	//   class Car : ICar
	//{
	//	private double price;
	//	public double Price { get { return price; } }

	//	private string model;
	//	public string Model { get { return model; } }

	//	private string brand;
	//	public string Brand { get { return brand; } }

	//	private int publishedYear;
	//	public int PublishedYear { get { return publishedYear; } }

	//	private string colour;
	//	public string Colour { get { return colour; } }

	//	private double horsePower;
	//	public double Horsepower { get { return horsePower; } }

	//	private int cylinders;
	//	public int Cylinders { get { return cylinders; } }


	//	public Car(string model, string brand, int publishedyear, string colour, double horsepower, int cylinders, double price)
	//	{
	//		this.model = model;
	//		this.brand = brand;
	//		this.publishedYear = publishedyear;
	//		this.colour = colour;
	//		this.horsePower = horsepower;
	//		this.cylinders = cylinders;
	//		this.price = price;
	//	}
	//}

	//class Elcar : ICar
	//{
	//	private double price;
	//	public double Price { get { return price; } }

	//	private string model;
	//	public string Model { get { return model; } }

	//	private string brand;
	//	public string Brand { get { return brand; } }

	//	private int publishedYear;
	//	public int PublishedYear { get { return publishedYear; } }

	//	private string colour;
	//	public string Colour { get { return colour; } }

	//	private double horsePower;
	//	public double Horsepower { get { return horsePower; } }

	//	private int cylinders;
	//	public int Cylinders { get { return cylinders; } }


	//	public Elcar(string model, string brand, int publishedyear, string colour, double horsepower, int cylinders, double price)
	//	{
	//		this.model = model;
	//		this.brand = brand;
	//		this.publishedYear = publishedyear;
	//		this.colour = colour;
	//		this.horsePower = horsepower;
	//		this.cylinders = cylinders;
	//		this.price = price;
	//	}
	//}
}
