using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyMonoGame;

namespace EasyStart
{
    internal class MyWorld : World
    {
        public MyWorld() : base(1200, 900)
        {
            // Tile background with the file "bluerock" in the Content folder.
            BackgroundTileName = "green";
            
            ReadFile();
            
        }
        private void ReadFile()
        {
            FileReader fileReader = new FileReader();
            String level = fileReader.ReadFile();
            int x = 25;
            int y = 25;
            foreach (char token in level)
            {
                if (token == 'x')
                {
                    Add(new Planka(), "nyplanka", x, y);
                }
                else if (token == 'b')
                {
                    Add(new Ball(), "litenboll", x, y);
                }
                else if (token == 'h')
                {
                    Add(new Hole(), "hole", x, y);
                }

                if (token == '\n')
                {
                    x = 25;
                    y += 50;
                }
                else
                {
                    x += 50;
                }
            }
        }
    }
}
