using System;
using TankDriver.Models;

namespace TankDriver.Logic
{
	internal class Bullet: IUnit
	{
		private readonly BulletModel _model;

		public Bullet (double x, double y)
		{
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
	}
}

