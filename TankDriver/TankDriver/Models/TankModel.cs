using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TankDriver.Geometry;
using TankDriver.Logic;

namespace TankDriver.Models
{
	/// <summary>
	/// Graphical model of tank.
	/// </summary>
	internal class TankModel : IModel
	{
		/// <summary>
		/// Tank associated with this model.
		/// </summary>
		private readonly Tank _tank;

		/// <summary>
		/// Tank texture.
		/// </summary>
		private TextureStorage _textureStorage;

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
			_textureStorage = textureStorage;
		}

		/// <summary>
		/// Renders model.
		/// </summary>
		/// <param name="spriteBatch">Object for performing drawing actions.</param>
		public void Render(SpriteBatch spriteBatch)
		{
			var bodyTexture = _textureStorage.TankBodyTexture;
			var turretTexture = _textureStorage.TankTurretTexture;
			var bodyTextureCenter = new Vector2(bodyTexture.Width/2, bodyTexture.Height/2);
			var turretTexturePivot = new Vector2(22, 20); // TODO: Get it from model config.

			var bodyPosition = _tank.Position;
			var turretPivotPosition = bodyPosition.MovedByVector(VectorD.Polar(-10.0, _tank.Heading));

			spriteBatch.Draw(bodyTexture, (Vector2) bodyPosition, null, Color.White,
			                 (float) _tank.Heading, bodyTextureCenter, 1f, SpriteEffects.None, 0f);
			spriteBatch.Draw(turretTexture, (Vector2) turretPivotPosition, null, Color.White,
			                 (float) _tank.TurretHeading, turretTexturePivot, 1f, SpriteEffects.None, 0f);
		}
	}
}
