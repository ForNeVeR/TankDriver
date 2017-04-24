using System;
using TankDriver.Models;
using TankDriver.Geometry;

namespace TankDriver.Logic
{
    // TODO(#6): implement TankDriver.Logic.Enemy class
    internal class Enemy: IUnit
    {
        public PointD position { get; private set; }

        public Enemy()
        {
        }

        #region IUnit implementation

        public TankDriver.Models.IModel GetModel()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

