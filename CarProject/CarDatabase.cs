using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    class CarDatabase
    {
        public List<string> models = new List<string> { "Model A", "Model B", "Model C", "Model D", "Model E"};
        public List<string> brands = new List<string> { "Audi", "Honda", "Ford", "Toyota", "Fiat" };
		public List<int> publishedYears = new List<int> { 2000, 2018, 2015, 2019, 2002 };
        public List<string> colours = new List<string> { "Red", "White", "Blue", "Silver", "Black" };
        public List<double> horsePower = new List<double> { 150, 200, 175, 230, 100 };
    }
}
