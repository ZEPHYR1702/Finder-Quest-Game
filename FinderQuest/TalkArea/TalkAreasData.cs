using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinderQuest.TalkArea
{
    public class TalkAreasData
    {
        private string location;
        private Image resource;

        public string Location { get => location; set => location = value; }
        public Image Resource { get => resource; set => resource = value; }

        public TalkAreasData(string location, Image resource)
        {
            this.Location = location;
            this.Resource = resource;
        }
    }
}