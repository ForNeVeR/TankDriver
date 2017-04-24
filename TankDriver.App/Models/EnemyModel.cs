using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using TankDriver.Logic;

namespace TankDriver.Models
{
    internal class EnemyModel: IModel
    {
        private TextureStorage _textureStorage;
        private readonly Enemy _enemy;

        public EnemyModel(Enemy enemy)
        {
            _enemy = enemy;
        }

        #region IModel implementation

        public IUnit GetUnit()
        {
            return _enemy;
        }

        public void LoadTextures(TextureStorage textureStorage)
        {
            _textureStorage = textureStorage;
        }

        public void Render(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(_textureStorage.BulletTexture, (Vector2)_enemy.position);
        }

        #endregion
    }
}

