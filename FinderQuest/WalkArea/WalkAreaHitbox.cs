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
                AddWall(850, 50, 375, 100);
                AddWall(400, 600, 25, 350);
                AddWall(400, 600, 200, 100);
                AddWall(575, 495, 300, 100);
                AddWall(575, 495, 25, 375);
                AddWall(850, 335, 25, 300);
                AddWall(850, 525, 150, 100);
                AddWall(575, 775, 125, 100);
                AddWall(750, 775, 250, 100);

            }
            else if (noArea == 2)
            {
                if (lstWallHitbox != null)
                {
                    lstWallHitbox.Clear();
                }
                AddWall(0, 0, 0, 0);
                AddWall(0, 0, 0, 0);

            }
            else if (noArea == 3)
            {
                if (lstWallHitbox != null)
                {
                    lstWallHitbox.Clear();
                }
                AddWall(0, 0, 0, 0);
                AddWall(0, 0, 0, 0);
            }

            return lstWallHitbox;
        }
    }
}
