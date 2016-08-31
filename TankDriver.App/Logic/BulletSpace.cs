using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TankDriver.Models;

namespace TankDriver.Logic
{
	internal class BulletSpace
	{
		public List<Bullet> Bullets { get; }
		private Rectangle _bounds;
		private TextureStorage _textureStorage;

		public BulletSpace (Rectangle bounds)
		{
			Bullets = new List<Bullet> ();
			_bounds = bounds;
		}

		public void AddBullet (double x, double y, double heading)
		{
			var bullet = new Bullet (x, y, heading);
			bullet.GetModel ().LoadTextures (_textureStorage);
			Bullets.Add (bullet);
		}

		public void LoadTexture(TextureStorage textureStorage)
		{
			_textureStorage = textureStorage;
		}

		public void Render(SpriteBatch spriteBatch)
		{
			foreach (var bullet in Bullets) {
				bullet.GetModel ().Render (spriteBatch);
			}
		}

		public void Update(TimeSpan timeDelta)
		{
			foreach (var bullet in Bullets) {
				bullet.UpdatePosition (timeDelta);
			}
				
			Bullets.RemoveAll (delegate(Bullet bullet) {
				return !_bounds.Contains((Vector2) bullet.Position);
			});
		}
	}
}

