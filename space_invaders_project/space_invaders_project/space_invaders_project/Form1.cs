namespace space_invaders_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //lbl_over.Hide();
            lbl_restartmenu.Hide();
        }

        bool right, left, space;
        int score;

        void Game_Result()
        {
            foreach (Control j in this.Controls)
            {
                foreach (Control i in this.Controls)
                {
                    if (j is PictureBox && j.Tag == "bullet")
                    {
                        if (i is PictureBox && i.Tag == "enemy")
                        {
                            if (j.Bounds.IntersectsWith(i.Bounds))
                            {

                                int x;
                                Random rnd = new Random();
                                x = rnd.Next(0, 350);
                                i.Location = new Point(x, 0);
                                i.Top = -100;
                                ((PictureBox)j).Image = Properties.Resources.explosion;
                                score++;
                                lbl_score.Text = "Score : " + score;
                            }
                        }
                    }
                }
            }
            if (player.Bounds.IntersectsWith(alienship.Bounds) || player.Bounds.IntersectsWith(alien.Bounds))
            {
                timer1.Stop();
                //lbl_over.Show();
                lbl_over.BringToFront();
                lbl_restartmenu.Show();


            }
        }

        void Add_Bullet()
        {
            PictureBox bullet = new PictureBox();
            bullet.SizeMode = PictureBoxSizeMode.AutoSize;
            bullet.Image = Properties.Resources.bullet_img;
            bullet.BackColor = System.Drawing.Color.Transparent;
            bullet.Tag = "bullet";
            bullet.Left = player.Left + 15;
            bullet.Top = player.Top - 30;
            this.Controls.Add(bullet);
            bullet.BringToFront();
        }
        void Bullet_Movement()
        {
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "bullet")
                {
                    x.Top -= 10;
                    if (x.Top < 100)
                    {
                        this.Controls.Remove(x);
                    }
                }
            }


        }
        void Star()
        {
            foreach (Control j in this.Controls)
            {
                if (j is PictureBox && j.Tag == "stars")
                {
                    j.Top += 10;
                    if (j.Top > 400)
                    {
                        j.Top = 0;
                    }
                }
            }
        }


        void enemy_Movement()
        {
            Random rnd = new Random();
            int x, y;
            if (alien.Top >= 500)
            {
                x = rnd.Next(0, 300);
                alien.Location = new Point(x, 0);
            }
            if (alienship.Top >= 500)
            {
                y = rnd.Next(0, 300);
                alienship.Location = new Point(y, 0);
            }
            else
            {
                alien.Top += 15;
                alienship.Top += 10;
            }
        }


        void Arrow_key_Movement()
        {
            if (right == true)
            {
                if (player.Left < 425)
                {
                    player.Left += 20;
                }
            }
            if (left == true)
            {
                if (player.Left > 10)
                {
                    player.Left -= 20;
                }
            }
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = true;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = true;
            }
            if (e.KeyCode == Keys.Space)
            {
                space = true;
                Add_Bullet();

            }


        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                right = false;
            }
            if (e.KeyCode == Keys.Left)
            {
                left = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                space = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Arrow_key_Movement();
            enemy_Movement();
            Bullet_Movement();
            Star();
            Game_Result();

        }

        private void lbl_restart_Click(object sender, EventArgs e)
        {
            timer1.Start();
            lbl_restartmenu.Hide();
            player.Location = new Point(205, 387);
            alien.Location = new Point(12, 52);
            alienship.Location = new Point(359, 85);
            lbl_score.Text = "score: 0";
            score = 0;
        }

        private void lbl_quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}