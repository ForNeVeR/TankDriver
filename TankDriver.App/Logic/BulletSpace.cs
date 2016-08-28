using System;
using System.Collections.Generic;
using TankDriver.Models;

namespace TankDriver.Logic
{
	internal class BulletSpace: IUnit
	{
		public List<Bullet> Bullets { get; private set; }
		private BulletSpaceModel _bulletSpaceModel;

		public BulletSpace ()
		{
			Bullets = new List<Bullet> ();
			_bulletSpaceModel = new BulletSpaceModel (this);
		}

		public void AddBullet (double x, double y, double heading)
		{
			var bullet = new Bullet (x, y, heading);
			_bulletSpaceModel.LoadBulletTextures (bullet.GetModel());
			Bullets.Add (bullet);
		}

		public void Update(TimeSpan timeDelta)
		{
			foreach (var bullet in Bullets) {
				bullet.UpdatePosition (timeDelta);
			}

			// TODO: check for bullets that are outside of the screen
		}

		public IModel GetModel()
		{
			return _bulletSpaceModel;
		}
	}
}

