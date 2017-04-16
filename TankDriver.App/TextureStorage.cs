﻿using Microsoft.Xna.Framework.Content;
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
		/// Bullet texture
		/// </summary>
		/// <value>The bullet texture.</value>
		public Texture2D BulletTexture { get; }

        /// <summary>
        /// Gets the enemy body texture.
        /// </summary>
        /// <value>The enemy body texture.</value>
        public Texture2D EnemyBodyTexture { get; }

		/// <summary>
		/// Texture storage constructor. Loads textures from <see cref="contentManager"/>.
		/// </summary>
		/// <param name="contentManager">Object from which textures will be loaded.</param>
		public TextureStorage(ContentManager contentManager)
		{
			TankBodyTexture = contentManager.Load<Texture2D>("Tank/Body");
			TankTurretTexture = contentManager.Load<Texture2D>("Tank/Turret");
			BulletTexture = contentManager.Load<Texture2D> ("Bullet/Bullet");
            EnemyBodyTexture = contentManager.Load<Texture2D>("Enemy/Body");
		}
	}
}
