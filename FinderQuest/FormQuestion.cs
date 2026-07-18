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
        //Global Variable
        FormGame formGame;
        string difficulty;
        public FormQuestion(string difficulty)
        {
            InitializeComponent();
            this.difficulty = difficulty;
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
                formGame.time.AddWithSecond(ExtendTime(difficulty));

            }
            else
            {
                MessageBox.Show("salah");
                formGame.time.AddWithSecond(ReduceTime(difficulty));
            }
            this.Close();
            formGame.ExitTalkArea();
        }

        private int ExtendTime(string difficulty)
        {
            int extendTime = 0;
            if (difficulty == "easy")
            {
                extendTime = 60;
            }
            else if  (difficulty == "medium")
            {
                extendTime = 30;
            }
            else if (difficulty == "hard")
            {
                extendTime = 10;
            }
            return extendTime;
        }

        private int ReduceTime(string difficulty)
        {
            int reduceTime = 0;
            if (difficulty == "easy")
            {
                reduceTime = -10;
            }
            else if (difficulty == "medium")
            {
                reduceTime = -20;
            }
            else if (difficulty == "hard")
            {
                reduceTime = -40;
            }
            return reduceTime;
        }
    }
}
