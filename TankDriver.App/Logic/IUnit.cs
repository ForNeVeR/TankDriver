using TankDriver.Models;

namespace TankDriver.Logic
{
	/// <summary>
	/// Interface representing any game unit.
	/// </summary>
	interface IUnit
	{
		/// <summary>
		/// Unit model.
		/// </summary>
		/// <returns>Reference to this unit's model.</returns>
		IModel GetModel();
	}
}
