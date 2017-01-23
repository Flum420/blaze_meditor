using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blaze_meditor
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }



        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 4000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Form1 main = new Form1();
            main.Show();
            this.Hide();
        }
    }
}
