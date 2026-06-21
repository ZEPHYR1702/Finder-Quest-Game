using FinderQuest.States;
using FinderQuest.States.PlayerState;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinderQuest.Class
{
    public class Player
    {
        private string name;
        private PictureBox picture;
        private int score;
        private Time playTime;

        private StateMachine<Player> stateMachine;

        public Player(string name, Image image, Size size, Point location, Time playTime)
        {
            this.Name = name;
            this.Score = score;
            this.PlayTime = playTime;
            this.Picture = new PictureBox();
            this.Picture.Image = image;
            this.Picture.Size = size;
            this.Picture.Location = location;

            this.StateMachine = new StateMachine<Player>(this);
            this.StateMachine.Initialize(new IdleState());
        }

        public string Name
        {
            get => name;
            set
            {
                if (value == "")
                {
                    throw new Exception("Name cannot be empty");
                }
                else
                {
                    name = value;
                }
            }
        }
        public PictureBox Picture { get => picture; set => picture = value; }
        public int Score
        {
            get => score;
            private set
            {
                if (value >= 0)
                {
                    score = value;
                }
                else
                {
                    score = 0;
                }
            }
        }
        public Time PlayTime { get => playTime; set => playTime = value; }
        public StateMachine<Player> StateMachine { get => stateMachine; private set => stateMachine = value; }

        public string DisplayData()
        {
            string data =
                "Name : " + this.Name +
                "\nScore : " + this.Score +
                "\nPlaytime : " + this.PlayTime.DisplayData();
            return data;
        }

        public void DisplayPicture(Control container)
        {
            this.Picture.Parent = container;
            this.Picture.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Picture.BackColor = Color.Transparent;
            this.Picture.BringToFront();
        }

        public void AddScore(int score)
        {
            this.Score += score;
        }

        public void Tick()
        {
            this.StateMachine.Update();
        }
    }
}
