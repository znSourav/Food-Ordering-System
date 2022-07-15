namespace GUI
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.L1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuCircleProgressbar1 = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.Customer = new Bunifu.Framework.UI.BunifuTileButton();
            this.Employee = new Bunifu.Framework.UI.BunifuTileButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("HP Simplified", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.ForeColor = System.Drawing.Color.White;
            this.L1.Location = new System.Drawing.Point(529, 369);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(329, 55);
            this.L1.TabIndex = 8;
            this.L1.Text = "WHO ARE YOU ?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.images1;
            this.pictureBox1.Location = new System.Drawing.Point(613, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.bunifuCircleProgressbar1.animated = true;
            this.bunifuCircleProgressbar1.animationIterval = 10;
            this.bunifuCircleProgressbar1.animationSpeed = 20;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.Transparent;
            this.bunifuCircleProgressbar1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.bunifuCircleProgressbar1.LabelVisible = false;
            this.bunifuCircleProgressbar1.LineProgressThickness = 10;
            this.bunifuCircleProgressbar1.LineThickness = 8;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(530, 18);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(325, 325);
            this.bunifuCircleProgressbar1.TabIndex = 11;
            this.bunifuCircleProgressbar1.Value = 8;
            // 
            // Customer
            // 
            this.Customer.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Customer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Customer.color = System.Drawing.SystemColors.ButtonHighlight;
            this.Customer.colorActive = System.Drawing.SystemColors.ButtonHighlight;
            this.Customer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Customer.Font = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer.ForeColor = System.Drawing.Color.Black;
            this.Customer.Image = global::GUI.Properties.Resources.if_icons_user_1564534;
            this.Customer.ImagePosition = 5;
            this.Customer.ImageZoom = 48;
            this.Customer.LabelPosition = 55;
            this.Customer.LabelText = "CUSTOMER";
            this.Customer.Location = new System.Drawing.Point(259, 489);
            this.Customer.Margin = new System.Windows.Forms.Padding(8);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(315, 220);
            this.Customer.TabIndex = 10;
            this.Customer.Click += new System.EventHandler(this.CustomerClick);
            // 
            // Employee
            // 
            this.Employee.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Employee.color = System.Drawing.SystemColors.ButtonHighlight;
            this.Employee.colorActive = System.Drawing.SystemColors.ButtonHighlight;
            this.Employee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Employee.Font = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Employee.ForeColor = System.Drawing.Color.Black;
            this.Employee.Image = global::GUI.Properties.Resources.if_business_2799208;
            this.Employee.ImagePosition = 5;
            this.Employee.ImageZoom = 48;
            this.Employee.LabelPosition = 55;
            this.Employee.LabelText = "EMPLOYEE";
            this.Employee.Location = new System.Drawing.Point(822, 489);
            this.Employee.Margin = new System.Windows.Forms.Padding(8);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(315, 220);
            this.Employee.TabIndex = 9;
            this.Employee.Click += new System.EventHandler(this.EmployeeButtonClick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuCircleProgressbar1);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.L1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuTileButton Customer;
        private Bunifu.Framework.UI.BunifuTileButton Employee;
        private System.Windows.Forms.Label L1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar bunifuCircleProgressbar1;
    }
}

