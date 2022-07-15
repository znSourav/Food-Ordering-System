using DATABASE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class DeleteFood : Form
    {
        private EmpHome userHome;
        private bool flag = false;

        public DeleteFood(EmpHome userHome)
        {
            InitializeComponent();
            this.userHome = userHome;
        }

        private void DeleteClick(object sender, EventArgs e)
        {
            if (FoodID.Text.Equals("") || FoodItem.Text.Equals(""))
            {
                MessageBox message = new MessageBox("ERROR !");
                message.Show();
                return;
            }

            FoodCrud CrudOps = new FoodCrud();
            bool x = CrudOps.Delete(FoodID.Text, FoodItem.Text);
            if (x)
            {
                MessageBox message = new MessageBox("DONE !");
                message.Show();
            }
            else
            {
                MessageBox message = new MessageBox("ERROR !");
                message.Show();
            }
        }

        private void BackClick(object sender, EventArgs e)
        {
            flag = false;
            userHome.Show();
            userHome.Opacity = 0.1;
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
                    userHome.Hide();
                }
            }
            else
            {
                if (userHome.Opacity <= 0.9)
                {
                    userHome.Opacity += .35;
                }
                else
                {
                    timer1.Stop();
                    this.Hide();
                }
            }
        }

        private void DeleteFood_Load(object sender, EventArgs e)
        {
            flag = true;
            this.Opacity = 0.1;
            timer1.Start();
        }
    }
}
