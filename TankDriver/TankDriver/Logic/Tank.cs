using Microsoft.Xna.Framework;
using TankDriver.Models;

namespace TankDriver.Logic
{
	/// <summary>
	/// Class representing tank in game logic terms.
	/// </summary>
	class Tank : IUnit
	{
		/// <summary>
		/// Current tank position.
		/// </summary>
		private Point _position;

		/// <summary>
		/// Tank model.
		/// </summary>
		private readonly TankModel _model;

		/// <summary>
		/// Tank constructor.
		/// </summary>
		/// <param name="x">X coordinate of tank.</param>
		/// <param name="y">Y coordinate of tank.</param>
		public Tank(int x, int y)
		{
			_position = new Point(x, y);
			_model = new TankModel(this);
		}

		/// <summary>
		/// Unit model.
		/// </summary>
		/// <returns>Reference ti this unit's model.</returns>
		public IModel GetModel()
		{
			return _model;
		}
	}
}
