using System;

namespace ConsoleApp8
{
	class Program
	{
		static void Main(string[] args)
		{   Circle figure  = new Circle(23, 45, 4);
			figure.Radius();

			Triangle figure1 = new Triangle(45, 23, 13);
			figure1.Mediana();

			Quadrate figure3 = new Quadrate(12, 23, 12);
			figure3.Diagonal();

		}
	}
}
