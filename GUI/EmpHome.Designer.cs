namespace GUI
{
    partial class EmpHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpHome));
            this.Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.NLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.UNLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.IDLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LogOut = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.DeleteFood = new Bunifu.Framework.UI.BunifuFlatButton();
            this.InsertFood = new Bunifu.Framework.UI.BunifuFlatButton();
            this.FoodUpdate = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.View = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Sell = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FoodQueryLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.LogOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("HP Simplified", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(36, 189);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(175, 41);
            this.Title.TabIndex = 19;
            this.Title.Text = "EMPLOYEE";
            // 
            // NLabel
            // 
            this.NLabel.AutoSize = true;
            this.NLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.NLabel.Font = new System.Drawing.Font("HP Simplified", 17F, System.Drawing.FontStyle.Bold);
            this.NLabel.ForeColor = System.Drawing.Color.White;
            this.NLabel.Location = new System.Drawing.Point(263, 59);
            this.NLabel.Name = "NLabel";
            this.NLabel.Size = new System.Drawing.Size(67, 27);
            this.NLabel.TabIndex = 21;
            this.NLabel.Text = "Name";
            // 
            // DLabel
            // 
            this.DLabel.AutoSize = true;
            this.DLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.DLabel.Font = new System.Drawing.Font("HP Simplified", 17F, System.Drawing.FontStyle.Bold);
            this.DLabel.ForeColor = System.Drawing.Color.White;
            this.DLabel.Location = new System.Drawing.Point(263, 119);
            this.DLabel.Name = "DLabel";
            this.DLabel.Size = new System.Drawing.Size(127, 27);
            this.DLabel.TabIndex = 22;
            this.DLabel.Text = "Designation";
            // 
            // UNLabel
            // 
            this.UNLabel.AutoSize = true;
            this.UNLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.UNLabel.Font = new System.Drawing.Font("HP Simplified", 17F, System.Drawing.FontStyle.Bold);
            this.UNLabel.ForeColor = System.Drawing.Color.White;
            this.UNLabel.Location = new System.Drawing.Point(263, 89);
            this.UNLabel.Name = "UNLabel";
            this.UNLabel.Size = new System.Drawing.Size(32, 27);
            this.UNLabel.TabIndex = 23;
            this.UNLabel.Text = "@";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.IDLabel.Font = new System.Drawing.Font("HP Simplified", 17F, System.Drawing.FontStyle.Bold);
            this.IDLabel.ForeColor = System.Drawing.Color.White;
            this.IDLabel.Location = new System.Drawing.Point(263, 149);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(42, 27);
            this.IDLabel.TabIndex = 24;
            this.IDLabel.Text = "ID: ";
            // 
            // LogOut
            // 
            this.LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOut.Image = global::GUI.Properties.Resources.Log_Out;
            this.LogOut.Location = new System.Drawing.Point(1273, 681);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(50, 50);
            this.LogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.LogOut.TabIndex = 30;
            this.LogOut.TabStop = false;
            this.LogOut.Click += new System.EventHandler(this.LogOutClick);
            // 
            // Logo
            // 
            this.Logo.Image = global::GUI.Properties.Resources.images1;
            this.Logo.Location = new System.Drawing.Point(21, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(200, 188);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Logo.TabIndex = 18;
            this.Logo.TabStop = false;
            // 
            // DeleteFood
            // 
            this.DeleteFood.Activecolor = System.Drawing.Color.White;
            this.DeleteFood.BackColor = System.Drawing.Color.White;
            this.DeleteFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteFood.BorderRadius = 5;
            this.DeleteFood.ButtonText = "DELETE";
            this.DeleteFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteFood.DisabledColor = System.Drawing.Color.Gray;
            this.DeleteFood.Font = new System.Drawing.Font("HP Simplified", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteFood.ForeColor = System.Drawing.Color.Black;
            this.DeleteFood.Iconcolor = System.Drawing.Color.Transparent;
            this.DeleteFood.Iconimage = null;
            this.DeleteFood.Iconimage_right = null;
            this.DeleteFood.Iconimage_right_Selected = null;
            this.DeleteFood.Iconimage_Selected = null;
            this.DeleteFood.IconMarginLeft = 0;
            this.DeleteFood.IconMarginRight = 0;
            this.DeleteFood.IconRightVisible = true;
            this.DeleteFood.IconRightZoom = 0D;
            this.DeleteFood.IconVisible = true;
            this.DeleteFood.IconZoom = 90D;
            this.DeleteFood.IsTab = false;
            this.DeleteFood.Location = new System.Drawing.Point(503, 395);
            this.DeleteFood.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.DeleteFood.Name = "DeleteFood";
            this.DeleteFood.Normalcolor = System.Drawing.Color.White;
            this.DeleteFood.OnHovercolor = System.Drawing.Color.White;
            this.DeleteFood.OnHoverTextColor = System.Drawing.Color.Black;
            this.DeleteFood.selected = false;
            this.DeleteFood.Size = new System.Drawing.Size(180, 72);
            this.DeleteFood.TabIndex = 38;
            this.DeleteFood.Text = "DELETE";
            this.DeleteFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteFood.Textcolor = System.Drawing.Color.Black;
            this.DeleteFood.TextFont = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold);
            this.DeleteFood.Click += new System.EventHandler(this.FoodQueryButtonClick);
            // 
            // InsertFood
            // 
            this.InsertFood.Activecolor = System.Drawing.Color.White;
            this.InsertFood.BackColor = System.Drawing.Color.White;
            this.InsertFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.InsertFood.BorderRadius = 5;
            this.InsertFood.ButtonText = "INSERT";
            this.InsertFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertFood.DisabledColor = System.Drawing.Color.Gray;
            this.InsertFood.Font = new System.Drawing.Font("HP Simplified", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertFood.ForeColor = System.Drawing.Color.Black;
            this.InsertFood.Iconcolor = System.Drawing.Color.Transparent;
            this.InsertFood.Iconimage = null;
            this.InsertFood.Iconimage_right = null;
            this.InsertFood.Iconimage_right_Selected = null;
            this.InsertFood.Iconimage_Selected = null;
            this.InsertFood.IconMarginLeft = 0;
            this.InsertFood.IconMarginRight = 0;
            this.InsertFood.IconRightVisible = true;
            this.InsertFood.IconRightZoom = 0D;
            this.InsertFood.IconVisible = true;
            this.InsertFood.IconZoom = 90D;
            this.InsertFood.IsTab = false;
            this.InsertFood.Location = new System.Drawing.Point(503, 281);
            this.InsertFood.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.InsertFood.Name = "InsertFood";
            this.InsertFood.Normalcolor = System.Drawing.Color.White;
            this.InsertFood.OnHovercolor = System.Drawing.Color.White;
            this.InsertFood.OnHoverTextColor = System.Drawing.Color.Black;
            this.InsertFood.selected = false;
            this.InsertFood.Size = new System.Drawing.Size(180, 72);
            this.InsertFood.TabIndex = 37;
            this.InsertFood.Text = "INSERT";
            this.InsertFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.InsertFood.Textcolor = System.Drawing.Color.Black;
            this.InsertFood.TextFont = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold);
            this.InsertFood.Click += new System.EventHandler(this.FoodQueryButtonClick);
            // 
            // FoodUpdate
            // 
            this.FoodUpdate.Activecolor = System.Drawing.Color.White;
            this.FoodUpdate.BackColor = System.Drawing.Color.White;
            this.FoodUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FoodUpdate.BorderRadius = 5;
            this.FoodUpdate.ButtonText = "UPDATE";
            this.FoodUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FoodUpdate.DisabledColor = System.Drawing.Color.Gray;
            this.FoodUpdate.Font = new System.Drawing.Font("HP Simplified", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodUpdate.ForeColor = System.Drawing.Color.Black;
            this.FoodUpdate.Iconcolor = System.Drawing.Color.Transparent;
            this.FoodUpdate.Iconimage = null;
            this.FoodUpdate.Iconimage_right = null;
            this.FoodUpdate.Iconimage_right_Selected = null;
            this.FoodUpdate.Iconimage_Selected = null;
            this.FoodUpdate.IconMarginLeft = 0;
            this.FoodUpdate.IconMarginRight = 0;
            this.FoodUpdate.IconRightVisible = true;
            this.FoodUpdate.IconRightZoom = 0D;
            this.FoodUpdate.IconVisible = true;
            this.FoodUpdate.IconZoom = 90D;
            this.FoodUpdate.IsTab = false;
            this.FoodUpdate.Location = new System.Drawing.Point(728, 281);
            this.FoodUpdate.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.FoodUpdate.Name = "FoodUpdate";
            this.FoodUpdate.Normalcolor = System.Drawing.Color.White;
            this.FoodUpdate.OnHovercolor = System.Drawing.Color.White;
            this.FoodUpdate.OnHoverTextColor = System.Drawing.Color.Black;
            this.FoodUpdate.selected = false;
            this.FoodUpdate.Size = new System.Drawing.Size(180, 72);
            this.FoodUpdate.TabIndex = 36;
            this.FoodUpdate.Text = "UPDATE";
            this.FoodUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.FoodUpdate.Textcolor = System.Drawing.Color.Black;
            this.FoodUpdate.TextFont = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold);
            this.FoodUpdate.Click += new System.EventHandler(this.FoodQueryButtonClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // View
            // 
            this.View.Activecolor = System.Drawing.Color.White;
            this.View.BackColor = System.Drawing.Color.White;
            this.View.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.View.BorderRadius = 5;
            this.View.ButtonText = "VIEW";
            this.View.Cursor = System.Windows.Forms.Cursors.Hand;
            this.View.DisabledColor = System.Drawing.Color.Gray;
            this.View.Font = new System.Drawing.Font("HP Simplified", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.View.ForeColor = System.Drawing.Color.Black;
            this.View.Iconcolor = System.Drawing.Color.Transparent;
            this.View.Iconimage = null;
            this.View.Iconimage_right = null;
            this.View.Iconimage_right_Selected = null;
            this.View.Iconimage_Selected = null;
            this.View.IconMarginLeft = 0;
            this.View.IconMarginRight = 0;
            this.View.IconRightVisible = true;
            this.View.IconRightZoom = 0D;
            this.View.IconVisible = true;
            this.View.IconZoom = 90D;
            this.View.IsTab = false;
            this.View.Location = new System.Drawing.Point(728, 395);
            this.View.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.View.Name = "View";
            this.View.Normalcolor = System.Drawing.Color.White;
            this.View.OnHovercolor = System.Drawing.Color.White;
            this.View.OnHoverTextColor = System.Drawing.Color.Black;
            this.View.selected = false;
            this.View.Size = new System.Drawing.Size(180, 72);
            this.View.TabIndex = 40;
            this.View.Text = "VIEW";
            this.View.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.View.Textcolor = System.Drawing.Color.Black;
            this.View.TextFont = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold);
            this.View.Click += new System.EventHandler(this.FoodQueryButtonClick);
            // 
            // Sell
            // 
            this.Sell.Activecolor = System.Drawing.Color.White;
            this.Sell.BackColor = System.Drawing.Color.White;
            this.Sell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Sell.BorderRadius = 5;
            this.Sell.ButtonText = "SELL";
            this.Sell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sell.DisabledColor = System.Drawing.Color.Gray;
            this.Sell.Font = new System.Drawing.Font("HP Simplified", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sell.ForeColor = System.Drawing.Color.Black;
            this.Sell.Iconcolor = System.Drawing.Color.Transparent;
            this.Sell.Iconimage = null;
            this.Sell.Iconimage_right = null;
            this.Sell.Iconimage_right_Selected = null;
            this.Sell.Iconimage_Selected = null;
            this.Sell.IconMarginLeft = 0;
            this.Sell.IconMarginRight = 0;
            this.Sell.IconRightVisible = true;
            this.Sell.IconRightZoom = 0D;
            this.Sell.IconVisible = true;
            this.Sell.IconZoom = 90D;
            this.Sell.IsTab = false;
            this.Sell.Location = new System.Drawing.Point(613, 609);
            this.Sell.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Sell.Name = "Sell";
            this.Sell.Normalcolor = System.Drawing.Color.White;
            this.Sell.OnHovercolor = System.Drawing.Color.White;
            this.Sell.OnHoverTextColor = System.Drawing.Color.Black;
            this.Sell.selected = false;
            this.Sell.Size = new System.Drawing.Size(180, 72);
            this.Sell.TabIndex = 41;
            this.Sell.Text = "SELL";
            this.Sell.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Sell.Textcolor = System.Drawing.Color.Black;
            this.Sell.TextFont = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold);
            this.Sell.Click += new System.EventHandler(this.FoodQueryButtonClick);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("HP Simplified", 30F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(608, 544);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(197, 46);
            this.bunifuCustomLabel1.TabIndex = 42;
            this.bunifuCustomLabel1.Text = "APPROVAL";
            // 
            // FoodQueryLabel
            // 
            this.FoodQueryLabel.AutoSize = true;
            this.FoodQueryLabel.Font = new System.Drawing.Font("HP Simplified", 30F, System.Drawing.FontStyle.Bold);
            this.FoodQueryLabel.ForeColor = System.Drawing.Color.White;
            this.FoodQueryLabel.Location = new System.Drawing.Point(584, 209);
            this.FoodQueryLabel.Name = "FoodQueryLabel";
            this.FoodQueryLabel.Size = new System.Drawing.Size(252, 46);
            this.FoodQueryLabel.TabIndex = 35;
            this.FoodQueryLabel.Text = "FOOD  QUERY ";
            // 
            // EmpHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.Sell);
            this.Controls.Add(this.View);
            this.Controls.Add(this.DeleteFood);
            this.Controls.Add(this.InsertFood);
            this.Controls.Add(this.FoodUpdate);
            this.Controls.Add(this.FoodQueryLabel);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.UNLabel);
            this.Controls.Add(this.DLabel);
            this.Controls.Add(this.NLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmpHome";
            this.Text = "EmpHome";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmpHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel Title;
        private System.Windows.Forms.PictureBox Logo;
        private Bunifu.Framework.UI.BunifuCustomLabel NLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel DLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel UNLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel IDLabel;
        private System.Windows.Forms.PictureBox LogOut;
        private Bunifu.Framework.UI.BunifuFlatButton DeleteFood;
        private Bunifu.Framework.UI.BunifuFlatButton InsertFood;
        private Bunifu.Framework.UI.BunifuFlatButton FoodUpdate;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuFlatButton View;
        private Bunifu.Framework.UI.BunifuFlatButton Sell;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel FoodQueryLabel;
    }
}