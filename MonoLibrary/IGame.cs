using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MonoLibrary
{
    public interface IGame
    {
        void Update(GameTime gameTime);
        void Draw(SpriteBatch spriteBatch);
    }
}