namespace GUI
{
    partial class MyOrder
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
            this.Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TotalLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CostLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FoodLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PriceLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.QtyLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DateLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("HP Simplified", 30F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(131, -1);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(195, 46);
            this.Title.TabIndex = 37;
            this.Title.Text = "MY ORDER";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(23, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 314);
            this.panel1.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("HP Simplified", 10F);
            this.label3.Location = new System.Drawing.Point(272, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("HP Simplified", 10F);
            this.label2.Location = new System.Drawing.Point(205, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified", 10F);
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 41;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold);
            this.TotalLabel.ForeColor = System.Drawing.Color.Black;
            this.TotalLabel.Location = new System.Drawing.Point(89, 461);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(130, 40);
            this.TotalLabel.TabIndex = 43;
            this.TotalLabel.Text = "TOTAL : ";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold);
            this.CostLabel.ForeColor = System.Drawing.Color.Black;
            this.CostLabel.Location = new System.Drawing.Point(204, 461);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(77, 40);
            this.CostLabel.TabIndex = 44;
            this.CostLabel.Text = "$ 29";
            // 
            // FoodLabel
            // 
            this.FoodLabel.AutoSize = true;
            this.FoodLabel.Font = new System.Drawing.Font("HP Simplified", 17F, System.Drawing.FontStyle.Bold);
            this.FoodLabel.ForeColor = System.Drawing.Color.Black;
            this.FoodLabel.Location = new System.Drawing.Point(41, 94);
            this.FoodLabel.Name = "FoodLabel";
            this.FoodLabel.Size = new System.Drawing.Size(65, 27);
            this.FoodLabel.TabIndex = 44;
            this.FoodLabel.Text = "FOOD";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("HP Simplified", 17F, System.Drawing.FontStyle.Bold);
            this.PriceLabel.ForeColor = System.Drawing.Color.Black;
            this.PriceLabel.Location = new System.Drawing.Point(278, 94);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(67, 27);
            this.PriceLabel.TabIndex = 46;
            this.PriceLabel.Text = "PRICE";
            // 
            // QtyLabel
            // 
            this.QtyLabel.AutoSize = true;
            this.QtyLabel.Font = new System.Drawing.Font("HP Simplified", 17F, System.Drawing.FontStyle.Bold);
            this.QtyLabel.ForeColor = System.Drawing.Color.Black;
            this.QtyLabel.Location = new System.Drawing.Point(212, 94);
            this.QtyLabel.Name = "QtyLabel";
            this.QtyLabel.Size = new System.Drawing.Size(52, 27);
            this.QtyLabel.TabIndex = 45;
            this.QtyLabel.Text = "QTY";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.McLogoSmall;
            this.pictureBox1.Location = new System.Drawing.Point(52, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("HP Simplified", 10F);
            this.DateLabel.ForeColor = System.Drawing.Color.Black;
            this.DateLabel.Location = new System.Drawing.Point(138, 41);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(82, 17);
            this.DateLabel.TabIndex = 48;
            this.DateLabel.Text = "25-12-2018";
            // 
            // MyOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(390, 516);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.FoodLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.QtyLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MyOrder";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel Title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomLabel TotalLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel CostLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel FoodLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel PriceLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel QtyLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel DateLabel;
    }
}