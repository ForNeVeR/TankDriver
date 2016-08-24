using TankDriver.Logic;
using Xunit;

namespace TankDriver.Tests.Models
{
    public class TankTests
    {
        private readonly Tank _tank = new Tank(0.0, 0.0, 0.0);

        [Fact]
        public void TankShouldAccelerate()
        {
            Assert.Equal(0.0, _tank.Acceleration, Configuration.GeometryPrecision);
            _tank.Accelerate();
            Assert.Equal(Tank.AccelerationConstant, _tank.Acceleration, Configuration.GeometryPrecision);
        }
    }
}
