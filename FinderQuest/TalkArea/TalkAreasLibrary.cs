using FinderQuest.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinderQuest.TalkArea
{
    public class TalkAreasLibrary
    {
        public static readonly Dictionary<int, TalkAreasData> listTalkArea = new Dictionary<int, TalkAreasData>
        {
            {1, new TalkAreasData("NPC Box", Properties.Resources.talkarea_npc) },
            {2, new TalkAreasData("NPC Box", Properties.Resources.talkarea_npc) },
            {3, new TalkAreasData("Boss Showdown", Properties.Resources.talkarea_boss) },
            {4, new TalkAreasData("Boss Showdown", Properties.Resources.talkarea_boss) },
            {5, new TalkAreasData("Boss Showdown", Properties.Resources.talkarea_boss) },
            {6, new TalkAreasData("Boss Showdown", Properties.Resources.talkarea_boss) },
            {7, new TalkAreasData("Boss Showdown", Properties.Resources.talkarea_boss) },
            {8, new TalkAreasData("Boss Showdown", Properties.Resources.talkarea_boss) },
            {9, new TalkAreasData("Boss Showdown", Properties.Resources.talkarea_boss) },
            {10, new TalkAreasData("Boss Showdown", Properties.Resources.talkarea_boss) },
            {11, new TalkAreasData("Boss Showdown", Properties.Resources.talkarea_boss) },
            {12, new TalkAreasData("Boss Showdown", Properties.Resources.talkarea_boss) },
            {13, new TalkAreasData("Boss Showdown", Properties.Resources.talkarea_boss) },
            {14, new TalkAreasData("Boss Showdown", Properties.Resources.talkarea_boss) }
        };
    }
}
