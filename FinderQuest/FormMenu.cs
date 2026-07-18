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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }
        public List<string> listUsername = new List<string>();
        public string difficulty;
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Name can not be empty!");
                return; 
            }
            if(radioButtonEasy.Checked)
            {
                difficulty = "easy";
            }
            else if(radioButtonMedium.Checked)
            {
                difficulty = "medium";
            }
            else if (radioButtonHard.Checked)
            {
                difficulty = "hard";
            }
            listUsername.Add(textBoxName.Text);

            FormGame form = new FormGame(difficulty);
            form.Owner = this;
            form.ShowDialog();
            this.Show();
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void buttonLeaderboard_Click(object sender, EventArgs e)
        {
            FormLeaderboard form = new FormLeaderboard();
            form.Owner = this;
            form.ShowDialog();
            this.Show();
        }
        private void FormMenu_Load(object sender, EventArgs e)
        {
            radioButtonEasy.Checked = true;
        }
    }
}
