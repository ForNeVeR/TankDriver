using System;
using TankDriver.Models;
using TankDriver.Geometry;

namespace TankDriver.Logic
{
	internal class Bullet: IUnit
	{
		private const double BulletVelocity = 150.0;

		private readonly BulletModel _model;

		public PointD Position { get; private set; }
		public double Heading { get; }

		public Bullet (double x, double y, double heading)
		{
			Position = new PointD (x, y);
			Heading = heading;
			_model = new BulletModel (this);
		}

		/// <summary>
		/// Unit model.
		/// </summary>
		/// <returns>Reference ti this unit's model.</returns>
		public IModel GetModel()
		{
			return _model;
		}

		public void UpdatePosition(TimeSpan timeDelta) {
			double time = timeDelta.TotalSeconds;
			Position = Position.MovedByVector (VectorD.Polar(time * BulletVelocity, Heading));
		}
	}
}

