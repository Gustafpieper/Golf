using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace EasyStart
{
    internal class Ball : Actor
    {
        private float time = 0;
        private float speed = 0;
        private bool hasPressedSpace = false;
        public override void Act()
        {
            time = time + 1;

            var mouseState = Mouse.GetState();
            TurnTowards(mouseState.X, mouseState.Y);
            Turn(180);

            if (Keyboard.GetState().IsKeyDown(Keys.Space) && !hasPressedSpace) {
                // kolla koordinater för boll och mus
                float deltaX = Math.Abs(X - mouseState.X);
                float deltaY = Math.Abs(Y - mouseState.Y);
                speed = (float)Math.Sqrt(deltaX * deltaX + deltaY * deltaY) / 20f;
                if (speed > 10)
                {
                    speed = 10;
                }

                hasPressedSpace = true;
            }
            speed -= 0.07f;
            if (speed < 0)
            {
                speed = 0;
                hasPressedSpace = false;
            }
            Move(speed);

            if (IsTouching(typeof(Planka))) 
                {
                speed = 0;
                }

            if (IsTouching(typeof(Hole))) 
            {
                speed = 0;
            }

        }
    


    }
}
