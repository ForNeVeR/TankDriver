using System;
using Microsoft.Xna.Framework;
using TankDriver.Geometry;
using TankDriver.Models;

namespace TankDriver.Logic
{
	/// <summary>
	/// Class representing tank in game logic terms.
	/// </summary>
	class Tank : IUnit
	{
		/// <summary>
		/// Acceleration, px / s ^ 2.
		/// </summary>
		public const double AccelerationConstant = 5.0;

		/// <summary>
		/// Body turning acceleration, rad / s ^ 2.
		/// </summary>
		public const double TurnSpeedConstant = 0.5;
		
		/// <summary>
		/// Current tank position, px.
		/// </summary>
		public PointD Position { get; private set; }

		/// <summary>
		/// Tank body heading, radians.
		/// </summary>
		public double Heading { get; private set; }

		/// <summary>
		/// Tank model.
		/// </summary>
		private readonly TankModel _model;

		/// <summary>
		/// Current tank acceleration, px / s ^ 2.
		/// </summary>
		public double Acceleration { get; private set; }

		/// <summary>
		/// Current tank speed, px / s.
		/// </summary>
		public double Speed { get; private set; }

		/// <summary>
		/// Current turn speed, rad / s.
		/// </summary>
		public double TurnSpeed { get; private set; }

		/// <summary>
		/// Tank constructor.
		/// </summary>
		/// <param name="x">X coordinate of tank.</param>
		/// <param name="y">Y coordinate of tank.</param>
		public Tank(double x, double y, double heading)
		{
			Position = new PointD(x, y);
			Heading = heading;

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

		public void UpdatePosition(TimeSpan timeDelta)
		{
			double time = timeDelta.TotalSeconds;
			Position = Position.MovedByVector(VectorD.Polar(Speed*time, Heading));
			Speed += Acceleration*time;
			Heading += TurnSpeed*time;
		}

		public void Accelerate()
		{
			Acceleration = AccelerationConstant;
		}

		public void Decelerate()
		{
			Acceleration = 0.0;
		}

		public void TurnLeft()
		{
			TurnSpeed = TurnSpeedConstant;
		}

		public void TurnRight()
		{
			TurnSpeed = -TurnSpeedConstant;
		}

		public void StopTurning()
		{
			TurnSpeed = 0.0;
		}
	}
}
