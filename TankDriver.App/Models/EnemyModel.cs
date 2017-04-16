using System;

namespace TankDriver.Models
{
    // TODO(#6): Implement TankDriver.Models.EnemyModel
    internal class EnemyModel: IModel
    {
        public EnemyModel()
        {
        }

        #region IModel implementation

        public TankDriver.Logic.IUnit GetUnit()
        {
            throw new NotImplementedException();
        }

        public void LoadTextures(TextureStorage textureStorage)
        {
            throw new NotImplementedException();
        }

        public void Render(Microsoft.Xna.Framework.Graphics.SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}

