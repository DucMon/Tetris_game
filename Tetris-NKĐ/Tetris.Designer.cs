namespace Tetris_NKĐ
{
    partial class Tetris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tetris));
            this.boardPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tickTimer = new System.Windows.Forms.Timer(this.components);
            this.labelGameOver = new System.Windows.Forms.Label();
            this.buttonResume = new System.Windows.Forms.Button();
            this.textBoxScore = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxLevel = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxHighScore = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRowsCompleted = new System.Windows.Forms.RichTextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.listMusic = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.buttonSelectSong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // boardPanel
            // 
            this.boardPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.boardPanel.Location = new System.Drawing.Point(12, 12);
            this.boardPanel.Margin = new System.Windows.Forms.Padding(0);
            this.boardPanel.Name = "boardPanel";
            this.boardPanel.Size = new System.Drawing.Size(300, 598);
            this.boardPanel.TabIndex = 1;
            // 
            // tickTimer
            // 
            this.tickTimer.Interval = 500;
            this.tickTimer.Tick += new System.EventHandler(this.tickTimer_Tick);
            // 
            // labelGameOver
            // 
            this.labelGameOver.AutoSize = true;
            this.labelGameOver.Location = new System.Drawing.Point(481, 149);
            this.labelGameOver.Name = "labelGameOver";
            this.labelGameOver.Size = new System.Drawing.Size(0, 13);
            this.labelGameOver.TabIndex = 3;
            // 
            // buttonResume
            // 
            this.buttonResume.BackColor = System.Drawing.Color.Lime;
            this.buttonResume.FlatAppearance.BorderSize = 0;
            this.buttonResume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResume.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonResume.Location = new System.Drawing.Point(427, 12);
            this.buttonResume.Name = "buttonResume";
            this.buttonResume.Size = new System.Drawing.Size(106, 45);
            this.buttonResume.TabIndex = 4;
            this.buttonResume.Text = "RESUME";
            this.buttonResume.UseVisualStyleBackColor = false;
            this.buttonResume.Click += new System.EventHandler(this.buttonResume_Click);
            // 
            // textBoxScore
            // 
            this.textBoxScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxScore.Font = new System.Drawing.Font("Digital-7", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxScore.ForeColor = System.Drawing.Color.White;
            this.textBoxScore.Location = new System.Drawing.Point(315, 215);
            this.textBoxScore.Name = "textBoxScore";
            this.textBoxScore.ReadOnly = true;
            this.textBoxScore.Size = new System.Drawing.Size(151, 35);
            this.textBoxScore.TabIndex = 5;
            this.textBoxScore.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "SCORE";
            // 
            // buttonPause
            // 
            this.buttonPause.BackColor = System.Drawing.Color.Orange;
            this.buttonPause.FlatAppearance.BorderSize = 0;
            this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPause.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPause.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonPause.Location = new System.Drawing.Point(427, 63);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(106, 45);
            this.buttonPause.TabIndex = 7;
            this.buttonPause.Text = "PAUSE";
            this.buttonPause.UseVisualStyleBackColor = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Tomato;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonStart.Location = new System.Drawing.Point(315, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(106, 96);
            this.buttonStart.TabIndex = 8;
            this.buttonStart.Text = "PLAY";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // textBoxLevel
            // 
            this.textBoxLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLevel.Font = new System.Drawing.Font("Digital-7", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLevel.ForeColor = System.Drawing.Color.White;
            this.textBoxLevel.Location = new System.Drawing.Point(472, 215);
            this.textBoxLevel.Name = "textBoxLevel";
            this.textBoxLevel.ReadOnly = true;
            this.textBoxLevel.Size = new System.Drawing.Size(114, 35);
            this.textBoxLevel.TabIndex = 9;
            this.textBoxLevel.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.label2.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(469, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "LEVEL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.label4.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(312, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "HIGH SCORE";
            // 
            // textBoxHighScore
            // 
            this.textBoxHighScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxHighScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxHighScore.Font = new System.Drawing.Font("Digital-7", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHighScore.ForeColor = System.Drawing.Color.White;
            this.textBoxHighScore.Location = new System.Drawing.Point(315, 391);
            this.textBoxHighScore.Name = "textBoxHighScore";
            this.textBoxHighScore.ReadOnly = true;
            this.textBoxHighScore.Size = new System.Drawing.Size(151, 35);
            this.textBoxHighScore.TabIndex = 11;
            this.textBoxHighScore.Text = "";
            this.textBoxHighScore.TextChanged += new System.EventHandler(this.richTextBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(40)))), ((int)(((byte)(102)))));
            this.label3.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(469, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "ROW";
            // 
            // textBoxRowsCompleted
            // 
            this.textBoxRowsCompleted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.textBoxRowsCompleted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxRowsCompleted.Font = new System.Drawing.Font("Digital-7", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxRowsCompleted.ForeColor = System.Drawing.Color.White;
            this.textBoxRowsCompleted.Location = new System.Drawing.Point(472, 391);
            this.textBoxRowsCompleted.Name = "textBoxRowsCompleted";
            this.textBoxRowsCompleted.ReadOnly = true;
            this.textBoxRowsCompleted.Size = new System.Drawing.Size(114, 35);
            this.textBoxRowsCompleted.TabIndex = 13;
            this.textBoxRowsCompleted.Text = "";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Digital-7 Italic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonClose.Location = new System.Drawing.Point(539, 12);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(47, 45);
            this.buttonClose.TabIndex = 15;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // listMusic
            // 
            this.listMusic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listMusic.Font = new System.Drawing.Font("Digital-7", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listMusic.ForeColor = System.Drawing.Color.Lime;
            this.listMusic.FormattingEnabled = true;
            this.listMusic.ItemHeight = 11;
            this.listMusic.Items.AddRange(new object[] {
            "",
            "a",
            "a",
            "a",
            "a",
            "a"});
            this.listMusic.Location = new System.Drawing.Point(315, 520);
            this.listMusic.Name = "listMusic";
            this.listMusic.ScrollAlwaysVisible = true;
            this.listMusic.Size = new System.Drawing.Size(225, 48);
            this.listMusic.Sorted = true;
            this.listMusic.TabIndex = 16;
            this.listMusic.SelectedIndexChanged += new System.EventHandler(this.listMusic_SelectedIndexChanged);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(315, 563);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(225, 47);
            this.axWindowsMediaPlayer1.TabIndex = 17;
            // 
            // buttonSelectSong
            // 
            this.buttonSelectSong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.buttonSelectSong.FlatAppearance.BorderSize = 0;
            this.buttonSelectSong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelectSong.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectSong.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSelectSong.Location = new System.Drawing.Point(546, 520);
            this.buttonSelectSong.Name = "buttonSelectSong";
            this.buttonSelectSong.Size = new System.Drawing.Size(40, 90);
            this.buttonSelectSong.TabIndex = 18;
            this.buttonSelectSong.Text = "✓";
            this.buttonSelectSong.UseVisualStyleBackColor = false;
            this.buttonSelectSong.Click += new System.EventHandler(this.buttonSelectSong_Click);
            // 
            // Tetris
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(593, 618);
            this.Controls.Add(this.buttonSelectSong);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.listMusic);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRowsCompleted);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxHighScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLevel);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxScore);
            this.Controls.Add(this.buttonResume);
            this.Controls.Add(this.labelGameOver);
            this.Controls.Add(this.boardPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Tetris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tetris_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tetris_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel boardPanel;
        private System.Windows.Forms.Timer tickTimer;
        private System.Windows.Forms.Label labelGameOver;
        private System.Windows.Forms.Button buttonResume;
        private System.Windows.Forms.RichTextBox textBoxScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.RichTextBox textBoxLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox textBoxHighScore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox textBoxRowsCompleted;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.ListBox listMusic;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button buttonSelectSong;
    }
}

