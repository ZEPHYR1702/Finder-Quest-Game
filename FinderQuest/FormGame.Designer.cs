using System;

namespace FinderQuest
{
    partial class FormGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelGame = new System.Windows.Forms.Panel();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.panelTalkArea = new System.Windows.Forms.Panel();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.panelEsc = new System.Windows.Forms.Panel();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonBacktoMenu = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.panelGame.SuspendLayout();
            this.panelEsc.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.Color.Transparent;
            this.panelGame.Controls.Add(this.labelPlayer);
            this.panelGame.Controls.Add(this.labelTime);
            this.panelGame.Controls.Add(this.labelArea);
            this.panelGame.Location = new System.Drawing.Point(0, 3);
            this.panelGame.Margin = new System.Windows.Forms.Padding(4);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(993, 123);
            this.panelGame.TabIndex = 1;
            this.panelGame.Paint += new System.Windows.Forms.PaintEventHandler(this.panelGame_Paint);
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer.Location = new System.Drawing.Point(48, 47);
            this.labelPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(140, 26);
            this.labelPlayer.TabIndex = 2;
            this.labelPlayer.Text = "Label Player";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Red;
            this.labelTime.Location = new System.Drawing.Point(404, 29);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(236, 55);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "00:00:00";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArea.Location = new System.Drawing.Point(810, 52);
            this.labelArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(123, 26);
            this.labelArea.TabIndex = 0;
            this.labelArea.Text = "Label Area";
            // 
            // panelTalkArea
            // 
            this.panelTalkArea.BackColor = System.Drawing.Color.Transparent;
            this.panelTalkArea.Location = new System.Drawing.Point(0, 231);
            this.panelTalkArea.Margin = new System.Windows.Forms.Padding(4);
            this.panelTalkArea.Name = "panelTalkArea";
            this.panelTalkArea.Size = new System.Drawing.Size(993, 473);
            this.panelTalkArea.TabIndex = 2;
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.TimerTime_Tick);
            // 
            // panelEsc
            // 
            this.panelEsc.BackColor = System.Drawing.Color.Transparent;
            this.panelEsc.Controls.Add(this.buttonSetting);
            this.panelEsc.Controls.Add(this.buttonHelp);
            this.panelEsc.Controls.Add(this.buttonExit);
            this.panelEsc.Controls.Add(this.buttonBacktoMenu);
            this.panelEsc.Controls.Add(this.buttonContinue);
            this.panelEsc.Location = new System.Drawing.Point(364, 163);
            this.panelEsc.Name = "panelEsc";
            this.panelEsc.Size = new System.Drawing.Size(319, 363);
            this.panelEsc.TabIndex = 6;
            // 
            // buttonSetting
            // 
            this.buttonSetting.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonSetting.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetting.ForeColor = System.Drawing.Color.Gold;
            this.buttonSetting.Location = new System.Drawing.Point(22, 90);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(284, 48);
            this.buttonSetting.TabIndex = 4;
            this.buttonSetting.Text = "Settings";
            this.buttonSetting.UseVisualStyleBackColor = false;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonHelp.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.ForeColor = System.Drawing.Color.Gold;
            this.buttonHelp.Location = new System.Drawing.Point(22, 287);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(284, 48);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonExit.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.Color.Gold;
            this.buttonExit.Location = new System.Drawing.Point(22, 221);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(284, 48);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit Game";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonBacktoMenu
            // 
            this.buttonBacktoMenu.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonBacktoMenu.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBacktoMenu.ForeColor = System.Drawing.Color.Gold;
            this.buttonBacktoMenu.Location = new System.Drawing.Point(22, 155);
            this.buttonBacktoMenu.Name = "buttonBacktoMenu";
            this.buttonBacktoMenu.Size = new System.Drawing.Size(284, 48);
            this.buttonBacktoMenu.TabIndex = 1;
            this.buttonBacktoMenu.Text = "Back to Menu";
            this.buttonBacktoMenu.UseVisualStyleBackColor = false;
            this.buttonBacktoMenu.Click += new System.EventHandler(this.buttonBacktoMenu_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.Color.SaddleBrown;
            this.buttonContinue.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinue.ForeColor = System.Drawing.Color.Gold;
            this.buttonContinue.Location = new System.Drawing.Point(22, 22);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(284, 48);
            this.buttonContinue.TabIndex = 0;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FinderQuest.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 548);
            this.Controls.Add(this.panelEsc);
            this.Controls.Add(this.panelTalkArea);
            this.Controls.Add(this.panelGame);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormGame";
            this.Text = "FormGame";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            this.panelEsc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelGame;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Panel panelTalkArea;
        private System.Windows.Forms.Timer timerTime;
        public System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Panel panelEsc;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonBacktoMenu;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Button buttonSetting;
    }
}

