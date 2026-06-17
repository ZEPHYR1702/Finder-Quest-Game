using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinderQuest.Class
{
    internal class WalkAreas : Areas
    {
        private int noArea;
        private List<Persons> listPersons;

        public WalkAreas(string name, Image background, int noArea) : base(name, background)
        {
            this.NoArea = noArea;
            this.ListPersons = new List<Persons>();
        }

        public int NoArea { get => noArea; set => noArea = value; }
        public List<Persons> ListPersons { get => listPersons; set => listPersons = value; }

        public override string DisplayData()
        {
            return "No. Area : " + this.NoArea + " - " + base.DisplayData();
        }

        public void AddPerson(int no, string name, Image image, Size size, Point location, string dialog)
        {
            Persons person = new Persons(no, name, image, size, location, dialog);
            this.ListPersons.Add(person);
        }

        public void DisplayPersons(Control container)
        {
            foreach(Persons person in this.ListPersons)
            {
                
            }
        }

        public void RemoveAllPerson()
        {
            foreach (Persons person in this.ListPersons)
            {

            }
            this.ListPersons.Clear();
        }

        public bool CheckTouchPerson(Player player, out Persons touchPerson)
        {
            foreach (Persons person in this.ListPersons)
            {
                if (player.Picture.Bounds.IntersectsWith(person.Picture.Bounds))
                {
                    touchPerson = person;
                    return true;
                }
            }
            touchPerson = null;
            return false;
        }

        public bool CheckFinishAllQuestions()
        {
            int numSolved = 0;
            foreach (Persons person in this.ListPersons)
            {
                if (person.SolvedStatus == true)
                {
                    numSolved++;
                }
            }
            if(numSolved == this.ListPersons.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
