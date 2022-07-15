using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Thankyou : Form
    {
        int c = 0;
        Timer timer = new Timer();

        public Thankyou()
        {
            InitializeComponent();
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_tick;

        }

        private void timer_tick(object sender, EventArgs e)
        {
            if (c == 3)
            {
                Home home = new Home();
                timer.Enabled = false;
                home.Show();
                this.Hide();
            }
            else
            {
                c++;
            }
        }
    }
}
