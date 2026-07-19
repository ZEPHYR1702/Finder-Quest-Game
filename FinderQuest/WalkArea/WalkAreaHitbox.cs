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
                AddWall(400, 400, 150, 100);

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
