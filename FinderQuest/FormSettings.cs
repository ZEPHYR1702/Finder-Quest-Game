using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinderQuest
{
    public partial class FormSettings : Form
    {
        private Dictionary<string, Keys> updateKeys;

        private string currentMap = "";

        public FormSettings(Dictionary<string, Keys> currentKeyBinds)
        {
            InitializeComponent();
            this.KeyPreview = true;

            this.UpdateKeys = new Dictionary<string, Keys>(currentKeyBinds);

            buttonMoveLeft.Text = UpdateKeys["Move Left"].ToString();
            buttonMoveRight.Text = UpdateKeys["Move Right"].ToString();
        }
        public Dictionary<string, Keys> UpdateKeys { get => updateKeys; private set => updateKeys = value; }

        private void FormSettings_Load(object sender, EventArgs e)
        {

        }
        
        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            buttonMoveLeft.Text = "Press a Key...";
            currentMap = "Move Left";
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
    }
}
