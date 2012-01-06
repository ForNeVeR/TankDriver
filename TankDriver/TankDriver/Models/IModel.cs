using Microsoft.Xna.Framework.Graphics;
using TankDriver.Logic;

namespace TankDriver.Models
{
	/// <summary>
	/// Interface for graphical model.
	/// </summary>
	interface IModel
	{
		/// <summary>
		/// Returls unit associated with this model.
		/// </summary>
		/// <returns>Unit.</returns>
		IUnit GetUnit();

		/// <summary>
		/// Loads textures from storage.
		/// </summary>
		/// <param name="textureStorage">Texture storage.</param>
		void LoadTextures(TextureStorage textureStorage);

		/// <summary>
		/// Renders model to device.
		/// </summary>
		/// <param name="graphicsDevice">A graphics device.</param>
		void Render(GraphicsDevice graphicsDevice);
	}
}
