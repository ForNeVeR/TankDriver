using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace TankDriver
{
	/// <summary>
	/// Class for storeing loaded textures.
	/// </summary>
	internal class TextureStorage
	{
		/// <summary>
		/// Tank body texture.
		/// </summary>
		public Texture2D TankBodyTexture { get; private set; }

		/// <summary>
		/// Tank turret texture.
		/// </summary>
		public Texture2D TankTurretTexture { get; private set; }

		/// <summary>
		/// Texture storage constructor. Loads textures from <see cref="contentManager"/>.
		/// </summary>
		/// <param name="contentManager">Object from which textures will be loaded.</param>
		public TextureStorage(ContentManager contentManager)
		{
			TankBodyTexture = contentManager.Load<Texture2D>("Tank/Body");
			TankTurretTexture = contentManager.Load<Texture2D>("Tank/Turret");
		}
	}
}
