using TankDriver.Logic;
using Microsoft.Xna.Framework;
using Xunit;

namespace TankDriver.Tests.Logic
{
    public class BulletSpaceTests
    {
        private readonly Rectangle BulletSpaceBounds = new Rectangle(0, 0, 100, 100);

        [Fact]
        public void BulletOutOfBound()
        {
            BulletSpace bulletSpace = new BulletSpace(BulletSpaceBounds);
            bulletSpace.AddBullet(50.0, 50.0, 0.0);
            bulletSpace.AddBullet(200.0, 200.0, 0.0);
            Assert.Equal(2, bulletSpace.Bullets.Count);
            bulletSpace.Update(System.TimeSpan.FromMilliseconds(10.0));
            Assert.Equal(1, bulletSpace.Bullets.Count);
        }

        [Fact]
        public void ShootBulletIntoSpace()
        {
            BulletSpace bulletSpace = new BulletSpace(BulletSpaceBounds);
            Tank tank = new Tank(20.0, 20.0, 0.0);
            tank.ShootInto(bulletSpace);
            Assert.Equal(1, bulletSpace.Bullets.Count);
            Assert.Equal(tank.TurretHeading, bulletSpace.Bullets[0].Heading, Configuration.GeometryPrecision);
            Assert.Equal(tank.Position.X, bulletSpace.Bullets[0].Position.X, Configuration.GeometryPrecision);
            Assert.Equal(tank.Position.Y, bulletSpace.Bullets[0].Position.Y, Configuration.GeometryPrecision);
        }
    }
}

