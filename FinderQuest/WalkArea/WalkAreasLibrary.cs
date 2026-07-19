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
                    createWalkArea.AddPerson(1, "Clone 1", Properties.Resources.npc_back, new Point(35, 90), "system has malfunctioned, please press 'y' to fix it.");
                    createWalkArea.AddPerson(2, "Clone 2", Properties.Resources.npc_right, new Point(790, 110), "system error occured, press 'y' to debug");
                    createWalkArea.AddPerson(3, "Clone 3", Properties.Resources.npc_back, new Point(900, 65), "error 101. press 'y' to continue");
                    createWalkArea.AddPerson(4, "Clone 4", Properties.Resources.npc_left, new Point(80, 650), "origin..faulty..press....'y'");
                    createWalkArea.AddPerson(5, "Clone 5", Properties.Resources.npc_front, new Point(180, 295), "system fail, press 'y' to conduct repair");
                    createWalkArea.AddPerson(6, "Clone 6", Properties.Resources.npc_front, new Point(420, 700), "model corrupted, press 'y' to update");
                    break;
                case 2:
                    createWalkArea = new WalkAreas("Floor 2", Properties.Resources.floor2, 2);
                    createWalkArea.AddPerson(7, "Clone 7", Properties.Resources.npc_front, new Point(5, 550), "conduct repair. press 'y'.. conduct repair. press 'y'.");
                    createWalkArea.AddPerson(8, "Clone 8", Properties.Resources.npc_back, new Point(880, 470), "test subject..bzzt....escaped...repair...'y'...please");
                    createWalkArea.AddPerson(9, "Clone 9", Properties.Resources.npc_front, new Point(880, 800), "system restore fail. press 'y' to reset");
                    createWalkArea.AddPerson(10, "Clone 10", Properties.Resources.npc_left, new Point(390, 750), "danger detected. command 'y' to activate emergency mode");
                    createWalkArea.AddPerson(11, "Clone 11", Properties.Resources.npc_left, new Point(530, 450), "body broken beyond repair. press 'y' to conduct emergency repair");
                    createWalkArea.AddPerson(12, "Clone 12", Properties.Resources.npc_right, new Point(410, 170), "clone 0012 report status: badly damaged. press 'y' to accept");
                    createWalkArea.AddPerson(13, "Clone 13", Properties.Resources.npc_back, new Point(135, 650), "repair deemed impossible. preserving core model. press 'y too initiate");
                    break;
                case 3:
                    createWalkArea = new WalkAreas("Floor 3", Properties.Resources.floor3, 3);
                    createWalkArea.AddPerson(14, "Test Subject", Properties.Resources.boss_enemy, new Point(715, 0), "Perish, human!");
                    break;
            }
            return createWalkArea;
        }
    }
}
