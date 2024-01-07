namespace space_invaders_project
{
    partial class startmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(startmenu));
            button1 = new Button();
            btn_help = new Button();
            lbl_intro = new Label();
            lbl_developers = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Maroon;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Gold;
            button1.Location = new Point(175, 207);
            button1.Name = "button1";
            button1.Size = new Size(141, 56);
            button1.TabIndex = 0;
            button1.Text = "START GAME";
            button1.UseVisualStyleBackColor = false;
            button1.UseWaitCursor = true;
            button1.Click += loadForm1;
            // 
            // btn_help
            // 
            btn_help.BackColor = Color.Maroon;
            btn_help.FlatStyle = FlatStyle.Popup;
            btn_help.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btn_help.ForeColor = Color.Gold;
            btn_help.ImageAlign = ContentAlignment.BottomLeft;
            btn_help.Location = new Point(175, 281);
            btn_help.Name = "btn_help";
            btn_help.Size = new Size(141, 53);
            btn_help.TabIndex = 1;
            btn_help.Text = "HELP";
            btn_help.UseVisualStyleBackColor = false;
            btn_help.Click += Loadhelpscreen;
            // 
            // lbl_intro
            // 
            lbl_intro.BackColor = Color.Transparent;
            lbl_intro.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_intro.ForeColor = Color.Gold;
            lbl_intro.Location = new Point(12, 9);
            lbl_intro.Name = "lbl_intro";
            lbl_intro.Size = new Size(457, 102);
            lbl_intro.TabIndex = 2;
            lbl_intro.Text = "                  WELCOME!\r\n TO THE SPACE INVADERS GAME.\r\n";
            lbl_intro.UseWaitCursor = true;
            // 
            // lbl_developers
            // 
            lbl_developers.BackColor = Color.Maroon;
            lbl_developers.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_developers.ForeColor = Color.Gold;
            lbl_developers.ImageAlign = ContentAlignment.TopLeft;
            lbl_developers.Location = new Point(70, 400);
            lbl_developers.Name = "lbl_developers";
            lbl_developers.Size = new Size(399, 35);
            lbl_developers.TabIndex = 3;
            lbl_developers.Text = "Game Developer: Javaria Gul, Abdul Salam";
            // 
            // startmenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.spacebg3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(478, 444);
            Controls.Add(lbl_developers);
            Controls.Add(lbl_intro);
            Controls.Add(btn_help);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "startmenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Space_Invaders";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btn_help;
        private Label lbl_intro;
        private Label lbl_developers;
    }
}