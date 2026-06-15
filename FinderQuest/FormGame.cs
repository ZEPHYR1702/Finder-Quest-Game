using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinderQuest.Class;

namespace FinderQuest
{
    public partial class FormGame : Form
    {
        Time time;
        Player player;
        public FormGame()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press arrow key to move the player. \n\nPress Enter to talk with the person. " + "\n\nPress y key to answer the question. \n\nPress Esc to exit the talk area.", "How to Play");
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            panelGame.Visible = false;
            labelTime.Visible = false;

            playPauseToolStripMenuItem.Enabled = false;
            timerTime.Interval = 1000;

            this.KeyPreview = true;
            this.DoubleBuffered = true;

            panelTalkArea.Visible = false;
        }

        private void TimerTime_Tick(object sender, EventArgs e)
        {
            time.AddWithSecond(-1);

            labelTime.Text = time.DisplayData();

            if (time.Hour == 0 && time.Minute == 0 && time.Second == 0)
            {
                timerTime.Stop();
                MessageBox.Show("Timer is up");
            }
        }

        private void StartGame()
        {
            panelGame.Visible = true;
            labelTime.Visible = true;
            playPauseToolStripMenuItem.Enabled = true;
            startNewGameToolStripMenuItem.Enabled = false;

            playPauseToolStripMenuItem.Text = "Pause Game";

            time = new Time(0, 1, 0);
            timerTime.Start();

            player = new Player("Goof Juice", Properties.Resources.player_right, new Size(50, 50), new Point(10, 370), time);

            labelPlayer.Text = player.DisplayData();
            player.DisplayPicture(this);
        }

        private void GameOver()
        {
            timerTime.Stop();

            panelGame.Visible = false;
            labelTime.Visible = false;
            startNewGameToolStripMenuItem.Enabled = true;
        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            int distance = 30;

            if(e.KeyCode == Keys.Right)
            {
                player.MoveRight(distance);
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (player.Picture.Location.X >= 10)
                {
                    player.MoveLeft(distance);
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {

            }
            else if (e.KeyCode == Keys.Escape)
            {

            }

            else if (e.KeyCode == Keys.Y)
            {
                FormQuestion form = new FormQuestion();
                form.Owner = this;
                form.ShowDialog();
            }
            player.DisplayPicture(this);
        }

        private void StartNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartGame();
        }
    }
}
