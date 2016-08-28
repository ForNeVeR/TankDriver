using System;
using TankDriver.Models;
using TankDriver.Geometry;

namespace TankDriver.Logic
{
	internal class Bullet: IUnit
	{
		private readonly BulletModel _model;

		public PointD Position { get; private set; }

		public Bullet (double x, double y)
		{
			Position = new PointD (x, y);
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
			
		}
	}
}

