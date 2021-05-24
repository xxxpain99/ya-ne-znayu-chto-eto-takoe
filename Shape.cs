using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8
{
	class Shape
	{
		protected Point[] points;
		protected Point center;

		public Shape()
		{
			points=null;
		}
		public Shape(Point center, Point[] points)
		{
			this.center = center;
			this.points = points;
		}
		public Shape(Point[] points)
		{
			this.points = points;
		}
		
		public void Draw()
		{
			if (points == null) return;
		}
	}
}
