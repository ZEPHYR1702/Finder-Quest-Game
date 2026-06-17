using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinderQuest.Class
{
    public abstract class Areas
    {
        private string name;
        private Image background;

        public Areas(string name, Image background)
        {
            this.Name = name;
            this.Background = background;
        }

        public string Name 
        { 
            get => name; 
            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    throw new Exception("Level name can not be empty");
                }
            }
        }
        public Image Background { get => background; set => background = value; }

        public virtual string DisplayData()
        {
            return this.Name;
        }

        public void DisplayPicture(Control container)
        {
            container.BackgroundImage = this.Background;
        }
    }
}
