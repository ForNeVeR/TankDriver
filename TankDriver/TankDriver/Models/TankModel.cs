using System;
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
		/// Returls tank unit associated with this model.
		/// </summary>
		/// <returns>Tank unit.</returns>
		public IUnit GetUnit()
		{
			throw new NotImplementedException();
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
