namespace space_invaders_project
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            start = new Button();
            SuspendLayout();
            // 
            // start
            // 
            start.BackColor = Color.Olive;
            start.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point);
            start.ForeColor = Color.White;
            start.Location = new Point(188, 266);
            start.Name = "start";
            start.Size = new Size(116, 38);
            start.TabIndex = 0;
            start.Text = "START";
            start.UseVisualStyleBackColor = false;
            start.Click += start_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.spacebg3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(478, 444);
            Controls.Add(start);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Space_Invaders";
            ResumeLayout(false);
        }

        #endregion

        private Button start;
    }
}