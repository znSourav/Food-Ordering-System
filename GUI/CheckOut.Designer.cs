namespace GUI
{
    partial class CheckOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckOut));
            this.Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Panelx = new System.Windows.Forms.Panel();
            this.L3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.L2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.L1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PriceL = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Qty = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Item = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Label12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Proc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CL1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Panelx.SuspendLayout();
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
            this.Title.TabIndex = 23;
            this.Title.Text = "CHECKOUT";
            // 
            // Panelx
            // 
            this.Panelx.AutoScroll = true;
            this.Panelx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Panelx.Controls.Add(this.L3);
            this.Panelx.Controls.Add(this.L2);
            this.Panelx.Controls.Add(this.L1);
            this.Panelx.Controls.Add(this.PriceL);
            this.Panelx.Controls.Add(this.Qty);
            this.Panelx.Controls.Add(this.Item);
            this.Panelx.Location = new System.Drawing.Point(272, 228);
            this.Panelx.Name = "Panelx";
            this.Panelx.Size = new System.Drawing.Size(874, 342);
            this.Panelx.TabIndex = 24;
            // 
            // L3
            // 
            this.L3.AutoSize = true;
            this.L3.Font = new System.Drawing.Font("HP Simplified", 15F);
            this.L3.ForeColor = System.Drawing.Color.White;
            this.L3.Location = new System.Drawing.Point(761, 52);
            this.L3.Name = "L3";
            this.L3.Size = new System.Drawing.Size(43, 24);
            this.L3.TabIndex = 0;
            this.L3.Text = "$25";
            // 
            // L2
            // 
            this.L2.AutoSize = true;
            this.L2.Font = new System.Drawing.Font("HP Simplified", 15F);
            this.L2.ForeColor = System.Drawing.Color.White;
            this.L2.Location = new System.Drawing.Point(566, 52);
            this.L2.Name = "L2";
            this.L2.Size = new System.Drawing.Size(32, 24);
            this.L2.TabIndex = 28;
            this.L2.Text = "25";
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("HP Simplified", 15F);
            this.L1.ForeColor = System.Drawing.Color.White;
            this.L1.Location = new System.Drawing.Point(5, 52);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(147, 24);
            this.L1.TabIndex = 27;
            this.L1.Text = "Mc Maharaja Mac";
            // 
            // PriceL
            // 
            this.PriceL.AutoSize = true;
            this.PriceL.Font = new System.Drawing.Font("HP Simplified", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceL.ForeColor = System.Drawing.Color.White;
            this.PriceL.Location = new System.Drawing.Point(728, 0);
            this.PriceL.Name = "PriceL";
            this.PriceL.Size = new System.Drawing.Size(104, 41);
            this.PriceL.TabIndex = 26;
            this.PriceL.Text = "PRICE";
            // 
            // Qty
            // 
            this.Qty.AutoSize = true;
            this.Qty.Font = new System.Drawing.Font("HP Simplified", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Qty.ForeColor = System.Drawing.Color.White;
            this.Qty.Location = new System.Drawing.Point(542, 0);
            this.Qty.Name = "Qty";
            this.Qty.Size = new System.Drawing.Size(79, 41);
            this.Qty.TabIndex = 25;
            this.Qty.Text = "QTY";
            // 
            // Item
            // 
            this.Item.AutoSize = true;
            this.Item.Font = new System.Drawing.Font("HP Simplified", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item.ForeColor = System.Drawing.Color.White;
            this.Item.Location = new System.Drawing.Point(49, 0);
            this.Item.Name = "Item";
            this.Item.Size = new System.Drawing.Size(92, 41);
            this.Item.TabIndex = 24;
            this.Item.Text = "ITEM";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("HP Simplified", 45F, System.Drawing.FontStyle.Bold);
            this.Label12.ForeColor = System.Drawing.Color.White;
            this.Label12.Location = new System.Drawing.Point(568, 106);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(304, 69);
            this.Label12.TabIndex = 25;
            this.Label12.Text = "MY  ORDER";
            // 
            // Proc
            // 
            this.Proc.Activecolor = System.Drawing.Color.White;
            this.Proc.BackColor = System.Drawing.Color.White;
            this.Proc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Proc.BorderRadius = 5;
            this.Proc.ButtonText = "PRINT SLIP";
            this.Proc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Proc.DisabledColor = System.Drawing.Color.Gray;
            this.Proc.Font = new System.Drawing.Font("HP Simplified", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Proc.ForeColor = System.Drawing.Color.Black;
            this.Proc.Iconcolor = System.Drawing.Color.Transparent;
            this.Proc.Iconimage = null;
            this.Proc.Iconimage_right = null;
            this.Proc.Iconimage_right_Selected = null;
            this.Proc.Iconimage_Selected = null;
            this.Proc.IconMarginLeft = 0;
            this.Proc.IconMarginRight = 0;
            this.Proc.IconRightVisible = true;
            this.Proc.IconRightZoom = 0D;
            this.Proc.IconVisible = true;
            this.Proc.IconZoom = 90D;
            this.Proc.IsTab = false;
            this.Proc.Location = new System.Drawing.Point(596, 666);
            this.Proc.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Proc.Name = "Proc";
            this.Proc.Normalcolor = System.Drawing.Color.White;
            this.Proc.OnHovercolor = System.Drawing.Color.White;
            this.Proc.OnHoverTextColor = System.Drawing.Color.Black;
            this.Proc.selected = false;
            this.Proc.Size = new System.Drawing.Size(202, 71);
            this.Proc.TabIndex = 26;
            this.Proc.Text = "PRINT SLIP";
            this.Proc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Proc.Textcolor = System.Drawing.Color.Black;
            this.Proc.TextFont = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold);
            this.Proc.Click += new System.EventHandler(this.Proc_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("HP Simplified", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(583, 594);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(128, 41);
            this.bunifuCustomLabel1.TabIndex = 29;
            this.bunifuCustomLabel1.Text = "TOTAL :";
            // 
            // CL1
            // 
            this.CL1.AutoSize = true;
            this.CL1.Font = new System.Drawing.Font("HP Simplified", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CL1.ForeColor = System.Drawing.Color.White;
            this.CL1.Location = new System.Drawing.Point(703, 594);
            this.CL1.Name = "CL1";
            this.CL1.Size = new System.Drawing.Size(101, 41);
            this.CL1.TabIndex = 30;
            this.CL1.Text = "$ 232";
            // 
            // Logo
            // 
            this.Logo.Image = global::GUI.Properties.Resources.images1;
            this.Logo.Location = new System.Drawing.Point(42, 32);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(165, 155);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Logo.TabIndex = 22;
            this.Logo.TabStop = false;
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.CL1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.Proc);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Panelx);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckOut";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Checkout";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Panelx.ResumeLayout(false);
            this.Panelx.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel Title;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel Panelx;
        private Bunifu.Framework.UI.BunifuCustomLabel Label12;
        private Bunifu.Framework.UI.BunifuCustomLabel L1;
        private Bunifu.Framework.UI.BunifuCustomLabel PriceL;
        private Bunifu.Framework.UI.BunifuCustomLabel Qty;
        private Bunifu.Framework.UI.BunifuCustomLabel Item;
        private Bunifu.Framework.UI.BunifuCustomLabel L3;
        private Bunifu.Framework.UI.BunifuCustomLabel L2;
        private Bunifu.Framework.UI.BunifuFlatButton Proc;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel CL1;
    }
}