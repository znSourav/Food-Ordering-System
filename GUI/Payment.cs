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
    public partial class Payment : Form
    {
        private string eatWhere;
        private Eat eatObj;
        private bool flag = false;

        public Payment(Eat eatObj, string eatWhere)
        {
            InitializeComponent();
            this.eatObj = eatObj;
            this.eatWhere = eatWhere;
        }

        private void PayWhereClick(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuTileButton button = (Bunifu.Framework.UI.BunifuTileButton)sender;
            string payWhere = "";
            if (button.Equals(PayAtCounter)) payWhere = "At Counter";
            else payWhere = "At Point";

            Menu menu = new Menu(this, eatWhere, payWhere);
            menu.Show();
            this.Hide();
        }

        private void BackClick(object sender, EventArgs e)
        {
            flag = false;
            eatObj.Show();
            eatObj.Opacity = 0.1;
            timer1.Start();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            flag = true;
            this.Opacity = 0.1;
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
                    eatObj.Hide();
                }
            }
            else
            {
                if (eatObj.Opacity <= 0.9)
                {
                    eatObj.Opacity += .35;
                }
                else
                {
                    timer1.Stop();
                    this.Hide();
                }
            }
        }
    }
}
