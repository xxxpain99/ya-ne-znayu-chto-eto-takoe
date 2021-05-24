using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
	class Circle : Figure
	{
		private float R;
		private float square;

		public Circle(float height, float width, float R) : base(height, width)
		{
			this.R = R;
		}
		public void Radius()
		{
			Console.WriteLine("радиус");
		}
	
		public override int Square(int s)
		{
			int r = 4;
			double a = 3.14;


			if (поле == названиеФигуры[1])
			{
				s = a * r * 2;
			}
			return s;
			// S = 3,14 * R*2 - круг 
		}
	}
		
		
	}
}
