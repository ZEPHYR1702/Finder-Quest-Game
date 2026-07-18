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
            {1, new TalkAreasData("Kamar", Properties.Resources.talkarea_npc) },
            {2, new TalkAreasData("Dapur", Properties.Resources.talkarea_npc) },
            {3, new TalkAreasData("Kamar Mandi", Properties.Resources.talkarea_npc) }
        };
    }
}
