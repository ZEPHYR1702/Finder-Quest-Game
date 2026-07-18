using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace FinderQuest
{
    public partial class FormSettings : Form
    {
        private Dictionary<string, Keys> updateKeys;
        private WindowsMediaPlayer updateVolume;

        private string currentMap = "";

        FormGame form;

        public FormSettings(Dictionary<string, Keys> currentKeyBinds, WindowsMediaPlayer currentVolume)
        {
            InitializeComponent();
            this.KeyPreview = true;

            this.UpdateKeys = new Dictionary<string, Keys>(currentKeyBinds);
            this.updateVolume = currentVolume;

            trackBarMasterVolume.Value = currentVolume.settings.volume;
            labelMasterVolume.Text = $"Master Volume: {currentVolume.settings.volume}%";

            buttonMoveLeft.Text = UpdateKeys["Move Left"].ToString();
            buttonMoveRight.Text = UpdateKeys["Move Right"].ToString();
            buttonInteract.Text = UpdateKeys["Interact"].ToString();
        }
        public Dictionary<string, Keys> UpdateKeys { get => updateKeys; private set => updateKeys = value; }
        public WindowsMediaPlayer UpdateVolume { get => updateVolume; set => updateVolume = value; }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            form = (FormGame)this.Owner;
        }
        
        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            buttonMoveLeft.Text = "Press a Key...";
            currentMap = "Move Left";
        }
        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            buttonMoveLeft.Text = "Press a Key...";
            currentMap = "Move Right";
        }
        private void buttonInteract_Click(object sender, EventArgs e)
        {
            buttonMoveLeft.Text = "Press a Key...";
            currentMap = "Interact";
        }

        private void FormSettings_KeyDown(object sender, KeyEventArgs e)
        {
            if(string.IsNullOrEmpty(currentMap) != true)
            {
                UpdateKeys[currentMap] = e.KeyCode;

                if (currentMap == "Move Left") buttonMoveLeft.Text = e.KeyCode.ToString();
                if (currentMap == "Move Right") buttonMoveRight.Text = e.KeyCode.ToString();

                currentMap = "";
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void trackBarMasterVolume_Scroll(object sender, EventArgs e)
        {
            this.UpdateVolume.settings.volume = trackBarMasterVolume.Value;
            labelMasterVolume.Text = $"Master Volume: {this.UpdateVolume.settings.volume}%";
        }
    }
}
