﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace MonoLibrary
{
    public abstract class GameObject : IGame
    {

        protected Texture2D texMain;
        public Rectangle position;
        protected int offset = 16;
        protected Rectangle source;

        public GameObject(Texture2D texMain, Rectangle pos)
        {
            this.texMain = texMain;
            this.position = pos;
        }

        public abstract void Draw(SpriteBatch spriteBatch);


        public abstract void Update(GameTime gameTime);

    }
}
