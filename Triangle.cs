using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
	class Triangle : Figure
	{
		private float mediana;
		private float radius;

		public Triangle(float height, float width, float mediana, float Side1, float Side2, float Side3, float Side4) : base(height, width, Side1, Side2, Side3, Side4)
		{
			this.mediana = mediana;
		}
		public void Mediana()
		{
			Console.WriteLine("медиана");
		}
		internal override void square()
		{
			float c = Side1;
			float h = height;
			float S = c * h / 2;
			Console.WriteLine("Плошадь треугольника: " + S);
		}
		internal override void Perimeter()
		{
			float a = Side1;
			float b = Side2;
			float c = Side3;
			float d = Side4;
			float  P = a + b + c + d;
			Console.WriteLine("Периметр треугольника: " + P);
		}

	}
}
