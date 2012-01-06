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
		private Texture _tankTexture;

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
		/// Renders model to device.
		/// </summary>
		/// <param name="graphicsDevice">A graphics device.</param>
		public void Render(GraphicsDevice graphicsDevice)
		{

		}
	}
}
