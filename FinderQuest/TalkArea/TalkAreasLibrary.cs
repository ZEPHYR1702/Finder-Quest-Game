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
            {2, new TalkAreasData("Boss Showdown", Properties.Resources.talkarea_boss) },
            {3, new TalkAreasData("Boss Showdown", Properties.Resources.talkarea_boss) },
        };
    }
}
