using FinderQuest.Class;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinderQuest.WalkArea
{
    public class WalkAreasLibrary
    {
        public static WalkAreas CreateArea(int areaNumber)
        {
            WalkAreas createWalkArea = null;
            switch (areaNumber)
            {
                case 1:
                    createWalkArea = new WalkAreas("Floor 1", Properties.Resources.floor1, 1);
                    createWalkArea.AddPerson(1, "Clone 1", Properties.Resources.npc_back, new Size(60, 90), new Point(150, 350), "hi");
                    createWalkArea.AddPerson(2, "Clone 2", Properties.Resources.npc_front, new Size(60, 90), new Point(420, 350), "hi");
                    createWalkArea.AddPerson(3, "Clone 3", Properties.Resources.npc_back, new Size(60, 90), new Point(600, 360), "hi");
                    break;
                case 2:
                    createWalkArea = new WalkAreas("Floor 2", Properties.Resources.floor2, 2);
                    createWalkArea.AddPerson(4, "Clone 4", Properties.Resources.npc_back, new Size(60, 90), new Point(100, 300), "hi");
                    createWalkArea.AddPerson(5, "Clone 5", Properties.Resources.npc_front, new Size(60, 90), new Point(450, 350), "hi");
                    break;
            }
            return createWalkArea;
        }
    }
}
