using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    interface ICar
    {
		//Encapuslation?
		double Price { get; }
		string Model { get;}

		string Brand { get;}

		int PublishedYear { get; }

		string Colour { get;}

		double Horsepower { get; }	

		int Cylinders { get; }
	}
}
