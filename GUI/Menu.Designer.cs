namespace GUI
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.SSPic1 = new System.Windows.Forms.PictureBox();
            this.SSPic2 = new System.Windows.Forms.PictureBox();
            this.SSTimer = new System.Windows.Forms.Timer(this.components);
            this.BurgerPanel = new System.Windows.Forms.Panel();
            this.DrinkPanel = new System.Windows.Forms.Panel();
            this.ComboMealPanel = new System.Windows.Forms.Panel();
            this.MyOrderB = new Bunifu.Framework.UI.BunifuFlatButton();
            this.TotalCost = new System.Windows.Forms.Label();
            this.Cancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Checkout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.CostLabel = new System.Windows.Forms.Label();
            this.CYBPanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CYTaste = new Bunifu.Framework.UI.BunifuTileButton();
            this.ExtraTab = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DessertTab = new Bunifu.Framework.UI.BunifuTileButton();
            this.DrinkTab = new Bunifu.Framework.UI.BunifuTileButton();
            this.ComboMealTab = new Bunifu.Framework.UI.BunifuTileButton();
            this.BurgerTab = new Bunifu.Framework.UI.BunifuTileButton();
            this.CreateBurgerTab = new Bunifu.Framework.UI.BunifuTileButton();
            this.DessertPanel = new System.Windows.Forms.Panel();
            this.ExtraPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SSPic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSPic2)).BeginInit();
            this.CYBPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SSPic1);
            this.panel1.Controls.Add(this.SSPic2);
            this.panel1.Location = new System.Drawing.Point(291, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 257);
            this.panel1.TabIndex = 6;
            // 
            // SSPic1
            // 
            this.SSPic1.Image = global::GUI.Properties.Resources.ingredient_img1;
            this.SSPic1.Location = new System.Drawing.Point(-27, 0);
            this.SSPic1.Name = "SSPic1";
            this.SSPic1.Size = new System.Drawing.Size(1120, 251);
            this.SSPic1.TabIndex = 8;
            this.SSPic1.TabStop = false;
            // 
            // SSPic2
            // 
            this.SSPic2.Image = global::GUI.Properties.Resources.img_hashtag12;
            this.SSPic2.Location = new System.Drawing.Point(-8, 0);
            this.SSPic2.Name = "SSPic2";
            this.SSPic2.Size = new System.Drawing.Size(1100, 251);
            this.SSPic2.TabIndex = 7;
            this.SSPic2.TabStop = false;
            // 
            // SSTimer
            // 
            this.SSTimer.Interval = 3000;
            this.SSTimer.Tick += new System.EventHandler(this.SSTimer_Tick);
            // 
            // BurgerPanel
            // 
            this.BurgerPanel.AutoScroll = true;
            this.BurgerPanel.Location = new System.Drawing.Point(318, 273);
            this.BurgerPanel.Name = "BurgerPanel";
            this.BurgerPanel.Size = new System.Drawing.Size(1027, 381);
            this.BurgerPanel.TabIndex = 0;
            this.BurgerPanel.Visible = false;
            // 
            // DrinkPanel
            // 
            this.DrinkPanel.AutoScroll = true;
            this.DrinkPanel.Location = new System.Drawing.Point(318, 273);
            this.DrinkPanel.Name = "DrinkPanel";
            this.DrinkPanel.Size = new System.Drawing.Size(1027, 381);
            this.DrinkPanel.TabIndex = 7;
            this.DrinkPanel.Visible = false;
            // 
            // ComboMealPanel
            // 
            this.ComboMealPanel.AutoScroll = true;
            this.ComboMealPanel.Location = new System.Drawing.Point(318, 273);
            this.ComboMealPanel.Name = "ComboMealPanel";
            this.ComboMealPanel.Size = new System.Drawing.Size(1027, 381);
            this.ComboMealPanel.TabIndex = 8;
            this.ComboMealPanel.Visible = false;
            // 
            // MyOrderB
            // 
            this.MyOrderB.Activecolor = System.Drawing.Color.Black;
            this.MyOrderB.BackColor = System.Drawing.Color.Black;
            this.MyOrderB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MyOrderB.BorderRadius = 5;
            this.MyOrderB.ButtonText = "MY  ORDER";
            this.MyOrderB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MyOrderB.DisabledColor = System.Drawing.Color.Gray;
            this.MyOrderB.Font = new System.Drawing.Font("HP Simplified", 18F, System.Drawing.FontStyle.Bold);
            this.MyOrderB.ForeColor = System.Drawing.Color.White;
            this.MyOrderB.Iconcolor = System.Drawing.Color.Transparent;
            this.MyOrderB.Iconimage = null;
            this.MyOrderB.Iconimage_right = null;
            this.MyOrderB.Iconimage_right_Selected = null;
            this.MyOrderB.Iconimage_Selected = null;
            this.MyOrderB.IconMarginLeft = 0;
            this.MyOrderB.IconMarginRight = 0;
            this.MyOrderB.IconRightVisible = true;
            this.MyOrderB.IconRightZoom = 0D;
            this.MyOrderB.IconVisible = true;
            this.MyOrderB.IconZoom = 90D;
            this.MyOrderB.IsTab = false;
            this.MyOrderB.Location = new System.Drawing.Point(943, 682);
            this.MyOrderB.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MyOrderB.Name = "MyOrderB";
            this.MyOrderB.Normalcolor = System.Drawing.Color.Black;
            this.MyOrderB.OnHovercolor = System.Drawing.Color.Black;
            this.MyOrderB.OnHoverTextColor = System.Drawing.Color.White;
            this.MyOrderB.selected = false;
            this.MyOrderB.Size = new System.Drawing.Size(192, 63);
            this.MyOrderB.TabIndex = 26;
            this.MyOrderB.Text = "MY  ORDER";
            this.MyOrderB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MyOrderB.Textcolor = System.Drawing.Color.White;
            this.MyOrderB.TextFont = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold);
            this.MyOrderB.Click += new System.EventHandler(this.QuickButtonClick);
            // 
            // TotalCost
            // 
            this.TotalCost.AutoSize = true;
            this.TotalCost.Font = new System.Drawing.Font("HP Simplified", 22F, System.Drawing.FontStyle.Bold);
            this.TotalCost.Location = new System.Drawing.Point(319, 700);
            this.TotalCost.Name = "TotalCost";
            this.TotalCost.Size = new System.Drawing.Size(130, 36);
            this.TotalCost.TabIndex = 27;
            this.TotalCost.Text = "TOTAL : $";
            // 
            // Cancel
            // 
            this.Cancel.Activecolor = System.Drawing.Color.Black;
            this.Cancel.BackColor = System.Drawing.Color.Black;
            this.Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cancel.BorderRadius = 5;
            this.Cancel.ButtonText = "CANCEL";
            this.Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel.DisabledColor = System.Drawing.Color.Gray;
            this.Cancel.Font = new System.Drawing.Font("HP Simplified", 18F, System.Drawing.FontStyle.Bold);
            this.Cancel.ForeColor = System.Drawing.Color.White;
            this.Cancel.Iconcolor = System.Drawing.Color.Transparent;
            this.Cancel.Iconimage = null;
            this.Cancel.Iconimage_right = null;
            this.Cancel.Iconimage_right_Selected = null;
            this.Cancel.Iconimage_Selected = null;
            this.Cancel.IconMarginLeft = 0;
            this.Cancel.IconMarginRight = 0;
            this.Cancel.IconRightVisible = true;
            this.Cancel.IconRightZoom = 0D;
            this.Cancel.IconVisible = true;
            this.Cancel.IconZoom = 90D;
            this.Cancel.IsTab = false;
            this.Cancel.Location = new System.Drawing.Point(736, 682);
            this.Cancel.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Cancel.Name = "Cancel";
            this.Cancel.Normalcolor = System.Drawing.Color.Black;
            this.Cancel.OnHovercolor = System.Drawing.Color.Black;
            this.Cancel.OnHoverTextColor = System.Drawing.Color.White;
            this.Cancel.selected = false;
            this.Cancel.Size = new System.Drawing.Size(192, 63);
            this.Cancel.TabIndex = 28;
            this.Cancel.Text = "CANCEL";
            this.Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cancel.Textcolor = System.Drawing.Color.White;
            this.Cancel.TextFont = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold);
            this.Cancel.Click += new System.EventHandler(this.QuickButtonClick);
            // 
            // Checkout
            // 
            this.Checkout.Activecolor = System.Drawing.Color.Black;
            this.Checkout.BackColor = System.Drawing.Color.Black;
            this.Checkout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Checkout.BorderRadius = 5;
            this.Checkout.ButtonText = "CHECK  OUT";
            this.Checkout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Checkout.DisabledColor = System.Drawing.Color.Gray;
            this.Checkout.Font = new System.Drawing.Font("HP Simplified", 18F, System.Drawing.FontStyle.Bold);
            this.Checkout.ForeColor = System.Drawing.Color.White;
            this.Checkout.Iconcolor = System.Drawing.Color.Transparent;
            this.Checkout.Iconimage = null;
            this.Checkout.Iconimage_right = null;
            this.Checkout.Iconimage_right_Selected = null;
            this.Checkout.Iconimage_Selected = null;
            this.Checkout.IconMarginLeft = 0;
            this.Checkout.IconMarginRight = 0;
            this.Checkout.IconRightVisible = true;
            this.Checkout.IconRightZoom = 0D;
            this.Checkout.IconVisible = true;
            this.Checkout.IconZoom = 90D;
            this.Checkout.IsTab = false;
            this.Checkout.Location = new System.Drawing.Point(1150, 682);
            this.Checkout.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Checkout.Name = "Checkout";
            this.Checkout.Normalcolor = System.Drawing.Color.Black;
            this.Checkout.OnHovercolor = System.Drawing.Color.Black;
            this.Checkout.OnHoverTextColor = System.Drawing.Color.White;
            this.Checkout.selected = false;
            this.Checkout.Size = new System.Drawing.Size(192, 63);
            this.Checkout.TabIndex = 29;
            this.Checkout.Text = "CHECK  OUT";
            this.Checkout.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Checkout.Textcolor = System.Drawing.Color.White;
            this.Checkout.TextFont = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold);
            this.Checkout.Click += new System.EventHandler(this.QuickButtonClick);
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("HP Simplified", 22F, System.Drawing.FontStyle.Bold);
            this.CostLabel.Location = new System.Drawing.Point(439, 700);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(31, 36);
            this.CostLabel.TabIndex = 30;
            this.CostLabel.Text = "0";
            // 
            // CYBPanel
            // 
            this.CYBPanel.AutoScroll = true;
            this.CYBPanel.Controls.Add(this.pictureBox2);
            this.CYBPanel.Controls.Add(this.pictureBox1);
            this.CYBPanel.Controls.Add(this.CYTaste);
            this.CYBPanel.Location = new System.Drawing.Point(318, 273);
            this.CYBPanel.Name = "CYBPanel";
            this.CYBPanel.Size = new System.Drawing.Size(1027, 381);
            this.CYBPanel.TabIndex = 31;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources.knife_and_fork_icon_png_24;
            this.pictureBox2.Location = new System.Drawing.Point(692, 105);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(102, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.knife_and_fork_icon_png_24;
            this.pictureBox1.Location = new System.Drawing.Point(228, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(102, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // CYTaste
            // 
            this.CYTaste.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CYTaste.color = System.Drawing.SystemColors.ButtonHighlight;
            this.CYTaste.colorActive = System.Drawing.SystemColors.ButtonHighlight;
            this.CYTaste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CYTaste.Font = new System.Drawing.Font("Vladimir Script", 42F, System.Drawing.FontStyle.Bold);
            this.CYTaste.ForeColor = System.Drawing.Color.Black;
            this.CYTaste.Image = global::GUI.Properties.Resources.Create_Your_Taste;
            this.CYTaste.ImagePosition = 27;
            this.CYTaste.ImageZoom = 60;
            this.CYTaste.LabelPosition = 69;
            this.CYTaste.LabelText = "Create your taste ! ";
            this.CYTaste.Location = new System.Drawing.Point(329, 6);
            this.CYTaste.Margin = new System.Windows.Forms.Padding(6);
            this.CYTaste.Name = "CYTaste";
            this.CYTaste.Size = new System.Drawing.Size(362, 318);
            this.CYTaste.TabIndex = 2;
            this.CYTaste.TabStop = false;
            this.CYTaste.Click += new System.EventHandler(this.CYTasteClick);
            // 
            // ExtraTab
            // 
            this.ExtraTab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExtraTab.color = System.Drawing.SystemColors.ButtonHighlight;
            this.ExtraTab.colorActive = System.Drawing.SystemColors.ButtonHighlight;
            this.ExtraTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExtraTab.Font = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraTab.ForeColor = System.Drawing.Color.Black;
            this.ExtraTab.Image = global::GUI.Properties.Resources.mcd_meals_chicken_mcnuggets;
            this.ExtraTab.ImagePosition = 5;
            this.ExtraTab.ImageZoom = 90;
            this.ExtraTab.LabelPosition = 85;
            this.ExtraTab.LabelText = "EXTRAS";
            this.ExtraTab.Location = new System.Drawing.Point(0, 1438);
            this.ExtraTab.Margin = new System.Windows.Forms.Padding(6);
            this.ExtraTab.Name = "ExtraTab";
            this.ExtraTab.Size = new System.Drawing.Size(270, 322);
            this.ExtraTab.TabIndex = 32;
            this.ExtraTab.TabStop = false;
            this.ExtraTab.Click += new System.EventHandler(this.FoodTabClick);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.AutoScroll = true;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.ExtraTab);
            this.bunifuGradientPanel1.Controls.Add(this.DessertTab);
            this.bunifuGradientPanel1.Controls.Add(this.DrinkTab);
            this.bunifuGradientPanel1.Controls.Add(this.ComboMealTab);
            this.bunifuGradientPanel1.Controls.Add(this.BurgerTab);
            this.bunifuGradientPanel1.Controls.Add(this.CreateBurgerTab);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(290, 788);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // DessertTab
            // 
            this.DessertTab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DessertTab.color = System.Drawing.SystemColors.ButtonHighlight;
            this.DessertTab.colorActive = System.Drawing.SystemColors.ButtonHighlight;
            this.DessertTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DessertTab.Font = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DessertTab.ForeColor = System.Drawing.Color.Black;
            this.DessertTab.Image = global::GUI.Properties.Resources.Desserts;
            this.DessertTab.ImagePosition = 5;
            this.DessertTab.ImageZoom = 95;
            this.DessertTab.LabelPosition = 85;
            this.DessertTab.LabelText = "DESSERTS";
            this.DessertTab.Location = new System.Drawing.Point(0, 1145);
            this.DessertTab.Margin = new System.Windows.Forms.Padding(6);
            this.DessertTab.Name = "DessertTab";
            this.DessertTab.Size = new System.Drawing.Size(270, 322);
            this.DessertTab.TabIndex = 0;
            this.DessertTab.TabStop = false;
            this.DessertTab.Click += new System.EventHandler(this.FoodTabClick);
            // 
            // DrinkTab
            // 
            this.DrinkTab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DrinkTab.color = System.Drawing.SystemColors.ButtonHighlight;
            this.DrinkTab.colorActive = System.Drawing.SystemColors.ButtonHighlight;
            this.DrinkTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DrinkTab.Font = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrinkTab.ForeColor = System.Drawing.Color.Black;
            this.DrinkTab.Image = global::GUI.Properties.Resources.beveimg01;
            this.DrinkTab.ImagePosition = -20;
            this.DrinkTab.ImageZoom = 105;
            this.DrinkTab.LabelPosition = 85;
            this.DrinkTab.LabelText = "DRINKS";
            this.DrinkTab.Location = new System.Drawing.Point(0, 831);
            this.DrinkTab.Margin = new System.Windows.Forms.Padding(6);
            this.DrinkTab.Name = "DrinkTab";
            this.DrinkTab.Size = new System.Drawing.Size(270, 322);
            this.DrinkTab.TabIndex = 4;
            this.DrinkTab.TabStop = false;
            this.DrinkTab.Click += new System.EventHandler(this.FoodTabClick);
            // 
            // ComboMealTab
            // 
            this.ComboMealTab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ComboMealTab.color = System.Drawing.SystemColors.ButtonHighlight;
            this.ComboMealTab.colorActive = System.Drawing.SystemColors.ButtonHighlight;
            this.ComboMealTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComboMealTab.Font = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboMealTab.ForeColor = System.Drawing.Color.Black;
            this.ComboMealTab.Image = global::GUI.Properties.Resources.BigMac435X320__1_;
            this.ComboMealTab.ImagePosition = -20;
            this.ComboMealTab.ImageZoom = 100;
            this.ComboMealTab.LabelPosition = 50;
            this.ComboMealTab.LabelText = "COMBO MEAL";
            this.ComboMealTab.Location = new System.Drawing.Point(0, 322);
            this.ComboMealTab.Margin = new System.Windows.Forms.Padding(6);
            this.ComboMealTab.Name = "ComboMealTab";
            this.ComboMealTab.Size = new System.Drawing.Size(270, 270);
            this.ComboMealTab.TabIndex = 2;
            this.ComboMealTab.TabStop = false;
            this.ComboMealTab.Click += new System.EventHandler(this.FoodTabClick);
            // 
            // BurgerTab
            // 
            this.BurgerTab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BurgerTab.color = System.Drawing.SystemColors.ButtonHighlight;
            this.BurgerTab.colorActive = System.Drawing.SystemColors.ButtonHighlight;
            this.BurgerTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BurgerTab.Font = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BurgerTab.ForeColor = System.Drawing.Color.Black;
            this.BurgerTab.Image = global::GUI.Properties.Resources.wienerschnitzel_new_bigger_burgers;
            this.BurgerTab.ImagePosition = -20;
            this.BurgerTab.ImageZoom = 105;
            this.BurgerTab.LabelPosition = 70;
            this.BurgerTab.LabelText = "BURGERS";
            this.BurgerTab.Location = new System.Drawing.Point(0, 566);
            this.BurgerTab.Margin = new System.Windows.Forms.Padding(6);
            this.BurgerTab.Name = "BurgerTab";
            this.BurgerTab.Size = new System.Drawing.Size(270, 270);
            this.BurgerTab.TabIndex = 3;
            this.BurgerTab.TabStop = false;
            this.BurgerTab.Click += new System.EventHandler(this.FoodTabClick);
            // 
            // CreateBurgerTab
            // 
            this.CreateBurgerTab.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CreateBurgerTab.color = System.Drawing.SystemColors.ButtonHighlight;
            this.CreateBurgerTab.colorActive = System.Drawing.SystemColors.ButtonHighlight;
            this.CreateBurgerTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CreateBurgerTab.Font = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBurgerTab.ForeColor = System.Drawing.Color.Black;
            this.CreateBurgerTab.Image = global::GUI.Properties.Resources.Create_Your_Taste;
            this.CreateBurgerTab.ImagePosition = 24;
            this.CreateBurgerTab.ImageZoom = 70;
            this.CreateBurgerTab.LabelPosition = 50;
            this.CreateBurgerTab.LabelText = "CREATE BURGER";
            this.CreateBurgerTab.Location = new System.Drawing.Point(0, 26);
            this.CreateBurgerTab.Margin = new System.Windows.Forms.Padding(6);
            this.CreateBurgerTab.Name = "CreateBurgerTab";
            this.CreateBurgerTab.Size = new System.Drawing.Size(270, 270);
            this.CreateBurgerTab.TabIndex = 1;
            this.CreateBurgerTab.TabStop = false;
            this.CreateBurgerTab.Click += new System.EventHandler(this.FoodTabClick);
            // 
            // DessertPanel
            // 
            this.DessertPanel.AutoScroll = true;
            this.DessertPanel.Location = new System.Drawing.Point(318, 273);
            this.DessertPanel.Name = "DessertPanel";
            this.DessertPanel.Size = new System.Drawing.Size(1027, 381);
            this.DessertPanel.TabIndex = 32;
            this.DessertPanel.Visible = false;
            // 
            // ExtraPanel
            // 
            this.ExtraPanel.AutoScroll = true;
            this.ExtraPanel.Location = new System.Drawing.Point(318, 273);
            this.ExtraPanel.Name = "ExtraPanel";
            this.ExtraPanel.Size = new System.Drawing.Size(1027, 381);
            this.ExtraPanel.TabIndex = 33;
            this.ExtraPanel.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.ExtraPanel);
            this.Controls.Add(this.DessertPanel);
            this.Controls.Add(this.CYBPanel);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.Checkout);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.TotalCost);
            this.Controls.Add(this.MyOrderB);
            this.Controls.Add(this.ComboMealPanel);
            this.Controls.Add(this.DrinkPanel);
            this.Controls.Add(this.BurgerPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SSPic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SSPic2)).EndInit();
            this.CYBPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuTileButton CreateBurgerTab;
        private Bunifu.Framework.UI.BunifuTileButton BurgerTab;
        private Bunifu.Framework.UI.BunifuTileButton ComboMealTab;
        private Bunifu.Framework.UI.BunifuTileButton DrinkTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox SSPic2;
        private System.Windows.Forms.PictureBox SSPic1;
        private System.Windows.Forms.Timer SSTimer;
        private System.Windows.Forms.Panel BurgerPanel;
        private System.Windows.Forms.Panel DrinkPanel;
        private System.Windows.Forms.Panel ComboMealPanel;
        private Bunifu.Framework.UI.BunifuFlatButton MyOrderB;
        private System.Windows.Forms.Label TotalCost;
        private Bunifu.Framework.UI.BunifuFlatButton Cancel;
        private Bunifu.Framework.UI.BunifuFlatButton Checkout;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Panel CYBPanel;
        private Bunifu.Framework.UI.BunifuTileButton CYTaste;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuTileButton DessertTab;
        private Bunifu.Framework.UI.BunifuTileButton ExtraTab;
        private System.Windows.Forms.Panel DessertPanel;
        private System.Windows.Forms.Panel ExtraPanel;
        private System.Windows.Forms.Timer timer1;
    }
}