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
                    createWalkArea = new WalkAreas("Barn", Properties.Resources.walkArea1, 1);
                    createWalkArea.AddPerson(1, "Steven", Properties.Resources.person1, new Size(60, 90), new Point(150, 350), "hi");
                    createWalkArea.AddPerson(2, "Ferry", Properties.Resources.person2, new Size(60, 90), new Point(420, 350), "hi");
                    createWalkArea.AddPerson(3, "Adi", Properties.Resources.person3, new Size(60, 90), new Point(600, 360), "hi");
                    break;
                case 2:
                    createWalkArea = new WalkAreas("Field", Properties.Resources.walkArea2, 2);
                    createWalkArea.AddPerson(4, "Margaret", Properties.Resources.person4, new Size(60, 90), new Point(100, 300), "hi");
                    createWalkArea.AddPerson(5, "Nicho", Properties.Resources.person5, new Size(60, 90), new Point(450, 350), "hi");
                    break;
            }
            return createWalkArea;
        }
    }
}
