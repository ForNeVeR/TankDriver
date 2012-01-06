using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace TankDriver
{
	/// <summary>
	/// Class for storeing loaded textures.
	/// </summary>
	class TextureStorage
	{
		/// <summary>
		/// Tank texture.
		/// </summary>
		public Texture2D TankTexture { get; private set; }
		
		/// <summary>
		/// Texture storage constructor. Loads textures from <see cref="contentManager"/>.
		/// </summary>
		/// <param name="contentManager">Object from which textures will be loaded.</param>
		public TextureStorage(ContentManager contentManager)
		{
			TankTexture = contentManager.Load<Texture2D>("tank");
		}
	}
}
