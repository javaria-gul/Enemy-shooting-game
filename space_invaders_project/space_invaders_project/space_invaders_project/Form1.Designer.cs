namespace space_invaders_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            player = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            alien = new PictureBox();
            alienship = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lbl_score = new Label();
            lbl_over = new Label();
            lbl_restartmenu = new GroupBox();
            lbl_quit = new Label();
            lbl_restart = new Label();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alien).BeginInit();
            ((System.ComponentModel.ISupportInitialize)alienship).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            lbl_restartmenu.SuspendLayout();
            SuspendLayout();
            // 
            // player
            // 
            player.Image = Properties.Resources.player_img;
            player.Location = new Point(208, 386);
            player.Name = "player";
            player.Size = new Size(46, 45);
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            player.TabIndex = 1;
            player.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // alien
            // 
            alien.Image = Properties.Resources.alien_gif;
            alien.Location = new Point(12, 52);
            alien.Name = "alien";
            alien.Size = new Size(60, 60);
            alien.SizeMode = PictureBoxSizeMode.AutoSize;
            alien.TabIndex = 2;
            alien.TabStop = false;
            alien.Tag = "enemy";
            // 
            // alienship
            // 
            alienship.Image = Properties.Resources.ship_gif;
            alienship.Location = new Point(379, 34);
            alienship.Name = "alienship";
            alienship.Size = new Size(50, 27);
            alienship.SizeMode = PictureBoxSizeMode.AutoSize;
            alienship.TabIndex = 3;
            alienship.TabStop = false;
            alienship.Tag = "enemy";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Stars_img;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(554, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "stars";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Image = Properties.Resources.Stars_img;
            pictureBox2.Location = new Point(12, 277);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(554, 255);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "stars";
            // 
            // lbl_score
            // 
            lbl_score.AutoSize = true;
            lbl_score.BackColor = Color.Transparent;
            lbl_score.Font = new Font("Microsoft PhagsPa", 16F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_score.ForeColor = SystemColors.GradientActiveCaption;
            lbl_score.Location = new Point(12, 7);
            lbl_score.Name = "lbl_score";
            lbl_score.Size = new Size(142, 42);
            lbl_score.TabIndex = 6;
            lbl_score.Text = "score : 0";
            // 
            // lbl_over
            // 
            lbl_over.AutoSize = true;
            lbl_over.BackColor = Color.Olive;
            lbl_over.Font = new Font("Impact", 28F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_over.ForeColor = Color.Transparent;
            lbl_over.Location = new Point(64, 43);
            lbl_over.Name = "lbl_over";
            lbl_over.Size = new Size(279, 68);
            lbl_over.TabIndex = 7;
            lbl_over.Text = "Game-Over";
            // 
            // lbl_restartmenu
            // 
            lbl_restartmenu.BackColor = Color.Transparent;
            lbl_restartmenu.BackgroundImage = Properties.Resources.spacebg3;
            lbl_restartmenu.Controls.Add(lbl_quit);
            lbl_restartmenu.Controls.Add(lbl_restart);
            lbl_restartmenu.Controls.Add(lbl_over);
            lbl_restartmenu.FlatStyle = FlatStyle.Popup;
            lbl_restartmenu.ForeColor = Color.Gold;
            lbl_restartmenu.Location = new Point(29, 89);
            lbl_restartmenu.Name = "lbl_restartmenu";
            lbl_restartmenu.Size = new Size(409, 278);
            lbl_restartmenu.TabIndex = 8;
            lbl_restartmenu.TabStop = false;
            lbl_restartmenu.Text = "MENU";
            // 
            // lbl_quit
            // 
            lbl_quit.AutoSize = true;
            lbl_quit.BackColor = Color.Transparent;
            lbl_quit.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_quit.ForeColor = Color.Gold;
            lbl_quit.Location = new Point(169, 174);
            lbl_quit.Name = "lbl_quit";
            lbl_quit.Size = new Size(73, 31);
            lbl_quit.TabIndex = 9;
            lbl_quit.Text = "QUIT";
            lbl_quit.Click += lbl_quit_Click;
            // 
            // lbl_restart
            // 
            lbl_restart.AutoSize = true;
            lbl_restart.BackColor = Color.Transparent;
            lbl_restart.Font = new Font("Britannic Bold", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_restart.ForeColor = Color.Gold;
            lbl_restart.Location = new Point(148, 140);
            lbl_restart.Name = "lbl_restart";
            lbl_restart.Size = new Size(125, 31);
            lbl_restart.TabIndex = 8;
            lbl_restart.Text = "RESTART";
            lbl_restart.Click += lbl_restart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(478, 444);
            Controls.Add(lbl_restartmenu);
            Controls.Add(lbl_score);
            Controls.Add(alienship);
            Controls.Add(alien);
            Controls.Add(player);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Space_Invaders";
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)alien).EndInit();
            ((System.ComponentModel.ISupportInitialize)alienship).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            lbl_restartmenu.ResumeLayout(false);
            lbl_restartmenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox player;
        private System.Windows.Forms.Timer timer1;
        private PictureBox alien;
        private PictureBox alienship;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lbl_score;
        private Label lbl_over;
        private GroupBox lbl_restartmenu;
        private Label lbl_quit;
        private Label lbl_restart;
    }
}