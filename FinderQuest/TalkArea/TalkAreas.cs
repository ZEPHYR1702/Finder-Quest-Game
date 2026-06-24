using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinderQuest.Class
{
    public class TalkAreas: Areas
    {
        private Persons person;

        public TalkAreas(string name, Image background, Persons person) : base(name, background)
        {
            this.Person = person;
        }

        public Persons Person { get => person; set => person = value; }

        public override string DisplayData()
        {
            return this.Person.Name + "'s Talk Area - " + base.DisplayData();
        }
    }
}
