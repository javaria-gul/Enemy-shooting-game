namespace space_invaders_project
{
    partial class helpscreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(helpscreen));
            lbl_help = new Label();
            SuspendLayout();
            // 
            // lbl_help
            // 
            lbl_help.BackColor = Color.Transparent;
            lbl_help.FlatStyle = FlatStyle.Flat;
            lbl_help.Font = new Font("Book Antiqua", 11F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_help.ForeColor = Color.White;
            lbl_help.Image = Properties.Resources.spacebg3;
            lbl_help.ImageAlign = ContentAlignment.MiddleLeft;
            lbl_help.Location = new Point(12, 9);
            lbl_help.Name = "lbl_help";
            lbl_help.Size = new Size(454, 426);
            lbl_help.TabIndex = 0;
            lbl_help.Text = resources.GetString("lbl_help.Text");
            // 
            // helpscreen
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.spacebg3;
            ClientSize = new Size(478, 444);
            Controls.Add(lbl_help);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "helpscreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "helpscreen";
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_help;
    }
}