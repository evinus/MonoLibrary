using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoLibrary
{
    public class MovingObject : GameObject
    {
        protected Rectangle drawPos;
        protected float rotation = 0;
        protected int currentFrame = 0;
        protected float timeSinceLastFrame;
        protected int numberOfFrames;
        protected float timeBetweenFrames = 0.1f;
        

        
        

        public MovingObject(Texture2D texMain, Rectangle pos) : base(texMain, pos)
        {
            drawPos = new Rectangle(0, 0, pos.Width, pos.Height);
           
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(GameTime gameTime, int offset)
        {
            drawPos.X = position.X + offset;
            drawPos.Y = position.Y + offset;
        }

        public override void Update(GameTime gameTime)
        {
            throw new NotImplementedException();
        }

        protected virtual void Animate(GameTime gameTime)
        {
            timeSinceLastFrame += (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (timeSinceLastFrame >= timeBetweenFrames)
            {
                timeSinceLastFrame = 0;
                currentFrame++;
                if (currentFrame >= numberOfFrames)
                {
                    currentFrame = 0;
                }
            }
        }
    }
}
