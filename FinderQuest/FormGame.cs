using FinderQuest.Class;
using FinderQuest.States.PlayerState;
using FinderQuest.TalkArea;
using FinderQuest.WalkArea;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace FinderQuest
{
    public partial class FormGame : Form
    {
        FormMenu frmMenu;

        public Time time;
        public Player player;
        string difficulty;

        //Default Keybinds
        private Dictionary<string, Keys> listKeyBinds = new Dictionary<string, Keys>()
        {
            {"Move Right", Keys.D },
            {"Move Left", Keys.A },
            {"Interact", Keys.F }
        };
        
        //Areas
        public static bool enterTalkArea = false;
        int numOfWalkArea = 2;
        WalkAreas currentWalkArea = null;
        TalkAreas currentTalkArea = null;

        //Persons
        public Persons activePerson;
        Point activePersonLastLocation;

        //Audio
        WindowsMediaPlayer backSoundPlayer = new WindowsMediaPlayer();
        WindowsMediaPlayer otherSoundPlayer;

        public FormGame(string difficulty)
        {
            InitializeComponent();
            this.difficulty = difficulty;
        }
        private void FormGame_Load(object sender, EventArgs e)
        {
            try
            {
                frmMenu = (FormMenu)this.Owner;
                timerTime.Interval = 1000;

                this.KeyPreview = true;
                this.DoubleBuffered = true;

                panelEsc.Visible = false;

                if(difficulty == "easy")
                {
                    time = new Time(0, 10, 0);
                }
                else if(difficulty == "medium")
                {
                    time = new Time(0, 5, 0);
                }
                else if (difficulty == "hard")
                {
                    time = new Time(0, 2, 0);
                }
                timerTime.Start();

                if (currentWalkArea != null)
                {
                    currentWalkArea.RemoveAllPerson();
                }
                currentWalkArea = null;
                GenerateWalkArea();

                string name = frmMenu.listUsername[frmMenu.listUsername.Count - 1];
                player = new Player(name, Properties.Resources.player_right, new Size(60, 75), new Point(10, 360), time);

                labelPlayer.Text = player.DisplayData();
                player.DisplayPicture(this);

                PlaySound("walk area");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == listKeyBinds["Move Right"])
            {
                player.StateMachine.TransitionTo(new MoveRightState());
                player.Tick();
                HandleAreaEdgeReached();
            }
            else if (e.KeyCode == listKeyBinds["Move Left"])
            {
                player.StateMachine.TransitionTo(new MoveLeftState());
                player.Tick();
                HandleAreaEdgeReached();
            }
            else if (e.KeyCode == listKeyBinds["Interact"])
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
                if (enterTalkArea)
                {
                    ExitTalkArea();
                }
                else
                {
                    panelEsc.Visible = true;
                    panelEsc.BringToFront();
                    timerTime.Stop();
                }
            }

            else if (e.KeyCode == Keys.Y && activePerson != null)
            {
                if(activePerson.SolvedStatus == false)
                {
                    FormQuestion form = new FormQuestion(difficulty);
                    form.Owner = this;
                    form.ShowDialog();
                }
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
        private void leaderboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLeaderboard form = new FormLeaderboard();
            form.ShowDialog(this);
        }
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormSettings form = new FormSettings(listKeyBinds, backSoundPlayer))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    this.listKeyBinds = form.UpdateKeys;
                    MessageBox.Show("Keybinds updated successfully");
                }
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

        private void GameOver()
        {
            this.Close();
        }
        private void GenerateWalkArea()
        {
            int areaNumber;
            if(currentWalkArea == null)
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
            if(TalkAreasLibrary.listTalkArea.TryGetValue(activePerson.NoPerson, out TalkAreasData data))
            {
                currentTalkArea = new TalkAreas(data.Location, data.Resource, activePerson);
                activePerson.AddQuestions();
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
                activePerson.Dialog = "You have answered this question correctly!";
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
                        AddLeaderboardScore();
                        frmMenu.SaveToFile(frmMenu.dataName);
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

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            panelGame.BringToFront();
            panelEsc.SendToBack();
            panelGame.Focus();
            panelEsc.Visible = false;

            timerTime.Start();

            this.Focus();
        }

        private void buttonBacktoMenu_Click(object sender, EventArgs e)
        {
            this.Close();
            backSoundPlayer.controls.stop();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press arrow key to move the player. \n\nPress Enter to talk with the person. " + "\n\nPress y key to answer the question. \n\nPress Esc to exit the talk area.", "How to Play");
        }

        private void buttonSetting_Click(object sender, EventArgs e)
        {
            using (FormSettings form = new FormSettings(listKeyBinds, backSoundPlayer))
            {
                if (form.ShowDialog(this) == DialogResult.OK)
                {
                    this.listKeyBinds = form.UpdateKeys;
                    MessageBox.Show("Keybinds updated successfully");
                }
            }
        }
    }
}
