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
    public partial class FormQuestion : Form
    {
        FormGame formGame;
        public FormQuestion()
        {
            InitializeComponent();
        }

        private void FormQuestion_Load(object sender, EventArgs e)
        {
            formGame = (FormGame)this.Owner;
            labelQuestion.Text = formGame.activePerson.Question.Question;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (formGame.activePerson.CheckAnswer(textBoxAnswer.Text, out int score) == true)
            {
                MessageBox.Show("jawaban anda benar");
                formGame.player.AddScore(score);
                formGame.labelPlayer.Text = formGame.player.DisplayData();
            }
            else
            {
                MessageBox.Show("salah");
            }
            this.Close();
            formGame.ExitTalkArea();
        }
    }
}
