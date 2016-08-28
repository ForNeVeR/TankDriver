using System;
using Microsoft.Xna.Framework.Graphics;
using TankDriver.Logic;

namespace TankDriver.Models
{
	internal class BulletSpaceModel: IModel
	{
		private BulletSpace _bulletSpace;
		private TextureStorage _textureStorage;

		public BulletSpaceModel (BulletSpace bulletSpace)
		{
			_bulletSpace = bulletSpace;
		}

		public void LoadBulletTextures(IModel bulletModel)
		{
			bulletModel.LoadTextures (_textureStorage);
		}

		#region IModel implementation

		public IUnit GetUnit ()
		{
			return _bulletSpace;
		}

		public void LoadTextures (TextureStorage textureStorage)
		{
			_textureStorage = textureStorage;
		}

		public void Render (SpriteBatch spriteBatch)
		{
			foreach (var bullet in _bulletSpace.Bullets) {
				bullet.GetModel ().Render (spriteBatch);
			}
		}

		#endregion
	}
}

