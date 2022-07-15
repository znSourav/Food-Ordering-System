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
    public partial class Eat : Form
    {
        private Home homeObj;
        private bool flag = false;

        public Eat(Home homeObj)
        {
            InitializeComponent();
            this.homeObj = homeObj;
        }

        private void EatButtonClick(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuTileButton button = (Bunifu.Framework.UI.BunifuTileButton)sender;
            
            if (button.Equals(EatIn))
            {
                Payment pay = new Payment(this, "Eat In");
                pay.Show();
            }
            else
            {
                Payment pay = new Payment(this, "Takeway");
                pay.Show();
            }
        }

        private void BackClick(object sender, EventArgs e)
        {
            flag = false;
            homeObj.Show();
            homeObj.Opacity = 0.1;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (flag)
            {
                if (this.Opacity <= .9)
                {
                    this.Opacity += .35;
                }
                else
                {
                    timer1.Stop();
                    homeObj.Hide();
                }
            }
            else
            {
                if (homeObj.Opacity <= 0.9)
                {
                    homeObj.Opacity += .35;
                }
                else
                {
                    timer1.Stop();
                    this.Hide();
                }
            }
        }

        private void Eat_Load(object sender, EventArgs e)
        {
            flag = true;
            this.Opacity = 0.1;
            timer1.Start();
        }
    }
}
