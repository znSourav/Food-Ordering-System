using ENTITY;
using DATABASE;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class CheckOut : Form
    {
        double cost = 0;
        List<COList> Order;
        string eatWhere, payWhere, memID = "";

        public CheckOut(string eatWhere, string payWhere, string memID, List<COList> Order)
        {
            InitializeComponent();
            this.eatWhere = eatWhere;
            this.payWhere = payWhere;
            this.memID = memID;
            this.Order = Order;

            if (payWhere.Equals("At Point")) Proc.Text = "SWIPE CARD";

            // Adding stuff to ListLabels
            for (int i = 0; i < Order.Count; i++)
            {
                if (i == 0)
                {
                    L1.Text = Order[i].COFood.Name;
                    L2.Text = Order[i].COQuantity.ToString();
                    L3.Text = "$" + (Order[i].COQuantity * Order[i].COFood.Price).ToString();
                    cost += (Order[i].COQuantity * Order[i].COFood.Price);
                }
                else
                {
                    L1.Text += "\n" + Order[i].COFood.Name;
                    L2.Text += "\n" + Order[i].COQuantity.ToString();
                    L3.Text += "\n$" + (Order[i].COQuantity * Order[i].COFood.Price).ToString();
                    cost += (Order[i].COQuantity * Order[i].COFood.Price);
                }
            }
            CL1.Text = "$ " + cost.ToString();
        }

        private void Proc_Click(object sender, EventArgs e)
        {
            foreach (COList i in Order)
            {
                SaleCrud crudops = new SaleCrud();
                bool x = crudops.Insert(Convert.ToInt32(memID), i.COFood.FoodType, i.COFood.Name, i.COFood.FoodID, eatWhere, payWhere, i.COQuantity, Convert.ToDouble(i.COFood.Price * i.COQuantity));
                if (!x)
                {
                    MessageBox message = new MessageBox("ERROR !");
                    message.Show();
                }
            }

            MemoCrud crudOp = new MemoCrud();
            bool xo = crudOp.Insert(Convert.ToInt32(memID), eatWhere, payWhere, cost);
            if (!xo)
            {
                MessageBox message = new MessageBox("ERROR !");
                message.Show();
            }

            // Printing Reciept here!!
            RecieptMaker rm = new RecieptMaker(memID);
            rm.PrintReceipt();

            Thankyou t = new Thankyou();
            t.Show();
            this.Hide();
        }
    }
}
