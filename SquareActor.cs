using EasyMonoGame;

using Microsoft.Xna.Framework;

using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace EasyStart

{

    class SquareActor : Actor

    {

        public override bool Intersects(Actor otherActor)

        {

            float thisLeftX = this.Position.X - this.Width / 2;

            float thisRightX = this.Position.X + this.Width / 2;

            float thisUpY = this.Position.Y - this.Height / 2;

            float thisDownY = this.Position.Y + this.Height / 2;

            float otherLeftX = otherActor.Position.X - otherActor.Width / 2;

            float otherRightX = otherActor.Position.X + otherActor.Width / 2;

            float otherUpY = otherActor.Position.Y - otherActor.Height / 2;

            float otherDownY = otherActor.Position.Y + otherActor.Height / 2;

            // this player corner inside otherActor box?

            // upper left corner inside otherActor box

            if (otherLeftX < thisLeftX && thisLeftX < otherRightX &&

                otherUpY < thisUpY && thisUpY < otherDownY)

            {

                return true;

            }

            // upper right corner inside otherActor box

            if (otherLeftX < thisRightX && thisRightX < otherRightX &&

                otherUpY < thisUpY && thisUpY < otherDownY)

            {

                return true;

            }

            // lower left corner is inside of otherActor's box

            if (otherLeftX < thisLeftX && thisLeftX < otherRightX &&

                otherUpY < thisDownY && thisDownY < otherDownY)

            {

                return true;

            }

            // lower right conrner is inside of otherActor's box

            if (otherLeftX < thisRightX && thisRightX < otherRightX &&

                otherUpY < thisDownY && thisDownY < otherDownY)

            {

                return true;

            }

            return false;

        }

    }

}

