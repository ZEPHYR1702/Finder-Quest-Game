using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinderQuest.Class
{
    public class Persons
    {
        private int noPerson;
        private string name;
        private PictureBox picture;
        private string dialog;
        private Questions personQuestion;
        private bool solvedStatus;

        public Persons(int noPerson, string name, Image image, Size size, Point location, string dialog)
        {
            this.NoPerson = noPerson;
            this.Name = name;
            this.Picture = new PictureBox();
            this.Picture.Image = image;
            this.Picture.Size = size;
            this.Picture.Location = location;
            this.Dialog = dialog;
            this.SolvedStatus = false;
        }

        public int NoPerson
        {
            get => noPerson;
            set
            {
                if (value > 0)
                {
                    noPerson = value;
                }
                else
                {
                    throw new Exception("No Person can not be negative");
                }
            }
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
                    throw new Exception("Name can not be empty");
                }
            }
        }
        public PictureBox Picture { get => picture; set => picture = value; }
        public string Dialog { get => dialog; set => dialog = value; }
        public Questions Question { get => personQuestion; set => personQuestion = value; }
        public bool SolvedStatus { get => solvedStatus; set => solvedStatus = value; }

        public void AddQuestions(string text, string answer, int score)
        {
            this.Question = new Questions(text, answer, score);
        }

        public bool CheckAnswer(string answer, out int score)
        {
            if(answer.ToLower() == this.Question.Answer.ToLower())
            {
                this.SolvedStatus = true;
                score = this.Question.Score;
                return true;
            }
            else
            {
                score = 0;
                return false;
            }
        }

        public string DisplayData()
        {
            string data = "Hi... I'm " + this.Name + ".\n " + this.Dialog;
            return data;
        }

        public void DisplayDialog(Control container)
        {
            Label labelDialog = new Label();
            labelDialog.Parent = container;
            labelDialog.Text = this.DisplayData();
            labelDialog.Font = new Font("Arial", 18);
            labelDialog.TextAlign = ContentAlignment.TopCenter;
            labelDialog.Size = new Size(500, 90);

            labelDialog.Location = new Point(this.Picture.Location.X - 150, 10);
            labelDialog.BackColor = Color.LightYellow;
            labelDialog.BorderStyle = BorderStyle.FixedSingle;
            labelDialog.BringToFront();
        }

        public void DisplayPicture(Control container)
        {
            this.Picture.Parent = container;
            this.Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Picture.BackColor = Color.Transparent;
            this.Picture.BringToFront();
        }

        public void Person()
        {

        }
    }
}
