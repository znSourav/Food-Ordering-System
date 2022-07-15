namespace GUI
{
    partial class Ingredients
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ItemLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PriceLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.QtyLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Confirm = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Back = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.McLogoSmall;
            this.pictureBox1.Location = new System.Drawing.Point(32, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.Font = new System.Drawing.Font("HP Simplified", 17F, System.Drawing.FontStyle.Bold);
            this.ItemLabel.ForeColor = System.Drawing.Color.Black;
            this.ItemLabel.Location = new System.Drawing.Point(16, 0);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(58, 27);
            this.ItemLabel.TabIndex = 52;
            this.ItemLabel.Text = "ITEM";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("HP Simplified", 17F, System.Drawing.FontStyle.Bold);
            this.PriceLabel.ForeColor = System.Drawing.Color.Black;
            this.PriceLabel.Location = new System.Drawing.Point(259, 0);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(67, 27);
            this.PriceLabel.TabIndex = 55;
            this.PriceLabel.Text = "PRICE";
            // 
            // QtyLabel
            // 
            this.QtyLabel.AutoSize = true;
            this.QtyLabel.Font = new System.Drawing.Font("HP Simplified", 17F, System.Drawing.FontStyle.Bold);
            this.QtyLabel.ForeColor = System.Drawing.Color.Black;
            this.QtyLabel.Location = new System.Drawing.Point(187, 0);
            this.QtyLabel.Name = "QtyLabel";
            this.QtyLabel.Size = new System.Drawing.Size(52, 27);
            this.QtyLabel.TabIndex = 54;
            this.QtyLabel.Text = "QTY";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.ItemLabel);
            this.panel1.Controls.Add(this.PriceLabel);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.QtyLabel);
            this.panel1.Location = new System.Drawing.Point(26, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 321);
            this.panel1.TabIndex = 50;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HP Simplified", 10F);
            this.label3.Location = new System.Drawing.Point(272, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HP Simplified", 10F);
            this.label2.Location = new System.Drawing.Point(205, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified", 10F);
            this.label1.Location = new System.Drawing.Point(5, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 41;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("HP Simplified", 30F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(111, 24);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(247, 46);
            this.Title.TabIndex = 49;
            this.Title.Text = "INGREDIENTS";
            // 
            // Confirm
            // 
            this.Confirm.Activecolor = System.Drawing.Color.Black;
            this.Confirm.BackColor = System.Drawing.Color.Black;
            this.Confirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Confirm.BorderRadius = 5;
            this.Confirm.ButtonText = "CONFIRM";
            this.Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Confirm.DisabledColor = System.Drawing.Color.Gray;
            this.Confirm.Font = new System.Drawing.Font("HP Simplified", 18F, System.Drawing.FontStyle.Bold);
            this.Confirm.ForeColor = System.Drawing.Color.White;
            this.Confirm.Iconcolor = System.Drawing.Color.Transparent;
            this.Confirm.Iconimage = null;
            this.Confirm.Iconimage_right = null;
            this.Confirm.Iconimage_right_Selected = null;
            this.Confirm.Iconimage_Selected = null;
            this.Confirm.IconMarginLeft = 0;
            this.Confirm.IconMarginRight = 0;
            this.Confirm.IconRightVisible = true;
            this.Confirm.IconRightZoom = 0D;
            this.Confirm.IconVisible = true;
            this.Confirm.IconZoom = 90D;
            this.Confirm.IsTab = false;
            this.Confirm.Location = new System.Drawing.Point(222, 453);
            this.Confirm.Margin = new System.Windows.Forms.Padding(7);
            this.Confirm.Name = "Confirm";
            this.Confirm.Normalcolor = System.Drawing.Color.Black;
            this.Confirm.OnHovercolor = System.Drawing.Color.Black;
            this.Confirm.OnHoverTextColor = System.Drawing.Color.White;
            this.Confirm.selected = false;
            this.Confirm.Size = new System.Drawing.Size(121, 47);
            this.Confirm.TabIndex = 57;
            this.Confirm.Text = "CONFIRM";
            this.Confirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Confirm.Textcolor = System.Drawing.Color.White;
            this.Confirm.TextFont = new System.Drawing.Font("HP Simplified", 18F, System.Drawing.FontStyle.Bold);
            this.Confirm.Click += new System.EventHandler(this.OkClick);
            // 
            // Back
            // 
            this.Back.Activecolor = System.Drawing.Color.Black;
            this.Back.BackColor = System.Drawing.Color.Black;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.BorderRadius = 5;
            this.Back.ButtonText = "BACK";
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.DisabledColor = System.Drawing.Color.Gray;
            this.Back.Font = new System.Drawing.Font("HP Simplified", 18F, System.Drawing.FontStyle.Bold);
            this.Back.ForeColor = System.Drawing.Color.White;
            this.Back.Iconcolor = System.Drawing.Color.Transparent;
            this.Back.Iconimage = null;
            this.Back.Iconimage_right = null;
            this.Back.Iconimage_right_Selected = null;
            this.Back.Iconimage_Selected = null;
            this.Back.IconMarginLeft = 0;
            this.Back.IconMarginRight = 0;
            this.Back.IconRightVisible = true;
            this.Back.IconRightZoom = 0D;
            this.Back.IconVisible = true;
            this.Back.IconZoom = 90D;
            this.Back.IsTab = false;
            this.Back.Location = new System.Drawing.Point(56, 453);
            this.Back.Margin = new System.Windows.Forms.Padding(7);
            this.Back.Name = "Back";
            this.Back.Normalcolor = System.Drawing.Color.Black;
            this.Back.OnHovercolor = System.Drawing.Color.Black;
            this.Back.OnHoverTextColor = System.Drawing.Color.White;
            this.Back.selected = false;
            this.Back.Size = new System.Drawing.Size(121, 47);
            this.Back.TabIndex = 58;
            this.Back.Text = "BACK";
            this.Back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Back.Textcolor = System.Drawing.Color.White;
            this.Back.TextFont = new System.Drawing.Font("HP Simplified", 18F, System.Drawing.FontStyle.Bold);
            this.Back.Click += new System.EventHandler(this.BackClick);
            // 
            // Ingredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(390, 516);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ingredients";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel ItemLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel PriceLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel QtyLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel Title;
        private Bunifu.Framework.UI.BunifuFlatButton Confirm;
        private Bunifu.Framework.UI.BunifuFlatButton Back;
    }
}