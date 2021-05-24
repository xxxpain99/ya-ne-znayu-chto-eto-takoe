using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
	class Quadrate : Figure
	{
		private float diagonal;

		public Quadrate(float height, float width, float diagonal) : base(height, width)
		{
			this.diagonal = diagonal;

		}
		public void Diagonal()
		{
			Console.WriteLine("радиус");
		}

	}
}
