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
            {3, new TalkAreasData("NPC Box", Properties.Resources.talkarea_npc) },
            {4, new TalkAreasData("NPC Box", Properties.Resources.talkarea_npc) },
            {5, new TalkAreasData("NPC Box", Properties.Resources.talkarea_npc) },
            {6, new TalkAreasData("NPC Box", Properties.Resources.talkarea_npc) },
            {7, new TalkAreasData("NPC Box", Properties.Resources.talkarea_npc) },
            {8, new TalkAreasData("NPC Box", Properties.Resources.talkarea_npc) },
            {9, new TalkAreasData("NPC Box", Properties.Resources.talkarea_npc) },
            {10, new TalkAreasData("NPC Box", Properties.Resources.talkarea_npc) },
            {11, new TalkAreasData("NPC Box", Properties.Resources.talkarea_npc) },
            {12, new TalkAreasData("NPC Box", Properties.Resources.talkarea_npc) },
            {13, new TalkAreasData("NPC Box", Properties.Resources.talkarea_npc) },
            {14, new TalkAreasData("Boss Showdown", Properties.Resources.talkarea_boss) }
        };
    }
}
