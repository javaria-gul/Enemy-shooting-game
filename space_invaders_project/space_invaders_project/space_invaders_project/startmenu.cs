using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace space_invaders_project
{
    public partial class startmenu : Form
    {
        public startmenu()
        {
            InitializeComponent();
        }

        private void loadForm1(object sender, EventArgs e)
        {
            Form1 gamewindow = new Form1();
            gamewindow.Show();

        }

        private void Loadhelpscreen(object sender, EventArgs e)
        {
            helpscreen helpwindow = new helpscreen();
            helpwindow.Show();

        }
    }
}
