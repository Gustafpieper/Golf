using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;
using static System.Formats.Asn1.AsnWriter;

namespace EasyStart
{
    internal class Hole : Actor
    {
        public override void Act()
        {
            if (IsTouching(typeof(Ball)))
            {
                World.ShowText("YAY!!", 100, 100);
            }
        }
    }
}
