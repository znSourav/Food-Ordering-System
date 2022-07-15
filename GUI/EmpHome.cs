using System;
using ENTITY;
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
    public partial class EmpHome : Form
    {
        Employee user;
        EmpLogin userLogin;
        bool flag = false;

        public EmpHome(Employee emp, EmpLogin empLogin)
        {
            InitializeComponent();
            this.userLogin = empLogin;
            this.user = emp;
            InitLabels();
        }

        private void InitLabels()
        {
            UNLabel.Text += user.EmployeeUsername;
            NLabel.Text = user.EmployeeName;
            IDLabel.Text += user.EmployeeId;
            DLabel.Text = user.Designation;
        }

        private void LogOutClick(object sender, EventArgs e)
        {
            flag = false;
            userLogin.Show();
            userLogin.ClearTB();
            userLogin.Opacity = 0.1;
            timer1.Start();
        }

        private void FoodQueryButtonClick(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuFlatButton button = (Bunifu.Framework.UI.BunifuFlatButton)sender;

            if (button.Text.Equals("INSERT"))
            {
                AddFood add_food = new AddFood(this);
                add_food.Show();
                this.Hide();
            }
            else if (button.Text.Equals("UPDATE"))
            {
                UpdateFood update_food = new UpdateFood(this);
                update_food.Show();
                this.Hide();
            }
            else if (button.Text.Equals("DELETE"))
            {
                DeleteFood delete_food = new DeleteFood(this);
                delete_food.Show();
                //this.Hide();
            }
            else if (button.Text.Equals("VIEW"))
            {
                FoodList FL = new FoodList(this);
                FL.Show();
                this.Hide();
            }
            else if (button.Text.Equals("SELL"))
            {
                SellApprove sellapp = new SellApprove(this);
                sellapp.Show();
                this.Hide();
            }
        }

        private void EmpHome_Load(object sender, EventArgs e)
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
                    userLogin.Hide();
                }
            }
            else
            {
                if (userLogin.Opacity <= 0.9)
                {
                    userLogin.Opacity += .35;
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
