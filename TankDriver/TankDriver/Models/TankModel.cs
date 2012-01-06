using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TankDriver.Logic;

namespace TankDriver.Models
{
	/// <summary>
	/// Graphical model of tank.
	/// </summary>
	class TankModel : IModel
	{
		/// <summary>
		/// Tank associated with this model.
		/// </summary>
		private readonly Tank _tank;

		/// <summary>
		/// Tank texture.
		/// </summary>
		private Texture2D _tankTexture;

		/// <summary>
		/// Model constructor.
		/// </summary>
		/// <param name="tank">Tank for this model.</param>
		public TankModel(Tank tank)
		{
			_tank = tank;
		}

		/// <summary>
		/// Returls tank unit associated with this model.
		/// </summary>
		/// <returns>Tank unit.</returns>
		public IUnit GetUnit()
		{
			return _tank;
		}

		/// <summary>
		/// Loads textures from storage.
		/// </summary>
		/// <param name="textureStorage">Texture storage.</param>
		public void LoadTextures(TextureStorage textureStorage)
		{
			_tankTexture = textureStorage.TankTexture;
		}

		/// <summary>
		/// Renders model.
		/// </summary>
		/// <param name="spriteBatch">Object for performing drawing actions.</param>
		public void Render(SpriteBatch spriteBatch)
		{
			spriteBatch.Draw(_tankTexture, new Vector2((float) _tank.Position.X, (float) _tank.Position.Y), Color.White);
		}
	}
}
