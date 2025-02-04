﻿using System;
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
        private float speed = 10;
        public override void Act()
        {
            time = time + 1;

            var mouseState = Mouse.GetState();
            TurnTowards(mouseState.X, mouseState.Y);

            if (time > 100)
            {
                speed -= 0.07f;
                if (speed < 0)
                {
                    speed = 0;
                }
                Move(speed);
            }



        }
    


    }
}
