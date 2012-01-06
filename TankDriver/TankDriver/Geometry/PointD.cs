namespace TankDriver.Geometry
{
	/// <summary>
	/// Point with double coordinates.
	/// </summary>
	struct PointD
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
	}
}
