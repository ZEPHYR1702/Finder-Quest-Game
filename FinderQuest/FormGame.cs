using FinderQuest.Class;
using FinderQuest.Properties;
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
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FinderQuest
{
    public partial class FormGame : Form
    {
        public Time time;
        public Player player;
        Image map;
        string name;
        string dataName = "leaderboard.dat";
        string difficulty = "";
        List<string> listUsername = new List<string>();

        //Default Keybinds
        private Dictionary<string, Keys> listKeyBinds = new Dictionary<string, Keys>()
        {
            {"Move Right", Keys.D },
            {"Move Left", Keys.A },
            {"Move Up", Keys.W },
            {"Move Down", Keys.S },
            {"Interact", Keys.F }
        };
        
        //Areas
        public static bool enterTalkArea = false;
        int numOfWalkArea = 3;
        WalkAreas currentWalkArea = null;
        TalkAreas currentTalkArea = null;
        WalkAreaHitbox floorWall = new WalkAreaHitbox();

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

            this.DoubleBuffered = true;
        }
        private void FormGame_Load(object sender, EventArgs e)
        {
            radioButtonEasy.Checked = true;
            LoadFromFile(dataName);
            panelGame.Visible = false;
            labelTime.Visible = false;

            panelEsc.Visible = false;

            playPauseToolStripMenuItem.Enabled = false;
            timerTime.Interval = 1000;

            this.KeyPreview = true;
            this.DoubleBuffered = true;

            panelTalkArea.Visible = false;
        }

        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == listKeyBinds["Move Right"])
            {
                if (panelGame.Visible)
                {
                    player.StateMachine.TransitionTo(new MoveRightState());
                    player.Tick();
                    HandleAreaEdgeReached();
                    UpdateCam();
                    CheckCollision(5, 0);
                }
            }
            else if (e.KeyCode == listKeyBinds["Move Left"])
            {
                if(panelGame.Visible)
                {
                    player.StateMachine.TransitionTo(new MoveLeftState());
                    player.Tick();
                    HandleAreaEdgeReached();
                    UpdateCam();
                    CheckCollision(-5, 0);
                }
            }
            else if (e.KeyCode == listKeyBinds["Move Up"])
            {
                if(panelGame.Visible == true)
                {
                    player.StateMachine.TransitionTo(new MoveUpState());
                    player.Tick();
                    HandleAreaEdgeReached();
                    UpdateCam();
                    CheckCollision(0, -5);
                }
            }
            else if (e.KeyCode == listKeyBinds["Move Down"])
            {
                if (panelGame.Visible == true)
                {
                    player.StateMachine.TransitionTo(new MoveDownState());
                    player.Tick();
                    HandleAreaEdgeReached();
                    UpdateCam();
                    CheckCollision(0, 5);
                }
            }
            else if (e.KeyCode == listKeyBinds["Interact"])
            {
                if (currentWalkArea.CheckTouchPerson(player, out Persons touchPerson) == true)
                {
                    if (panelGame.Visible == true)
                    {
                        enterTalkArea = true;
                        activePerson = touchPerson;
                        activePersonLastLocation = activePerson.Picture.Location;
                        EnterTalkArea();
                    }
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (pictureBoxStart.Visible == true)
                {
                    StartGame();
                }
                else if (currentWalkArea.CheckTouchPerson(player, out Persons touchPerson) == true)
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
                else if(panelGame.Visible == true)
                {
                    panelEsc.Visible = true;
                    panelEsc.BringToFront();
                    timerTime.Stop();
                }
            }

            else if (e.KeyCode == Keys.Y && activePerson.SolvedStatus == false)
            {
                FormQuestion form = new FormQuestion();
                form.Owner = this;
                form.ShowDialog();
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press W, A, S, D key to move foward, left, back, right. \n\nPress F to talk with the person. " + "\n\nPress Y key to answer the question. \n\nPress Esc to exit the talk area.", "How to Play");
        }

        private void StartNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartGame();
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
            name = textBoxName.Text;
            if (name == "")
            {
                MessageBox.Show("Name can not be empty!");
                return;
            }
            if (radioButtonEasy.Checked)
            {
                difficulty = "easy";
                time = new Time(0, 10, 0);
            }
            else if (radioButtonMedium.Checked)
            {
                difficulty = "medium";
                time = new Time(0, 5, 0);
            }
            else if (radioButtonHard.Checked)
            {
                difficulty = "hard";
                time = new Time(0, 2, 0);
            }
            listUsername.Add(name);
            DisableButtons();
            panelIdentitas.Visible = false;
            panelGame.Visible = true;
            panelViewPort.Visible = true;
            labelTime.Visible = true;
            playPauseToolStripMenuItem.Enabled = true;
            startNewGameToolStripMenuItem.Enabled = false;

            playPauseToolStripMenuItem.Text = "Pause Game";

            timerTime.Start();

            if (currentWalkArea != null)
            {
                currentWalkArea.RemoveAllPerson();
            }
            currentWalkArea = null;
            GenerateWalkArea();
            floorWall.HitBoxLibrary(currentWalkArea.NoArea);

            player = new Player(name, Properties.Resources.player_front, new Point(395, 50), time);
            map = currentWalkArea.Background;
            pbMap.Image = map;
            this.BackgroundImage = null;
            this.BackColor = Color.Black;

            pbPlayer.Parent = pbMap;
            pbPlayer.BringToFront();
            pbPlayer.Location = player.Picture.Location;
            pbPlayer.Image = player.Picture.Image;

            UpdateCam();
            labelPlayer.Text = player.DisplayData();

            PlaySound("walk area");

            paused = false;
            playPauseToolStripMenuItem.Text = "Pause Game";

            pictureBoxStart.Visible = false;
        }
        private void BackToMenu()
        {
            this.BackgroundImage = Resources.homeMenu;
            timerTime.Stop();
            panelGame.Visible = false;
            panelViewPort.Visible = false;
            panelIdentitas.Visible = true;
            panelEsc.Visible = false;
            pictureBoxStart.Visible = true;

            textBoxName.Text = "";
            buttonLeaderboard.Visible = true;
            buttonS.Visible = true;
            buttonH.Visible = true;
            buttonEx.Visible = true;
            
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

            panelTalkArea.BackgroundImage = Properties.Resources.emptyFloor;
            panelTalkArea.Visible = true;
            panelTalkArea.BringToFront();

            this.Controls.Remove(activePerson.Picture);

            activePerson.Picture.Size = new Size(200, 300);
            activePerson.Picture.Location = new Point(300, 100);
            activePerson.DisplayPicture(panelTalkArea);

            if (activePerson.SolvedStatus == true)
            {
                activePerson.Dialog = "Success";
            }

            activePerson.DisplayDialog(panelTalkArea);

            PlaySound("talk area");
        }

        public void ExitTalkArea()
        {
            player.Picture.Visible = true;
            enterTalkArea = false;
            panelTalkArea.Visible = false;

            panelTalkArea.Visible = false;
            activePerson.Picture.Size = new Size(60, 80);
            activePerson.Picture.Location = activePersonLastLocation;

            activePerson.Picture.Visible = false;
            pbMap.Invalidate();

            //activePerson.DisplayPicture(pbMap);
            //pbPlayer.BringToFront();

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
                        SaveToFile(dataName);
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
        private void UpdateCam()
        {
            if (player == null)
            {
                return;
            }

            pbPlayer.Location = player.Picture.Location;

            int halfWidth = pbPlayer.Width / 2;
            int halfHeight = pbPlayer.Height / 2;

            int mapX = 332 - (player.Picture.Location.X + halfWidth);
            int mapY = 120 - (player.Picture.Location.Y + halfHeight);

            pbMap.Location = new Point(mapX, mapY);
            pbPlayer.Image = player.Picture.Image;
        }
        private void CheckCollision(int moveX, int moveY)
        {
            Rectangle futureHitbox = player.Hitbox;
            futureHitbox.Offset(moveX, moveY);
            bool hitWall = false;

            foreach (Rectangle wall in floorWall.lstWallHitbox)
            {
                if (futureHitbox.IntersectsWith(wall))
                {
                    hitWall = true;
                    player.Picture.Location = new Point(player.Picture.Location.X - moveX, player.Picture.Location.Y - moveY);
                    UpdateCam();
                    break;
                }
            }

            if (hitWall == false)
            {
                player.Picture.Location = new Point(player.Picture.Location.X + moveX, player.Picture.Location.Y + moveY);
                UpdateCam();
            }

        }

        private void pictureBoxStart_Click(object sender, EventArgs e)
        {
            StartGame();
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

        private void buttonBacktoMenu_Click(object sender, EventArgs e)
        {
            BackToMenu();
            backSoundPlayer.controls.stop();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press W, A, S, D key to move foward, left, back, right. \n\nPress F to talk with the person. " + "\n\nPress Y key to answer the question. \n\nPress Esc to exit the talk area.", "How to Play");
        }

        private void buttonLeaderboard_Click(object sender, EventArgs e)
        {
            FormLeaderboard form = new FormLeaderboard();
            form.ShowDialog(this);
        }
        public void SaveToFile(string dataName)
        {
            FileStream fs = new FileStream(dataName, FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, new object[] { Leaderboard.listPlayer, Leaderboard.listScore });
            fs.Close();
        }
        public void LoadFromFile(string dataName)
        {
            if (File.Exists(dataName))
            {
                FileStream fs = new FileStream(dataName, FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                object[] data = (object[])bf.Deserialize(fs);
                Leaderboard.listPlayer = (List<string>)data[0];
                Leaderboard.listScore = (List<int>)data[1];
                fs.Close();
            }
        }

        private void buttonH_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Press W, A, S, D key to move foward, left, back, right. \n\nPress F to talk with the person. " + "\n\nPress Y key to answer the question. \n\nPress Esc to exit the talk area.", "How to Play");
        }

        private void buttonS_Click(object sender, EventArgs e)
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

        private void buttonEx_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisableButtons()
        {
            buttonLeaderboard.Visible = false;
            buttonS.Visible = false;
            buttonH.Visible = false;
            buttonEx.Visible = false;
        }

        private void pbMap_Paint(object sender, PaintEventArgs e)
        {
            if(paused || enterTalkArea || player == null || currentWalkArea == null) return;

            Graphics g = e.Graphics;
            foreach (Persons npc in currentWalkArea.ListPersons)
            {
                if(npc.Picture.Image != null)
                {
                    g.DrawImage(npc.Picture.Image, npc.Picture.Location.X, npc.Picture.Location.Y, 60, 80);
                }

                if (npc.SolvedStatus == false)
                {
                    int overlayX = npc.Picture.Location.X + (npc.Picture.Width / 2) - 15;
                    int overlayY = npc.Picture.Location.Y - 35;
                }
                //if(npc.SolvedStatus == false && npc.Picture.Visible)
                //{
                //    int overlayX = npc.Picture.Location.X + (npc.Picture.Width / 2) - 15;
                //    int overlayY = npc.Picture.Location.Y - 35;

                //    if (npc.Picture.Image != null)
                //    {
                //        g.DrawImage(npc.Picture.Image, overlayX, overlayY, 60, 80);
                //    }
                //}
            }
        }
    }
}
