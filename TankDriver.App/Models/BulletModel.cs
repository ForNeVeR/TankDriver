using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using TankDriver.Logic;

namespace TankDriver.Models
{
	/// <summary>
	/// Graphical model of a bullet.
	/// </summary>
	internal class BulletModel: IModel
	{
		/// <summary>
		/// Bullet associated with this bullet.
		/// </summary>
		private readonly Bullet _bullet;

		/// <summary>
		/// Texture for this bullet.
		/// </summary>
		private TextureStorage _textureStorage;

		/// <summary>
		/// Model constructor.
		/// </summary>
		/// <param name="bullet">Bullet for this model</param>
		public BulletModel (Bullet bullet)
		{
			_bullet = bullet;
		}

		/// <summary>
		/// Returns unit associated with this model.
		/// </summary>
		/// <returns>Unit.</returns>
		public IUnit GetUnit()
		{
			return _bullet;
		}

		public void LoadTextures(TextureStorage textureStorage)
		{
			_textureStorage = textureStorage;
		}

		/// <summary>
		/// Renders model.
		/// </summary>
		/// <param name="spriteBatch">Object for performing drawing actions.</param>
		public void Render(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw (_textureStorage.BulletTexture, (Vector2) _bullet.Position);
		}
	}
}

