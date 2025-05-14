using System.Drawing;
using System.Reflection;

namespace CarProject
{
    internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Velkommen til bilbasen!\n");
			Console.WriteLine("Valgmuligheder:");
			Console.WriteLine("1. Udskriv alle biler som deler mærke med den første bil");
			Console.WriteLine("2. Udskriv alle biler som har over 200HK");
			Console.WriteLine("3. Udskriv alle biler som er røde");
			Console.WriteLine("4. Udskriv antallet af biler som har samme mærke som den første bil");
			Console.WriteLine("5. Udskriv alle biler som er mellem årgangen 1980 og 1999");
			Car car = new Car(); //I don't see the need for a constructor

		}
	}
}
