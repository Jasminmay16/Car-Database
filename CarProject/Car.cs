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
		private int cylinders;
		public int Cylinders { get { return cylinders; } }


		public Car(string model, string brand, int publishedyear, string colour, double horsepower, int cylinders)
		{
			this.model = model;
			this.brand = brand;
			this.publishedYear = publishedyear;
			this.colour = colour;
			this.horsePower = horsepower;
			this.cylinders = cylinders;
		}
	}
}
