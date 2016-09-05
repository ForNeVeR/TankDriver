using TankDriver.Logic;
using Microsoft.Xna.Framework;
using Xunit;

namespace TankDriver.Tests.Logic
{
    public class BulletSpaceTests
    {
        [Fact]
        public void BulletOutOfBound()
        {
            BulletSpace bulletSpace = new BulletSpace(new Rectangle(0, 0, 100, 100));
            bulletSpace.AddBullet(50.0, 50.0, 0.0);
            bulletSpace.AddBullet(200.0, 200.0, 0.0);
            Assert.Equal(2, bulletSpace.Bullets.Count);
            bulletSpace.Update(System.TimeSpan.FromMilliseconds(10.0));
            Assert.Equal(1, bulletSpace.Bullets.Count);
        }
    }
}

