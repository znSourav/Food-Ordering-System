using System;
using ENTITY;
using DATABASE;
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
    public partial class EmpLogin : Form
    {
        private Home homeObj;
        private bool flag = false;

        public EmpLogin(Home home)
        {
            InitializeComponent();
            this.homeObj = home;
        }

        private void BackClick(object sender, EventArgs e)
        {
            flag = false;
            homeObj.Show();
            homeObj.Opacity = 0.1;
            timer1.Start();
        }

        private void LoginClick(object sender, EventArgs e)
        {
            EmpCrud crudOps = new EmpCrud();
            if (crudOps.EmpLoginVerification(Username.Text, Password.Text))
            {
                Employee emp = crudOps.GetEmployee(Username.Text);
                EmpHome empHome = new EmpHome(emp, this);
                empHome.Show();
            }
            else
            {
                MessageBox message = new MessageBox("ERROR !");
                message.Show();
            }
        }

        public void ClearTB()
        {
            Username.Text = Password.Text = "";
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

        private void EmpLogin_Load(object sender, EventArgs e)
        {
            flag = true;
            this.Opacity = 0.1;
            timer1.Start();
        }
    }
}
