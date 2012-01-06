using System;

namespace TankDriver.Logic
{
	/// <summary>
	/// Class representing tank in game logic terms.
	/// </summary>
	class Tank : IUnit
	{
		/// <summary>
		/// Unit model.
		/// </summary>
		/// <returns>Reference ti this unit's model.</returns>
		public Models.IModel GetModel()
		{
			throw new NotImplementedException();
		}
	}
}
