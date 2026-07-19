using FinderQuest.Class;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace FinderQuest.WalkArea
{
    internal class WalkAreaHitbox
    {
        public List<Rectangle> lstWallHitbox = new List<Rectangle>();

        private void AddWall (int x, int y, int width, int height)
        {
            Rectangle wall = new Rectangle(x, y, width, height);
            lstWallHitbox.Add(wall);
        }
        public List<Rectangle> HitBoxLibrary(int noArea)
        {
            if (noArea == 1)
            {
                if (lstWallHitbox != null)
                {
                    lstWallHitbox.Clear();
                }
                AddWall(0, 0, 850, 100);
                AddWall(173, 0, 25, 400);
                AddWall(150, 300, 50, 100);
                AddWall(0, 300, 100, 100);
                AddWall(200, 200, 150, 100);
                AddWall(850, 0, 30, 270);
                AddWall(625, 150, 250, 100);
                AddWall(625, 150, 25, 300);
                AddWall(350, 350, 300, 100);
                AddWall(85, 0, 150, 50);
                AddWall(150, 450, 25, 350);
                AddWall(0, 700, 175, 100);
                AddWall(50, 850, 375, 100);
                AddWall(400, 600, 25, 350);
                AddWall(400, 600, 200, 100);
                AddWall(568, 495, 300, 100);
                AddWall(568, 495, 25, 375);
                AddWall(850, 335, 25, 300);
                AddWall(850, 525, 150, 100);
                AddWall(568, 775, 125, 100);
                AddWall(750, 775, 250, 100);

            }
            else if (noArea == 2)
            {
                if (lstWallHitbox != null)
                {
                    lstWallHitbox.Clear();
                }
                AddWall(0, 75, 200, 100);
                AddWall(250, 0, 225, 50);
                AddWall(125, 250, 25, 350);
                AddWall(0, 600, 150, 100);
                AddWall(150, 550, 300, 100);
                AddWall(100, 800, 400, 100);
                AddWall(475, 700, 25, 200);
                AddWall(300, 350, 400, 100);
                AddWall(600, 350, 25, 450);
                AddWall(600, 700, 400, 100);
                AddWall(700, 525, 300, 100);
                AddWall(450, 0, 25, 300);
                AddWall(450, 200, 400, 100);
                AddWall(725, 50, 25, 250);
                AddWall(200, 900, 100, 100);

            }
            else if (noArea == 3)
            {
                if (lstWallHitbox != null)
                {
                    lstWallHitbox.Clear();
                }
                AddWall(100, 0, 25, 950);
                AddWall(100, 850, 850, 100);
                AddWall(190, 50, 360, 100);
                AddWall(550, 50, 25, 500);
                AddWall(550, 450, 450, 100);
                AddWall(650, 0, 25, 400);
                AddWall(650, 300, 150, 100);
                AddWall(850, 300, 150, 100);
                AddWall(300, 600, 75, 125);
                AddWall(715, 0, 300, 150);
            }

            return lstWallHitbox;
        }
    }
}
