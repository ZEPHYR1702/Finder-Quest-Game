using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinderQuest.Class;
using FinderQuest.States.PlayerState;
using FinderQuest.WalkArea;
using WMPLib;

namespace FinderQuest
{
    public partial class FormGame : Form
    {
        Time time;
        public Player player;
        

        //Areas
        public static bool enterTalkArea = false;
        int numOfWalkArea = 3;
        WalkAreas currentWalkArea = null;
        TalkAreas currentTalkArea = null;

        //Persons
        public Persons activePerson;
        Point activePersonLastLocation;

        //Audio
        WindowsMediaPlayer backSoundPlayer = new WindowsMediaPlayer();
        WindowsMediaPlayer otherSoundPlayer;

        bool paused = false;
        public FormGame()
        {
            InitializeComponent();
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

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Right)
            {
                player.StateMachine.TransitionTo(new MoveRightState());
                player.Tick();
                HandleAreaEdgeReached();
            }
            else if (e.KeyCode == Keys.Left)
            {
                player.StateMachine.TransitionTo(new MoveLeftState());
                player.Tick();
                HandleAreaEdgeReached();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (currentWalkArea.CheckTouchPerson(player, out Persons touchPerson) == true)
                {
                    enterTalkArea = true;
                    activePerson = touchPerson;
                    activePersonLastLocation = activePerson.Picture.Location;
                    EnterTalkArea();
                }
            }
            else if (e.KeyCode == Keys.Escape)
            {
                ExitTalkArea();
            }

            else if (e.KeyCode == Keys.Y && activePerson.SolvedStatus == false)
            {
                FormQuestion form = new FormQuestion();
                form.Owner = this;
                form.ShowDialog();
            }
            player.DisplayPicture(this);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press arrow key to move the player. \n\nPress Enter to talk with the person. " + "\n\nPress y key to answer the question. \n\nPress Esc to exit the talk area.", "How to Play");
        }

        private void StartNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartGame();
        }
        private void playPauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(playPauseToolStripMenuItem.Text == "Pause Game")
            {
                paused = true;
                timerTime.Stop();
                playPauseToolStripMenuItem.Text = "Play Game";
                backSoundPlayer.controls.pause();
            }
            else
            {
                paused = false;
                timerTime.Start();
                playPauseToolStripMenuItem.Text = "Pause Game";
                backSoundPlayer.controls.play();
            }
        }
        private void TimerTime_Tick(object sender, EventArgs e)
        {
            time.AddWithSecond(-1);

            labelTime.Text = time.DisplayData();

            if (time.Hour == 0 && time.Minute == 0 && time.Second == 0)
            {
                timerTime.Stop();

                backSoundPlayer.controls.stop();
                PlaySound("lose game");

                MessageBox.Show("Timer is up");
                GameOver();
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

            if (currentWalkArea != null)
            {
                currentWalkArea.RemoveAllPerson();
            }
            currentWalkArea = null;
            GenerateWalkArea();

            player = new Player("Goof Juice", Properties.Resources.player_right, new Size(50, 50), new Point(10, 370), time);

            labelPlayer.Text = player.DisplayData();
            player.DisplayPicture(this);

            PlaySound("walk area");

            paused = false;
            playPauseToolStripMenuItem.Text = "Pause Game";
        }

        private void GameOver()
        {
            timerTime.Stop();

            panelGame.Visible = false;
            labelTime.Visible = false;
            startNewGameToolStripMenuItem.Enabled = true;
            AddLeaderboardScore();
        }
        private void GenerateWalkArea()
        {
            int areaNumber;
            if(currentTalkArea == null)
            {
                areaNumber = 1;
            }
            else
            {
                areaNumber = currentWalkArea.NoArea;
            }

            currentWalkArea?.RemoveAllPerson();
            currentWalkArea = WalkAreasLibrary.CreateArea(areaNumber);

            if (currentWalkArea != null) 
            {
                currentWalkArea.DisplayPicture(this);
                currentWalkArea.DisplayPersons(this);
                labelArea.Text = currentWalkArea.DisplayData();
            }
            if (player != null)
            {
                player.Picture.Location = new Point(0, player.Picture.Location.Y);
            }
        }

        private void GenerateTalkArea()
        {
            if (activePerson.NoPerson == 1)
            {
                currentTalkArea = new TalkAreas("kamar", Properties.Resources.talkArea1, activePerson);
                activePerson.AddQuestions();
            }
            else if (activePerson.NoPerson ==  2)
            {
                currentTalkArea = new TalkAreas("dapur", Properties.Resources.talkArea2, activePerson);
                activePerson.AddQuestions();
            }
            else if(activePerson.NoPerson == 3)
            {
                currentTalkArea = new TalkAreas("Kamar mandi", Properties.Resources.talkArea3, activePerson);
                activePerson.AddQuestions();
            }
            else if (activePerson.NoPerson == 4)
            {

            }
            else if (activePerson.NoPerson == 5)
            {

            }
            else if (activePerson.NoPerson == 6)
            {

            }
            else if (activePerson.NoPerson == 7)
            {

            }
        }

        public void EnterTalkArea()
        {
            GenerateTalkArea();

            player.Picture.Visible = false;

            panelTalkArea.BackgroundImage = currentTalkArea.Background;
            panelTalkArea.Visible = true;
            panelTalkArea.BringToFront();

            activePerson.Picture.Size = new Size(200, 300);
            activePerson.Picture.Location = new Point(300, 100);
            activePerson.DisplayPicture(panelTalkArea);

            if (activePerson.SolvedStatus == true)
            {
                activePerson.Dialog = "selamat, anda menang";
            }

            activePerson.DisplayDialog(panelTalkArea);

            PlaySound("talk area");
        }

        public void ExitTalkArea()
        {
            player.Picture.Visible = true;
            enterTalkArea = false;

            panelTalkArea.Visible = false;
            activePerson.Picture.Size = new Size(60, 90);
            activePerson.Picture.Location = activePersonLastLocation;
            activePerson.DisplayPicture(this);

            PlaySound("walk area");
        }

        private void PlaySound(string type)
        {
            otherSoundPlayer = new WindowsMediaPlayer();

            if (type == "walk area")
            {
                backSoundPlayer.URL = Application.StartupPath + "\\sound\\BacksoundWalkArea.mp3";
                backSoundPlayer.settings.setMode("loop", true);
            }
            else if (type == "talk area")
            {
                backSoundPlayer.URL = Application.StartupPath + "\\sound\\BacksoundTalkArea.mp3";
                backSoundPlayer.settings.setMode("loop", true);
            }
            else if (type == "lose game")
            {
                backSoundPlayer.URL = Application.StartupPath + "\\sound\\LoseGame.mp3";
            }
            else if (type == "win game")
            {
                backSoundPlayer.URL = Application.StartupPath + "\\sound\\WinGame.mp3";
            }
            otherSoundPlayer.controls.play();
        }

        

        public void HandleAreaEdgeReached()
        {
            if (player.Picture.Location.X + player.Picture.Width >= this.Width - 20)
            {
                if (currentWalkArea.CheckFinishAllQuestions() == true)
                {
                    if (currentWalkArea.NoArea < numOfWalkArea)
                    {
                        currentWalkArea.NoArea += 1;
                        GenerateWalkArea();
                    }
                    else
                    {
                        backSoundPlayer.controls.stop();
                        PlaySound("win game");
                        MessageBox.Show("you win, i got OCD");
                        GameOver();
                    }
                }
            }
        }

        public void AddLeaderboardScore()
        {
            if(player != null)
            {
                Leaderboard.listPlayer.Add(player.Name);
                Leaderboard.listScore.Add(player.Score);
            }
        }
    }
}
