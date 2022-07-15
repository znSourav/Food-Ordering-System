using ENTITY;
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
    public partial class Ingredients : Form
    {
        int qt;
        Menu menuObj;
        BurgerIng cBurger;
        CreateBurger cb;

        public Ingredients(CreateBurger cb, Menu menuObj, BurgerIng cBurger, int qt)
        {
            InitializeComponent();
            this.qt = qt;
            this.cb = cb;
            this.menuObj = menuObj;
            this.cBurger = cBurger;
            ListInit();
        }

        private void ListInit()
        {
            List<string> list = cBurger.Ing;
            Dictionary<string, int> qt = cBurger.Quantity;
            Dictionary<string, double> price = cBurger.Price;

            foreach (string i in list)
            {
                label1.Text += "\n" + i;
                label2.Text += "\n" + qt[i].ToString();
                label3.Text += "\n$ " + (qt[i] * price[i]).ToString();
            }
        }

        private void OkClick(object sender, EventArgs e)
        {
            menuObj.AddCustomBurger(cBurger.Cost, qt);
            menuObj.Show();
            this.Hide();
            cb.Hide();
        }

        private void BackClick(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
