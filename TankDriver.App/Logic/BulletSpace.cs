using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using TankDriver.Models;

namespace TankDriver.Logic
{
	internal class BulletSpace: IUnit
	{
		public List<Bullet> Bullets { get; private set; }
		private BulletSpaceModel _bulletSpaceModel;
		private Rectangle _bounds;

		public BulletSpace (Rectangle bounds)
		{
			Bullets = new List<Bullet> ();
			_bulletSpaceModel = new BulletSpaceModel (this);
			_bounds = bounds;
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
				
			Bullets.RemoveAll (delegate(Bullet bullet) {
				return !_bounds.Contains((Vector2) bullet.Position);
			});

			Console.WriteLine (Bullets.Count);
		}

		public IModel GetModel()
		{
			return _bulletSpaceModel;
		}
	}
}

