using System;

namespace TankDriver.Geometry
{
	/// <summary>
	/// Class for 2D vector with double coordinates.
	/// </summary>
	internal struct VectorD
	{
		public double X { get; private set; }
		public double Y { get; private set; }

		public double Length
		{
			get { return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2)); }
		}

		public double Heading
		{
			get { return Math.Atan2(Y, X); }
		}

		public static VectorD Cartesian(double x, double y)
		{
			var result = new VectorD {X = x, Y = y};
			return result;
		}

		public static VectorD Polar(double length, double heading)
		{
			var result = new VectorD {X = length*Math.Sin(heading), Y = length*Math.Cos(heading)};
			return result;
		}
	}
}
