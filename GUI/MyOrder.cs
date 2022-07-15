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
    public partial class MyOrder : Form
    {
        private Menu menu;
        private string memID;
        private double cost = 0;
        private List<COList> Order;

        public MyOrder(List<COList> Order, Menu menu, string memID)
        {
            InitializeComponent();
            this.Order = Order;
            this.menu = menu;
            this.memID = memID;
            MakeList();
            DateLabel.Text = DateTime.Now.ToString() + "\nMEMO ID: " + memID;
        }

        private void MakeList()
        {
            foreach (COList i in Order)
            {
                label1.Text += "\n" + i.COFood.Name;
                label2.Text += "\n" + i.COQuantity.ToString();
                label3.Text += "\n$ " + (i.COQuantity * i.COFood.Price).ToString();
                cost += (i.COQuantity * i.COFood.Price);
            }
            CostLabel.Text = "$ " + cost.ToString();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            menu.QuickEnable();
            menu.Enabled = true;
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
        }
    }
}
