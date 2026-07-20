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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.panelGame = new System.Windows.Forms.Panel();
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.panelTalkArea = new System.Windows.Forms.Panel();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.panelViewPort = new System.Windows.Forms.Panel();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbMap = new System.Windows.Forms.PictureBox();
            this.pictureBoxStart = new System.Windows.Forms.PictureBox();
            this.panelEsc = new System.Windows.Forms.Panel();
            this.buttonSetting = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonBacktoMenu = new System.Windows.Forms.Button();
            this.buttonContinue = new System.Windows.Forms.Button();
            this.buttonLeaderboard = new System.Windows.Forms.Button();
            this.buttonS = new System.Windows.Forms.Button();
            this.buttonH = new System.Windows.Forms.Button();
            this.buttonEx = new System.Windows.Forms.Button();
            this.panelIdentitas = new System.Windows.Forms.Panel();
            this.radioButtonHard = new System.Windows.Forms.RadioButton();
            this.radioButtonMedium = new System.Windows.Forms.RadioButton();
            this.radioButtonEasy = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.panelGame.SuspendLayout();
            this.panelViewPort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).BeginInit();
            this.panelEsc.SuspendLayout();
            this.panelIdentitas.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGame
            // 
            this.panelGame.BackColor = System.Drawing.Color.Transparent;
            this.panelGame.Controls.Add(this.labelPlayer);
            this.panelGame.Controls.Add(this.labelTime);
            this.panelGame.Controls.Add(this.labelArea);
            this.panelGame.Location = new System.Drawing.Point(0, 3);
            this.panelGame.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelGame.Name = "panelGame";
            this.panelGame.Size = new System.Drawing.Size(864, 90);
            this.panelGame.TabIndex = 1;
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPlayer.Location = new System.Drawing.Point(153, 20);
            this.labelPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(102, 20);
            this.labelPlayer.TabIndex = 2;
            this.labelPlayer.Text = "Label Player";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTime.Location = new System.Drawing.Point(385, 11);
            this.labelTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(90, 25);
            this.labelTime.TabIndex = 1;
            this.labelTime.Text = "00:00:00";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelArea.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelArea.Location = new System.Drawing.Point(605, 34);
            this.labelArea.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(90, 20);
            this.labelArea.TabIndex = 0;
            this.labelArea.Text = "Label Area";
            // 
            // panelTalkArea
            // 
            this.panelTalkArea.BackColor = System.Drawing.Color.Transparent;
            this.panelTalkArea.Location = new System.Drawing.Point(0, 135);
            this.panelTalkArea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelTalkArea.Name = "panelTalkArea";
            this.panelTalkArea.Size = new System.Drawing.Size(860, 388);
            this.panelTalkArea.TabIndex = 2;
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.TimerTime_Tick);
            // 
            // panelViewPort
            // 
            this.panelViewPort.BackColor = System.Drawing.Color.Transparent;
            this.panelViewPort.Controls.Add(this.pbPlayer);
            this.panelViewPort.Controls.Add(this.pbMap);
            this.panelViewPort.Location = new System.Drawing.Point(3, 127);
            this.panelViewPort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelViewPort.Name = "panelViewPort";
            this.panelViewPort.Size = new System.Drawing.Size(861, 466);
            this.panelViewPort.TabIndex = 3;
            // 
            // pbPlayer
            // 
            this.pbPlayer.Location = new System.Drawing.Point(128, 95);
            this.pbPlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(80, 98);
            this.pbPlayer.TabIndex = 0;
            this.pbPlayer.TabStop = false;
            // 
            // pbMap
            // 
            this.pbMap.Location = new System.Drawing.Point(0, 0);
            this.pbMap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbMap.Name = "pbMap";
            this.pbMap.Size = new System.Drawing.Size(1333, 1231);
            this.pbMap.TabIndex = 1;
            this.pbMap.TabStop = false;
            this.pbMap.Paint += new System.Windows.Forms.PaintEventHandler(this.pbMap_Paint);
            // 
            // pictureBoxStart
            // 
            this.pictureBoxStart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBoxStart.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxStart.Image")));
            this.pictureBoxStart.Location = new System.Drawing.Point(364, 634);
            this.pictureBoxStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxStart.Name = "pictureBoxStart";
            this.pictureBoxStart.Size = new System.Drawing.Size(132, 82);
            this.pictureBoxStart.TabIndex = 2;
            this.pictureBoxStart.TabStop = false;
            this.pictureBoxStart.Click += new System.EventHandler(this.pictureBoxStart_Click);
            // 
            // panelEsc
            // 
            this.panelEsc.BackColor = System.Drawing.Color.Transparent;
            this.panelEsc.Controls.Add(this.buttonSetting);
            this.panelEsc.Controls.Add(this.buttonHelp);
            this.panelEsc.Controls.Add(this.buttonExit);
            this.panelEsc.Controls.Add(this.buttonBacktoMenu);
            this.panelEsc.Controls.Add(this.buttonContinue);
            this.panelEsc.Location = new System.Drawing.Point(273, 207);
            this.panelEsc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEsc.Name = "panelEsc";
            this.panelEsc.Size = new System.Drawing.Size(319, 357);
            this.panelEsc.TabIndex = 7;
            // 
            // buttonSetting
            // 
            this.buttonSetting.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonSetting.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSetting.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonSetting.Location = new System.Drawing.Point(21, 90);
            this.buttonSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSetting.Name = "buttonSetting";
            this.buttonSetting.Size = new System.Drawing.Size(284, 48);
            this.buttonSetting.TabIndex = 4;
            this.buttonSetting.Text = "Settings";
            this.buttonSetting.UseVisualStyleBackColor = false;
            this.buttonSetting.Click += new System.EventHandler(this.buttonSetting_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonHelp.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonHelp.Location = new System.Drawing.Point(21, 287);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(284, 48);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonExit.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonExit.Location = new System.Drawing.Point(21, 222);
            this.buttonExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(284, 48);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Exit Game";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonBacktoMenu
            // 
            this.buttonBacktoMenu.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonBacktoMenu.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBacktoMenu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonBacktoMenu.Location = new System.Drawing.Point(21, 155);
            this.buttonBacktoMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonBacktoMenu.Name = "buttonBacktoMenu";
            this.buttonBacktoMenu.Size = new System.Drawing.Size(284, 48);
            this.buttonBacktoMenu.TabIndex = 1;
            this.buttonBacktoMenu.Text = "Back to Menu";
            this.buttonBacktoMenu.UseVisualStyleBackColor = false;
            this.buttonBacktoMenu.Click += new System.EventHandler(this.buttonBacktoMenu_Click);
            // 
            // buttonContinue
            // 
            this.buttonContinue.BackColor = System.Drawing.SystemColors.ControlDark;
            this.buttonContinue.Font = new System.Drawing.Font("Monotype Corsiva", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonContinue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonContinue.Location = new System.Drawing.Point(21, 22);
            this.buttonContinue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonContinue.Name = "buttonContinue";
            this.buttonContinue.Size = new System.Drawing.Size(284, 48);
            this.buttonContinue.TabIndex = 0;
            this.buttonContinue.Text = "Continue";
            this.buttonContinue.UseVisualStyleBackColor = false;
            this.buttonContinue.Click += new System.EventHandler(this.buttonContinue_Click);
            // 
            // buttonLeaderboard
            // 
            this.buttonLeaderboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLeaderboard.Location = new System.Drawing.Point(12, 75);
            this.buttonLeaderboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLeaderboard.Name = "buttonLeaderboard";
            this.buttonLeaderboard.Size = new System.Drawing.Size(139, 54);
            this.buttonLeaderboard.TabIndex = 3;
            this.buttonLeaderboard.Text = "Leaderboard";
            this.buttonLeaderboard.UseVisualStyleBackColor = true;
            this.buttonLeaderboard.Click += new System.EventHandler(this.buttonLeaderboard_Click);
            // 
            // buttonS
            // 
            this.buttonS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonS.Location = new System.Drawing.Point(157, 75);
            this.buttonS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonS.Name = "buttonS";
            this.buttonS.Size = new System.Drawing.Size(115, 54);
            this.buttonS.TabIndex = 4;
            this.buttonS.Text = "Settings";
            this.buttonS.UseVisualStyleBackColor = true;
            this.buttonS.Click += new System.EventHandler(this.buttonS_Click);
            // 
            // buttonH
            // 
            this.buttonH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonH.Location = new System.Drawing.Point(277, 75);
            this.buttonH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonH.Name = "buttonH";
            this.buttonH.Size = new System.Drawing.Size(124, 54);
            this.buttonH.TabIndex = 5;
            this.buttonH.Text = "Help";
            this.buttonH.UseVisualStyleBackColor = true;
            this.buttonH.Click += new System.EventHandler(this.buttonH_Click);
            // 
            // buttonEx
            // 
            this.buttonEx.BackColor = System.Drawing.Color.Red;
            this.buttonEx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEx.Location = new System.Drawing.Point(757, 84);
            this.buttonEx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEx.Name = "buttonEx";
            this.buttonEx.Size = new System.Drawing.Size(95, 37);
            this.buttonEx.TabIndex = 6;
            this.buttonEx.Text = "Exit";
            this.buttonEx.UseVisualStyleBackColor = false;
            this.buttonEx.Click += new System.EventHandler(this.buttonEx_Click);
            // 
            // panelIdentitas
            // 
            this.panelIdentitas.Controls.Add(this.radioButtonHard);
            this.panelIdentitas.Controls.Add(this.radioButtonMedium);
            this.panelIdentitas.Controls.Add(this.radioButtonEasy);
            this.panelIdentitas.Controls.Add(this.label2);
            this.panelIdentitas.Controls.Add(this.label1);
            this.panelIdentitas.Controls.Add(this.textBoxName);
            this.panelIdentitas.Location = new System.Drawing.Point(140, 514);
            this.panelIdentitas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelIdentitas.Name = "panelIdentitas";
            this.panelIdentitas.Size = new System.Drawing.Size(564, 114);
            this.panelIdentitas.TabIndex = 3;
            // 
            // radioButtonHard
            // 
            this.radioButtonHard.AutoSize = true;
            this.radioButtonHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHard.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonHard.Location = new System.Drawing.Point(409, 75);
            this.radioButtonHard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonHard.Name = "radioButtonHard";
            this.radioButtonHard.Size = new System.Drawing.Size(67, 24);
            this.radioButtonHard.TabIndex = 13;
            this.radioButtonHard.TabStop = true;
            this.radioButtonHard.Text = "Hard";
            this.radioButtonHard.UseVisualStyleBackColor = true;
            // 
            // radioButtonMedium
            // 
            this.radioButtonMedium.AutoSize = true;
            this.radioButtonMedium.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonMedium.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonMedium.Location = new System.Drawing.Point(281, 75);
            this.radioButtonMedium.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonMedium.Name = "radioButtonMedium";
            this.radioButtonMedium.Size = new System.Drawing.Size(89, 24);
            this.radioButtonMedium.TabIndex = 12;
            this.radioButtonMedium.TabStop = true;
            this.radioButtonMedium.Text = "Medium";
            this.radioButtonMedium.UseVisualStyleBackColor = true;
            // 
            // radioButtonEasy
            // 
            this.radioButtonEasy.AutoSize = true;
            this.radioButtonEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEasy.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButtonEasy.Location = new System.Drawing.Point(187, 75);
            this.radioButtonEasy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonEasy.Name = "radioButtonEasy";
            this.radioButtonEasy.Size = new System.Drawing.Size(67, 24);
            this.radioButtonEasy.TabIndex = 11;
            this.radioButtonEasy.TabStop = true;
            this.radioButtonEasy.Text = "Easy";
            this.radioButtonEasy.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(43, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Difficulty";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(61, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.Location = new System.Drawing.Point(187, 18);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(305, 30);
            this.textBoxName.TabIndex = 8;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::FinderQuest.Properties.Resources.homeMenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(864, 729);
            this.Controls.Add(this.pictureBoxStart);
            this.Controls.Add(this.panelIdentitas);
            this.Controls.Add(this.buttonEx);
            this.Controls.Add(this.panelEsc);
            this.Controls.Add(this.buttonH);
            this.Controls.Add(this.panelViewPort);
            this.Controls.Add(this.buttonS);
            this.Controls.Add(this.panelTalkArea);
            this.Controls.Add(this.buttonLeaderboard);
            this.Controls.Add(this.panelGame);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormGame";
            this.Text = "Finder Quest Game";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            this.panelGame.ResumeLayout(false);
            this.panelGame.PerformLayout();
            this.panelViewPort.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStart)).EndInit();
            this.panelEsc.ResumeLayout(false);
            this.panelIdentitas.ResumeLayout(false);
            this.panelIdentitas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelGame;
        public System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Panel panelTalkArea;
        private System.Windows.Forms.Timer timerTime;
        public System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Panel panelViewPort;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbMap;
        private System.Windows.Forms.PictureBox pictureBoxStart;
        private System.Windows.Forms.Panel panelEsc;
        private System.Windows.Forms.Button buttonSetting;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonBacktoMenu;
        private System.Windows.Forms.Button buttonContinue;
        private System.Windows.Forms.Button buttonLeaderboard;
        private System.Windows.Forms.Button buttonH;
        private System.Windows.Forms.Button buttonS;
        private System.Windows.Forms.Button buttonEx;
        private System.Windows.Forms.Panel panelIdentitas;
        private System.Windows.Forms.RadioButton radioButtonMedium;
        private System.Windows.Forms.RadioButton radioButtonEasy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.RadioButton radioButtonHard;
    }
}

