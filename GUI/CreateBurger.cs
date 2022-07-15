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
    public partial class CreateBurger : Form
    { 
        Menu menuObj;
        BurgerIng cBurger;
        int next_flag = 1, numberOfBurgers = 1;
        //double last_cost = 0, init_cost = 0;
        bool bun_flag = false;

        public CreateBurger(Menu menuObj)
        {
            InitializeComponent();
            this.menuObj = menuObj;
            cBurger = new BurgerIng();
        }

        private void NextClick(object sender, EventArgs e)
        {
            if (next_flag == 6)
            {
                Ingredients ing = new Ingredients(this, menuObj, cBurger, numberOfBurgers);
                ing.Show();
                return;
            }
            next_flag++;
            if (next_flag == 2)
            {
                BreadPanel.Visible = AR1.Visible = false;
                PattyPanel.Visible = Back.Enabled = AR2.Visible = true;
            }
            else if (next_flag == 3)
            {
                PattyPanel.Visible = AR2.Visible = false;
                CheesePanel.Visible = AR3.Visible = true;
            }
            else if (next_flag == 4)
            {
                CheesePanel.Visible = AR3.Visible = false;
                FreshPanel.Visible = AR4.Visible = true;
            }
            else if (next_flag == 5)
            {
                FreshPanel.Visible = AR4.Visible = false;
                SaucePanel.Visible = AR5.Visible = QTX.Visible = QtxDe.Visible = QtxIn.Visible = QtxL.Visible = true;
                Next.Text = "DONE";
            }
            else if (next_flag == 6)
            {
                Ingredients ing = new Ingredients(this, menuObj, cBurger, Convert.ToInt32(QtxL.Text));
                ing.Show();
            }
        }

        private void BackClick(object sender, EventArgs e)
        {
            if (next_flag == 6) next_flag = 5;

            next_flag--;
            if (next_flag == 1)
            {
                Back.Enabled = PattyPanel.Visible = AR2.Visible = false;
                BreadPanel.Visible = AR1.Visible = true;
            }
            else if (next_flag == 2)
            {
                CheesePanel.Visible = AR3.Visible = false;
                PattyPanel.Visible = AR2.Visible = true;
            }
            else if (next_flag == 3)
            {
                FreshPanel.Visible = AR4.Visible = false;
                CheesePanel.Visible = AR3.Visible = true;
            }
            else if (next_flag == 4)
            {
                SaucePanel.Visible = AR5.Visible = QTX.Visible = QtxDe.Visible = QtxIn.Visible = QtxL.Visible = false;
                FreshPanel.Visible = AR4.Visible = true;
                Next.Text = "NEXT";
            }
        }

        private void QButtonClick(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuFlatButton button = (Bunifu.Framework.UI.BunifuFlatButton)sender;

            if (button.Equals(Cancel))
            {
                menuObj.Show();
                this.Hide();
            }
            else if (button.Equals(StartOver))
            {
                AR2.Visible = AR3.Visible = AR4.Visible = AR5.Visible = Tick1.Visible = Tick2.Visible = Tick3.Visible = Tick4.Visible = false;
                Tick5.Visible = Tick6.Visible = Tick7.Visible = Tick8.Visible = Tick9.Visible = Tick10.Visible = Tick11.Visible = Tick12.Visible = false;
                Tick13.Visible = Tick14.Visible = Tick15.Visible = Back.Enabled = Next.Enabled = PattyPanel.Visible = CheesePanel.Visible = false;
                FreshPanel.Visible = SaucePanel.Visible = QTX.Visible = QtxDe.Visible = QtxIn.Visible = QtxL.Visible = bun_flag = false;
                AR1.Visible = BreadPanel.Visible = true;
                Amount.Text = "$ 0";
                QtxL.Text = "1";
                AQtx.Text = CQtx.Text = CHQtx.Text = MQtx.Text = PJQtx.Text = PQtx.Text = "0";
                Next.Text = "NEXT";
                next_flag = 1;
                cBurger.Clear();
            }
        }

        private void PattyClick(object sender, EventArgs e) 
        {
            PictureBox button = (PictureBox)sender;

            if (button.Equals(AInc))
            {
                if (AQtx.Text.Equals("10")) return;
                Tick4.Visible = true;
                cBurger.AddStuff("Angus Beef", 2);
                Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
                AQtx.Text = (Convert.ToInt32(AQtx.Text) + 1).ToString();
            }
            else if (button.Equals(CInc))
            {
                if (CQtx.Text.Equals("10")) return;
                Tick5.Visible = true;
                cBurger.AddStuff("Chicken Fillet", 1);
                Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
                CQtx.Text = (Convert.ToInt32(CQtx.Text) + 1).ToString();
            }
            else if (button.Equals(PInc))
            {
                if (PQtx.Text.Equals("10")) return;
                Tick6.Visible = true;
                cBurger.AddStuff("Portobello", 0.5);
                Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
                PQtx.Text = (Convert.ToInt32(PQtx.Text) + 1).ToString();
            }
            else if (button.Equals(ADec))
            {
                if (AQtx.Text.Equals("0")) return;
                AQtx.Text = (Convert.ToInt32(AQtx.Text) - 1).ToString();
                if (AQtx.Text.Equals("0")) Tick4.Visible = false;
                cBurger.RemoveStuff("Angus Beef", 2);
                Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
            }
            else if (button.Equals(CDec))
            {
                if (CQtx.Text.Equals("0")) return;
                CQtx.Text = (Convert.ToInt32(CQtx.Text) - 1).ToString();
                if (CQtx.Text.Equals("0")) Tick5.Visible = false;
                cBurger.RemoveStuff("Chicken Fillet", 1);
                Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
            }
            else if (button.Equals(PDec))
            {
                if (PQtx.Text.Equals("0")) return;
                PQtx.Text = (Convert.ToInt32(PQtx.Text) - 1).ToString();
                if (PQtx.Text.Equals("0")) Tick6.Visible = false;
                cBurger.RemoveStuff("Portobello", 0.5);
                Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
            }
        }      

        private void BunClick(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuTileButton button = (Bunifu.Framework.UI.BunifuTileButton)sender;

            if (button.Equals(BakeryBun))
            {
                if (!bun_flag)
                {
                    Tick1.Visible = bun_flag = Next.Enabled = true;
                    cBurger.AddStuff("Bakery Bun", 0.50);
                    Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
                }
                else if (!Tick1.Visible)
                {
                    Tick1.Visible = true;
                    cBurger.AddStuff("Bakery Bun", 0.50);
                    cBurger.RemoveStuff("Brioche", 1);
                    cBurger.RemoveStuff("Bunless", 0.25);
                    Tick2.Visible = Tick3.Visible = false;
                    Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
                }
            }
            else if (button.Equals(Brioche))
            {
                if (!bun_flag)
                {
                    Tick2.Visible = bun_flag = Next.Enabled = true;
                    cBurger.AddStuff("Brioche", 1);
                    Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
                }
                else if (!Tick2.Visible)
                {
                    Tick2.Visible = true;
                    cBurger.AddStuff("Brioche", 1);
                    cBurger.RemoveStuff("Bakery Bun", 0.50);
                    cBurger.RemoveStuff("Bunless", 0.25);
                    Tick1.Visible = Tick3.Visible = false;
                    Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
                }
            }
            else
            {
                if (!bun_flag)
                {
                    Tick3.Visible = bun_flag = Next.Enabled = true;
                    cBurger.AddStuff("Bunless", 0.25);
                    Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
                }
                else if (!Tick3.Visible)
                {
                    Tick3.Visible = true;
                    cBurger.AddStuff("Bunless", 0.25);
                    cBurger.RemoveStuff("Brioche", 1);
                    cBurger.RemoveStuff("Bakery Bun", 0.50);
                    Tick1.Visible = Tick2.Visible = false;
                    Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
                }
            }
        }

        private void CheeseClick(object sender, EventArgs e)
        {
            PictureBox button = (PictureBox)sender;

            if (button.Equals(CHInc))
            {
                if (CHQtx.Text.Equals("5")) return;
                Tick7.Visible = true;
                cBurger.AddStuff("Cheddar Cheese", 0.5);
                CHQtx.Text = (Convert.ToInt32(CHQtx.Text) + 1).ToString();
                Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
            }
            else if (button.Equals(MInc))
            {
                if (MQtx.Text.Equals("5")) return;
                Tick8.Visible = true;
                cBurger.AddStuff("Mozzarella Cheese", 0.5);
                MQtx.Text = (Convert.ToInt32(MQtx.Text) + 1).ToString();
                Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
            }
            else if (button.Equals(PJInc))
            {
                if (PJQtx.Text.Equals("5")) return;
                Tick9.Visible = true;
                cBurger.AddStuff("Pepper Jack Cheese", 1);
                PJQtx.Text = (Convert.ToInt32(PJQtx.Text) + 1).ToString();
                Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
            }
            else if (button.Equals(CHDec))
            {
                if (CHQtx.Text.Equals("0")) return;
                CHQtx.Text = (Convert.ToInt32(CHQtx.Text) - 1).ToString();
                if (CHQtx.Text.Equals("0")) Tick7.Visible = false;
                cBurger.RemoveStuff("Cheddar Cheese", 0.5);
                Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
            }
            else if (button.Equals(MDec))
            {
                if (MQtx.Text.Equals("0")) return;
                MQtx.Text = (Convert.ToInt32(MQtx.Text) - 1).ToString();
                if (MQtx.Text.Equals("0")) Tick8.Visible = false;
                cBurger.RemoveStuff("Mozzarella Cheese", 0.5);
                Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
            }
            else if (button.Equals(PJDec))
            {
                if (PJQtx.Text.Equals("0")) return;
                PJQtx.Text = (Convert.ToInt32(PJQtx.Text) - 1).ToString();
                if (PJQtx.Text.Equals("0")) Tick9.Visible = false;
                cBurger.RemoveStuff("Pepper Jack Cheese", 1);
                Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
            }
        }

        private void FreshClick(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuTileButton button = (Bunifu.Framework.UI.BunifuTileButton)sender;

            if (button.Equals(Onion))
            {
                if (!Tick10.Visible)
                {
                    Tick10.Visible = true;
                    cBurger.AddStuff("Caramelised Onions", 1);
                    Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
                }
                else
                {
                    Tick10.Visible = false;
                    cBurger.RemoveStuff("Caramelised Onions", 1);
                    Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
                }
            }
            else if (button.Equals(Tomato))
            {
                if (!Tick11.Visible)
                {
                    Tick11.Visible = true;
                    cBurger.AddStuff("Fresh Slice Tomatoes", 0.8);
                    Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
                }
                else
                {
                    Tick11.Visible = false;
                    cBurger.RemoveStuff("Fresh Slice Tomatoes", 0.8);
                    Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
                }
            }
            else
            {
                if (!Tick12.Visible)
                {
                    Tick12.Visible = true;
                    cBurger.AddStuff("Jalapenos", 0.8);
                    Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
                }
                else
                {
                    Tick12.Visible = false;
                    cBurger.RemoveStuff("Jalapenos", 0.8);
                    Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
                }
            }
        }

        private void SauceClick(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuTileButton button = (Bunifu.Framework.UI.BunifuTileButton)sender;

            if (button.Equals(SpecialSauce))
            {
                if (!Tick13.Visible)
                {
                    Tick13.Visible = true;
                    cBurger.AddStuff("Special Sauce", 0.8);
                    Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
                }
                else
                {
                    Tick13.Visible = false;
                    cBurger.RemoveStuff("Special Sauce", 0.8);
                    Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
                }
            }
            else if (button.Equals(Mustard))
            {
                if (!Tick14.Visible)
                {
                    Tick14.Visible = true;
                    cBurger.AddStuff("Mustard", 0.5);
                    Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
                }
                else
                {
                    Tick14.Visible = false;
                    cBurger.RemoveStuff("Mustard", 0.5);
                    Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
                }
            }
            else
            {
                if (!Tick15.Visible)
                {
                    Tick15.Visible = true;
                    cBurger.AddStuff("Ketchup", 0.5);
                    Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
                }
                else
                {
                    Tick15.Visible = false;
                    cBurger.RemoveStuff("Ketchup", 0.5);
                    Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
                }
            }
        }

        private void QtxClick(object sender, EventArgs e)
        {
            PictureBox button = (PictureBox)sender;
            if (sender == QtxIn)
            {
                QtxL.Text = (Convert.ToInt32(QtxL.Text) + 1).ToString();
                numberOfBurgers++;
                Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
            }
            else
            {
                if (!QtxL.Text.Equals("1"))
                {
                    QtxL.Text = (Convert.ToInt32(QtxL.Text) - 1).ToString();
                    numberOfBurgers--;
                    Amount.Text = "$ " + (cBurger.Cost * numberOfBurgers).ToString();
                }
            }
        }
    }
}
