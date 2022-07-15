using DATABASE;
using ENTITY;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class Menu : Form
    {
        // Custom object we need for adding stuff during runtime
        struct FList 
        {
            public Food food;
            public Label namex, pricex, quantityx;
            public PictureBox imagex, incx, decx;      
        }

        Payment payObj;
        double cost = 0;
        bool flag = false;
        string eatWhere, payWhere, memID;
        List<FList> Burgers, SetMenus, Drinks, Desserts, Extras;
        List<COList> Order; // This object will be passed to a bill object
        int BX1 = 0, BX2 = 40, BX3 = 70, BX4 = 200, BY1 = 0, BY2 = 35, BY3 = 305, BY4 = 308, customB = 0;

        public Menu(Payment payObj, string eatWhere, string payWhere)
        {
            InitializeComponent();
            SetFoodInPanels();
            this.payObj = payObj;
            this.eatWhere = eatWhere;
            this.payWhere = payWhere;
            Order = new List<COList>();

            // Generating Memo ID for each ORDER
            this.memID = "";
            string path = Environment.CurrentDirectory.ToString();
            path = path.Remove(path.Length - 13);
            path = path + @"DATABASE\MemoID.txt";
            if (File.Exists(path))
            {
                string s = File.ReadAllText(path);
                long x = Convert.ToInt64(s) + 1;
                this.memID = x.ToString();
            }
            else
            {
                FileStream fs = File.Create(path);
                fs.Close();
                this.memID = "21242";
                string[] lines = { memID };
                File.WriteAllLines(path, lines);
            }
        }

        public void AddCustomBurger(double c, int qt)
        {
            customB++;
            Food f = new Food();
            f.Name = "Create Your Taste " + customB.ToString();
            f.FoodID = "9999";
            f.Price = c;
            f.FoodType = "CYT";

            COList co = new COList(f, 1);
            Order.Add(co);

            cost += (c * qt);
            co.COQuantity = qt;
            CostLabel.Text = cost.ToString();
        }

        public void QuickEnable()
        {
            Cancel.Visible = Checkout.Visible = MyOrderB.Visible = true;
        }

        private void SetFoodInPanels()
        {
            FoodCrud op = new FoodCrud();

            // 1. Burger Panel init
            Burgers = new List<FList>();
            List<Food>all_burgers = op.GetAllFood("Burger");
            for (int i = 0; i < all_burgers.Count; i++)
            {
                FList xo = new FList();
                xo.namex = new Label();
                xo.namex.AutoSize = true;
                xo.namex.Text = all_burgers[i].Name;
                xo.namex.Font = new Font("HP Simplified", 23F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                xo.namex.Location = new Point(BX1, BY1);
                BurgerPanel.Controls.Add(xo.namex);

                xo.imagex = new PictureBox();
                xo.imagex.Image = Image.FromStream(all_burgers[i].MemS);
                xo.imagex.Location = new Point(BX1, BY2);
                xo.imagex.SizeMode = PictureBoxSizeMode.Zoom;
                xo.imagex.Size = new Size(280, 270);
                BurgerPanel.Controls.Add(xo.imagex);

                xo.decx = new PictureBox();
                xo.decx.Image = Properties.Resources.minus;
                xo.decx.Location = new Point(BX1, BY3);
                xo.decx.SizeMode = PictureBoxSizeMode.AutoSize;
                xo.decx.Cursor = Cursors.Hand;
                xo.decx.Click += new EventHandler(IncDecClick);
                BurgerPanel.Controls.Add(xo.decx);

                xo.quantityx = new Label();
                xo.quantityx.Text = "0";
                xo.quantityx.AutoSize = true;
                xo.quantityx.Font = new Font("HP Simplified", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                xo.quantityx.Location = new Point(BX2, BY4);
                BurgerPanel.Controls.Add(xo.quantityx);

                xo.incx = new PictureBox();
                xo.incx.Image = Properties.Resources.plus;
                xo.incx.Location = new Point(BX3, BY3);
                xo.incx.SizeMode = PictureBoxSizeMode.AutoSize;
                xo.incx.Cursor = Cursors.Hand;
                xo.incx.Click += new EventHandler(IncDecClick);
                BurgerPanel.Controls.Add(xo.incx);

                xo.pricex = new Label();
                xo.pricex.AutoSize = true;
                xo.pricex.Text = "$" + all_burgers[i].Price.ToString();
                xo.pricex.Font = new Font("HP Simplified", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                xo.pricex.Location = new Point(BX4, BY3);
                BurgerPanel.Controls.Add(xo.pricex);

                xo.food = all_burgers[i];

                BX1 += 355;
                BX2 += 355;
                BX3 += 355;
                BX4 += 355;

                Burgers.Add(xo);
            }
            BX1 = 0; BX2 = 40; BX3 = 70; BX4 = 200;

            // 2. Drinks Panel init
            Drinks = new List<FList>();
            List<Food> all_drinks = op.GetAllFood("Drink");
            for (int i = 0; i < all_drinks.Count; i++)
            {
                FList xo = new FList();
                xo.namex = new Label();
                xo.namex.AutoSize = true;
                xo.namex.Text = all_drinks[i].Name;
                xo.namex.Font = new Font("HP Simplified", 23F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                xo.namex.Location = new Point(BX1, BY1);
                DrinkPanel.Controls.Add(xo.namex);

                xo.imagex = new PictureBox();
                xo.imagex.Image = Image.FromStream(all_drinks[i].MemS);
                xo.imagex.Location = new Point(BX1, BY2);
                xo.imagex.SizeMode = PictureBoxSizeMode.Zoom;
                xo.imagex.Size = new Size(280, 270);
                DrinkPanel.Controls.Add(xo.imagex);

                xo.decx = new PictureBox();
                xo.decx.Image = Properties.Resources.minus;
                xo.decx.Location = new Point(BX1, BY3);
                xo.decx.SizeMode = PictureBoxSizeMode.AutoSize;
                xo.decx.Cursor = Cursors.Hand;
                xo.decx.Click += new EventHandler(IncDecClick);
                DrinkPanel.Controls.Add(xo.decx);

                xo.quantityx = new Label();
                xo.quantityx.Text = "0";
                xo.quantityx.AutoSize = true;
                xo.quantityx.Font = new Font("HP Simplified", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                xo.quantityx.Location = new Point(BX2, BY4);
                DrinkPanel.Controls.Add(xo.quantityx);

                xo.incx = new PictureBox();
                xo.incx.Image = Properties.Resources.plus;
                xo.incx.Location = new Point(BX3, BY3);
                xo.incx.SizeMode = PictureBoxSizeMode.AutoSize;
                xo.incx.Cursor = Cursors.Hand;
                xo.incx.Click += new EventHandler(IncDecClick);
                DrinkPanel.Controls.Add(xo.incx);

                xo.pricex = new Label();
                xo.pricex.AutoSize = true;
                xo.pricex.Text = "$" + all_drinks[i].Price.ToString();
                xo.pricex.Font = new Font("HP Simplified", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                xo.pricex.Location = new Point(BX4, BY3);
                DrinkPanel.Controls.Add(xo.pricex);

                xo.food = all_drinks[i];

                BX1 += 355;
                BX2 += 355;
                BX3 += 355;
                BX4 += 355;

                Drinks.Add(xo);
            }
            BX1 = 0; BX2 = 40; BX3 = 70; BX4 = 200;

            // 3. ComboMeal Panel init
            SetMenus = new List<FList>();
            List<Food>all_CM = op.GetAllFood("ComboMeal");
            for (int i = 0; i < all_CM.Count; i++)
            {
                FList xo = new FList();
                xo.namex = new Label();
                xo.namex.AutoSize = true;
                xo.namex.Text = all_CM[i].Name;
                xo.namex.Font = new Font("HP Simplified", 23F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                xo.namex.Location = new Point(BX1, BY1);
                ComboMealPanel.Controls.Add(xo.namex);

                xo.imagex = new PictureBox();
                xo.imagex.Image = Image.FromStream(all_CM[i].MemS);
                xo.imagex.Location = new Point(BX1, BY2);
                xo.imagex.SizeMode = PictureBoxSizeMode.Zoom;
                xo.imagex.Size = new Size(280, 270);
                ComboMealPanel.Controls.Add(xo.imagex);

                xo.decx = new PictureBox();
                xo.decx.Image = Properties.Resources.minus;
                xo.decx.Location = new Point(BX1, BY3);
                xo.decx.SizeMode = PictureBoxSizeMode.AutoSize;
                xo.decx.Cursor = Cursors.Hand;
                xo.decx.Click += new EventHandler(IncDecClick);
                ComboMealPanel.Controls.Add(xo.decx);

                xo.quantityx = new Label();
                xo.quantityx.Text = "0";
                xo.quantityx.AutoSize = true;
                xo.quantityx.Font = new Font("HP Simplified", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                xo.quantityx.Location = new Point(BX2, BY4);
                ComboMealPanel.Controls.Add(xo.quantityx);

                xo.incx = new PictureBox();
                xo.incx.Image = Properties.Resources.plus;
                xo.incx.Location = new Point(BX3, BY3);
                xo.incx.SizeMode = PictureBoxSizeMode.AutoSize;
                xo.incx.Cursor = Cursors.Hand;
                xo.incx.Click += new EventHandler(IncDecClick);
                ComboMealPanel.Controls.Add(xo.incx);

                xo.pricex = new Label();
                xo.pricex.AutoSize = true;
                xo.pricex.Text = "$" + all_CM[i].Price.ToString();
                xo.pricex.Font = new Font("HP Simplified", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                xo.pricex.Location = new Point(BX4, BY3);
                ComboMealPanel.Controls.Add(xo.pricex);

                xo.food = all_CM[i];

                BX1 += 355;
                BX2 += 355;
                BX3 += 355;
                BX4 += 355;

                SetMenus.Add(xo);
            }
            BX1 = 0; BX2 = 40; BX3 = 70; BX4 = 200;

            // 4. Dessert Panel init
            Desserts = new List<FList>();
            List<Food> all_dessert = op.GetAllFood("Dessert");
            for (int i = 0; i < all_dessert.Count; i++)
            {
                FList xo = new FList();
                xo.namex = new Label();
                xo.namex.AutoSize = true;
                xo.namex.Text = all_dessert[i].Name;
                xo.namex.Font = new Font("HP Simplified", 23F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                xo.namex.Location = new Point(BX1, BY1);
                DessertPanel.Controls.Add(xo.namex);

                xo.imagex = new PictureBox();
                xo.imagex.Image = Image.FromStream(all_dessert[i].MemS);
                xo.imagex.Location = new Point(BX1, BY2);
                xo.imagex.SizeMode = PictureBoxSizeMode.Zoom;
                xo.imagex.Size = new Size(280, 270);
                DessertPanel.Controls.Add(xo.imagex);

                xo.decx = new PictureBox();
                xo.decx.Image = Properties.Resources.minus;
                xo.decx.Location = new Point(BX1, BY3);
                xo.decx.SizeMode = PictureBoxSizeMode.AutoSize;
                xo.decx.Cursor = Cursors.Hand;
                xo.decx.Click += new EventHandler(IncDecClick);
                DessertPanel.Controls.Add(xo.decx);

                xo.quantityx = new Label();
                xo.quantityx.Text = "0";
                xo.quantityx.AutoSize = true;
                xo.quantityx.Font = new Font("HP Simplified", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                xo.quantityx.Location = new Point(BX2, BY4);
                DessertPanel.Controls.Add(xo.quantityx);

                xo.incx = new PictureBox();
                xo.incx.Image = Properties.Resources.plus;
                xo.incx.Location = new Point(BX3, BY3);
                xo.incx.SizeMode = PictureBoxSizeMode.AutoSize;
                xo.incx.Cursor = Cursors.Hand;
                xo.incx.Click += new EventHandler(IncDecClick);
                DessertPanel.Controls.Add(xo.incx);

                xo.pricex = new Label();
                xo.pricex.AutoSize = true;
                xo.pricex.Text = "$" + all_dessert[i].Price.ToString();
                xo.pricex.Font = new Font("HP Simplified", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                xo.pricex.Location = new Point(BX4, BY3);
                DessertPanel.Controls.Add(xo.pricex);

                xo.food = all_dessert[i];

                BX1 += 355;
                BX2 += 355;
                BX3 += 355;
                BX4 += 355;

                SetMenus.Add(xo);
            }
            BX1 = 0; BX2 = 40; BX3 = 70; BX4 = 200;

            // 5. Dessert Panel init
            Extras = new List<FList>();
            List<Food> all_extra = op.GetAllFood("Extra");
            for (int i = 0; i < all_extra.Count; i++)
            {
                FList xo = new FList();
                xo.namex = new Label();
                xo.namex.AutoSize = true;
                xo.namex.Text = all_extra[i].Name;
                xo.namex.Font = new Font("HP Simplified", 23F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                xo.namex.Location = new Point(BX1, BY1);
                ExtraPanel.Controls.Add(xo.namex);

                xo.imagex = new PictureBox();
                xo.imagex.Image = Image.FromStream(all_extra[i].MemS);
                xo.imagex.Location = new Point(BX1, BY2);
                xo.imagex.SizeMode = PictureBoxSizeMode.Zoom;
                xo.imagex.Size = new Size(280, 270);
                ExtraPanel.Controls.Add(xo.imagex);

                xo.decx = new PictureBox();
                xo.decx.Image = Properties.Resources.minus;
                xo.decx.Location = new Point(BX1, BY3);
                xo.decx.SizeMode = PictureBoxSizeMode.AutoSize;
                xo.decx.Cursor = Cursors.Hand;
                xo.decx.Click += new EventHandler(IncDecClick);
                ExtraPanel.Controls.Add(xo.decx);

                xo.quantityx = new Label();
                xo.quantityx.Text = "0";
                xo.quantityx.AutoSize = true;
                xo.quantityx.Font = new Font("HP Simplified", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                xo.quantityx.Location = new Point(BX2, BY4);
                ExtraPanel.Controls.Add(xo.quantityx);

                xo.incx = new PictureBox();
                xo.incx.Image = Properties.Resources.plus;
                xo.incx.Location = new Point(BX3, BY3);
                xo.incx.SizeMode = PictureBoxSizeMode.AutoSize;
                xo.incx.Cursor = Cursors.Hand;
                xo.incx.Click += new EventHandler(IncDecClick);
                ExtraPanel.Controls.Add(xo.incx);

                xo.pricex = new Label();
                xo.pricex.AutoSize = true;
                xo.pricex.Text = "$" + all_extra[i].Price.ToString();
                xo.pricex.Font = new Font("HP Simplified", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                xo.pricex.Location = new Point(BX4, BY3);
                ExtraPanel.Controls.Add(xo.pricex);

                xo.food = all_extra[i];

                BX1 += 355;
                BX2 += 355;
                BX3 += 355;
                BX4 += 355;

                SetMenus.Add(xo);
            }
        }

        private void AddAnOrder(Food food)
        {
            for (int i = 0; i < Order.Count; i++)
            {
                if (Order[i].COFood.Equals(food))
                {
                    Order[i].COQuantity++;
                    return;
                }
            }

            COList x = new COList(food, 1);
            Order.Add(x);
        }

        private void RemoveAnOrder(Food food)
        {
            for (int i = 0; i < Order.Count; i++)
            {
                if (Order[i].COFood.Equals(food))
                {
                    Order[i].COQuantity--;
                    if (Order[i].COQuantity.Equals(0))
                    {
                        Order.RemoveAt(i);
                    }
                    break;
                }
            }
        }

        private void CYTasteClick(object sender, EventArgs e)
        {
            CreateBurger cb = new CreateBurger(this);
            cb.Visible = true;
            this.Hide();
        }

        private void IncDecClick(object sender, EventArgs e)
        {
            PictureBox b = (PictureBox)sender;
            for (int i = 0; i < Burgers.Count; i++)
            {
                if (Burgers[i].incx.Equals(b))
                {
                    if (!Burgers[i].quantityx.Text.Equals("9"))
                    {
                        int c = Convert.ToInt32(Burgers[i].quantityx.Text) + 1;
                        Burgers[i].quantityx.Text = c.ToString();
                        cost += Burgers[i].food.Price;
                        CostLabel.Text = cost.ToString();
                        AddAnOrder(Burgers[i].food);
                        return;
                    }
                    else return;
                }
                else if (Burgers[i].decx.Equals(b))
                {
                    if (!Burgers[i].quantityx.Text.Equals("0"))
                    {
                        int c = Convert.ToInt32(Burgers[i].quantityx.Text) - 1;
                        Burgers[i].quantityx.Text = c.ToString();
                        cost -= Burgers[i].food.Price;
                        CostLabel.Text = cost.ToString();
                        RemoveAnOrder(Burgers[i].food);
                        return;
                    }
                    else return;
                }
            }

            for (int i = 0; i < Drinks.Count; i++)
            {
                if (Drinks[i].incx.Equals(b))
                {
                    if (!Drinks[i].quantityx.Text.Equals("9"))
                    {
                        int c = Convert.ToInt32(Drinks[i].quantityx.Text) + 1;
                        Drinks[i].quantityx.Text = c.ToString();
                        cost += Drinks[i].food.Price;
                        CostLabel.Text = cost.ToString();
                        AddAnOrder(Drinks[i].food);
                        return;
                    }
                    else return;
                }
                else if (Drinks[i].decx.Equals(b))
                {
                    if (!Drinks[i].quantityx.Text.Equals("0"))
                    {
                        int c = Convert.ToInt32(Drinks[i].quantityx.Text) - 1;
                        Drinks[i].quantityx.Text = c.ToString();
                        cost -= Drinks[i].food.Price;
                        CostLabel.Text = cost.ToString();
                        RemoveAnOrder(Drinks[i].food);
                        return;
                    }
                    else return;
                }
            }

            for (int i = 0; i < SetMenus.Count; i++)
            {
                if (SetMenus[i].incx.Equals(b))
                {
                    if (!SetMenus[i].quantityx.Text.Equals("9"))
                    {
                        int c = Convert.ToInt32(SetMenus[i].quantityx.Text) + 1;
                        SetMenus[i].quantityx.Text = c.ToString();
                        cost += SetMenus[i].food.Price;
                        CostLabel.Text = cost.ToString();
                        AddAnOrder(SetMenus[i].food);
                        return;
                    }
                    else return;
                }
                else if (SetMenus[i].decx.Equals(b))
                {
                    if (!SetMenus[i].quantityx.Text.Equals("0"))
                    {
                        int c = Convert.ToInt32(SetMenus[i].quantityx.Text) - 1;
                        SetMenus[i].quantityx.Text = c.ToString();
                        cost -= SetMenus[i].food.Price;
                        CostLabel.Text = cost.ToString();
                        RemoveAnOrder(SetMenus[i].food);
                        return;
                    }
                    else return;
                }
            }

            for (int i = 0; i < Desserts.Count; i++)
            {
                if (Desserts[i].incx.Equals(b))
                {
                    if (!Desserts[i].quantityx.Text.Equals("9"))
                    {
                        int c = Convert.ToInt32(Desserts[i].quantityx.Text) + 1;
                        Desserts[i].quantityx.Text = c.ToString();
                        cost += Desserts[i].food.Price;
                        CostLabel.Text = cost.ToString();
                        AddAnOrder(Desserts[i].food);
                        return;
                    }
                    else return;
                }
                else if (Desserts[i].decx.Equals(b))
                {
                    if (!Desserts[i].quantityx.Text.Equals("0"))
                    {
                        int c = Convert.ToInt32(Desserts[i].quantityx.Text) - 1;
                        Desserts[i].quantityx.Text = c.ToString();
                        cost -= Desserts[i].food.Price;
                        CostLabel.Text = cost.ToString();
                        RemoveAnOrder(Desserts[i].food);
                        return;
                    }
                    else return;
                }
            }

            for (int i = 0; i < Extras.Count; i++)
            {
                if (Extras[i].incx.Equals(b))
                {
                    if (!Extras[i].quantityx.Text.Equals("9"))
                    {
                        int c = Convert.ToInt32(Extras[i].quantityx.Text) + 1;
                        Extras[i].quantityx.Text = c.ToString();
                        cost += Extras[i].food.Price;
                        CostLabel.Text = cost.ToString();
                        AddAnOrder(Extras[i].food);
                        return;
                    }
                    else return;
                }
                else if (Extras[i].decx.Equals(b))
                {
                    if (!Extras[i].quantityx.Text.Equals("0"))
                    {
                        int c = Convert.ToInt32(Extras[i].quantityx.Text) - 1;
                        Extras[i].quantityx.Text = c.ToString();
                        cost -= Extras[i].food.Price;
                        CostLabel.Text = cost.ToString();
                        RemoveAnOrder(Extras[i].food);
                        return;
                    }
                    else return;
                }
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            SSPic2.Visible = false;
            SSTimer.Start();
        }

        private void QuickButtonClick(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuFlatButton button = (Bunifu.Framework.UI.BunifuFlatButton)sender;
            if (button.Equals(Cancel))
            {
                flag = false;
                payObj.Show();
                payObj.Opacity = 0.1;
                timer1.Start();
            }
            else if (button.Equals(Checkout))
            {
                if (cost != 0)
                {
                    string path = Environment.CurrentDirectory.ToString();
                    path = path.Remove(path.Length - 13);
                    path = path + @"DATABASE\MemoID.txt";
                    if (File.Exists(path))
                    {
                        string[] lines = { memID };
                        File.WriteAllLines(path, lines);
                    }

                    CheckOut ch = new CheckOut(eatWhere, payWhere, memID, Order);
                    ch.Show();
                    this.Hide();
                }
            }
            else
            {
                MyOrder myorder = new MyOrder(Order, this, memID);
                this.Enabled = Cancel.Visible = Checkout.Visible = MyOrderB.Visible = false;
                myorder.Show();
            }
        }

        private void FoodTabClick(object sender, EventArgs e)
        {
            Bunifu.Framework.UI.BunifuTileButton button = (Bunifu.Framework.UI.BunifuTileButton)sender;
            if (button.Equals(ComboMealTab))
            {
                BurgerPanel.Visible = DrinkPanel.Visible = CYBPanel.Visible = ExtraPanel.Visible = DessertPanel.Visible = false;
                ComboMealPanel.Visible = true;
            }
            else if (button.Equals(BurgerTab))
            {
                ComboMealPanel.Visible = DrinkPanel.Visible = CYBPanel.Visible = ExtraPanel.Visible = DessertPanel.Visible = false;
                BurgerPanel.Visible = true;
            }
            else if (button.Equals(DrinkTab))
            {
                BurgerPanel.Visible = ComboMealPanel.Visible = CYBPanel.Visible = ExtraPanel.Visible = DessertPanel.Visible = false;
                DrinkPanel.Visible = true;
            }
            else if (button.Equals(CreateBurgerTab))
            {
                BurgerPanel.Visible = ComboMealPanel.Visible = DrinkPanel.Visible = ExtraPanel.Visible = DessertPanel.Visible = false;
                CYBPanel.Visible = true;
            }
            else if (button.Equals(DessertTab))
            {
                BurgerPanel.Visible = ComboMealPanel.Visible = DrinkPanel.Visible = ExtraPanel.Visible = CYBPanel.Visible = false;
                DessertPanel.Visible = true;
            }
            else
            {
                BurgerPanel.Visible = ComboMealPanel.Visible = DrinkPanel.Visible = DessertPanel.Visible = CYBPanel.Visible = false;
                ExtraPanel.Visible = true;
            }
        }

        private void SSTimer_Tick(object sender, EventArgs e)
        {
            if (SSPic1.Visible)
            {
                SSPic1.Visible = false;
                SSPic2.Visible = true;
            }
            else if (SSPic2.Visible)
            {
                SSPic2.Visible = false;
                SSPic1.Visible = true;
            }
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
                    payObj.Hide();
                }
            }
            else
            {
                if (payObj.Opacity <= 0.9)
                {
                    payObj.Opacity += .35;
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
