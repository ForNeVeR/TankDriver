using System;
using Microsoft.Xna.Framework;
using TankDriver.Geometry;
using TankDriver.Models;

namespace TankDriver.Logic
{
	/// <summary>
	/// Class representing tank in game logic terms.
	/// </summary>
	internal class Tank : IUnit
	{
		/// <summary>
		/// Acceleration, px / s ^ 2.
		/// </summary>
		public const double AccelerationConstant = 5.0;

		/// <summary>
		/// Body turning speed, rad / s.
		/// </summary>
		public const double TurnSpeedConstant = 0.5;

		/// <summary>
		/// Turret turning speed, rad / s.
		/// </summary>
		public const double TurretTurnSpeedConstant = 1.0;

		/// <summary>
		/// Current target point.
		/// </summary>
		private PointD _target;

		/// <summary>
		/// The turret cooldown.
		/// </summary>
		private double _turretCooldown;

		/// <summary>
		/// Current tank position, px.
		/// </summary>
		public PointD Position { get; private set; }

		/// <summary>
		/// Tank body heading, rad.
		/// </summary>
		public double Heading { get; private set; }

		/// <summary>
		/// Tank turret heading, rad.
		/// </summary>
		public double TurretHeading { get; private set; }

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
		/// <param name="heading">Heading of tank, rad.</param>
		public Tank(double x, double y, double heading)
		{
			Position = new PointD(x, y);
			Heading = TurretHeading = heading;

			_model = new TankModel(this);
			_turretCooldown = 0.0;
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
			_turretCooldown = Math.Max (0.0, _turretCooldown - time);
			Position = Position.MovedByVector(VectorD.Polar(Speed*time, Heading));
			Speed += Acceleration*time;

			double turn = TurnSpeed*time;
			Heading += turn;
			TurretHeading += turn;

			// Calculate turret heading:
			double targetTurretHeading = VectorD.Cartesian(_target.X - Position.X, _target.Y - Position.Y).Heading;
			double turretHeadingDelta = targetTurretHeading - TurretHeading;
			double turretHeadingChange = Math.Sign(turretHeadingDelta)*
			                             Math.Min(Math.Abs(turretHeadingDelta), TurretTurnSpeedConstant*time);
			TurretHeading += turretHeadingChange;
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

		public void ShootInto(BulletSpace bulletSpace)
		{
			if (_turretCooldown <= 0.0) {
				bulletSpace.AddBullet (Position.X, Position.Y, TurretHeading);
				_turretCooldown = 1.0;
			}
		}

		/// <summary>
		/// Sets target for turret.
		/// </summary>
		/// <param name="x">X coordinate of target.</param>
		/// <param name="y">Y coordinate of target.</param>
		public void SetTarget(double x, double y)
		{
			_target = new PointD(x, y);
		}
	}
}
