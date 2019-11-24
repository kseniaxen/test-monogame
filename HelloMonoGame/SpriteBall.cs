using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloMonoGame
{
    public class SpriteBall
    {
        private Texture2D texture2D;
        public Vector2 position;
        public float speed = 2f;

        public SpriteBall(Texture2D texture2D)
        {
            this.texture2D = texture2D;
        }

        public void Update()
        {
            if(Keyboard.GetState().IsKeyDown(Keys.Up))
            {
                position.Y -= speed;
            }
            else if(Keyboard.GetState().IsKeyDown(Keys.Down))
            {
                position.Y += speed;
            }
            else if(Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                position.X += speed;
            }
            else if(Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                position.X -= speed;
            }

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture2D,position,Color.Black);
        }
    }
}
