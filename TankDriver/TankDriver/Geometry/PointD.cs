using Microsoft.Xna.Framework;

namespace TankDriver.Geometry
{
	/// <summary>
	/// Point with double coordinates.
	/// </summary>
	internal struct PointD
	{
		public readonly double X;
		public readonly double Y;

		public PointD(double x, double y)
		{
			X = x;
			Y = y;
		}

		public PointD MovedByVector(VectorD vector)
		{
			return new PointD(X + vector.X, Y + vector.Y);
		}

		public static explicit operator Vector2(PointD point)
		{
			return new Vector2((float) point.X, (float) point.Y);
		}
	}
}
