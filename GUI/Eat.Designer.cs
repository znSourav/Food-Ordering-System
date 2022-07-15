namespace GUI
{
    partial class Eat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Eat));
            this.L1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Back = new System.Windows.Forms.PictureBox();
            this.EatIn = new Bunifu.Framework.UI.BunifuTileButton();
            this.Takeaway = new Bunifu.Framework.UI.BunifuTileButton();
            this.MCLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MCLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // L1
            // 
            this.L1.AutoSize = true;
            this.L1.Font = new System.Drawing.Font("HP Simplified", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L1.ForeColor = System.Drawing.Color.White;
            this.L1.Location = new System.Drawing.Point(502, 359);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(383, 55);
            this.L1.TabIndex = 5;
            this.L1.Text = "EATING  LOCATION";
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Back
            // 
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Image = global::GUI.Properties.Resources.Log_Out;
            this.Back.Location = new System.Drawing.Point(679, 707);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(31, 33);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back.TabIndex = 40;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.BackClick);
            // 
            // EatIn
            // 
            this.EatIn.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.EatIn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EatIn.color = System.Drawing.SystemColors.ButtonHighlight;
            this.EatIn.colorActive = System.Drawing.SystemColors.ButtonHighlight;
            this.EatIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EatIn.Font = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EatIn.ForeColor = System.Drawing.Color.Black;
            this.EatIn.Image = global::GUI.Properties.Resources.eatIn;
            this.EatIn.ImagePosition = -25;
            this.EatIn.ImageZoom = 75;
            this.EatIn.LabelPosition = 55;
            this.EatIn.LabelText = "EAT  IN";
            this.EatIn.Location = new System.Drawing.Point(259, 489);
            this.EatIn.Margin = new System.Windows.Forms.Padding(8);
            this.EatIn.Name = "EatIn";
            this.EatIn.Size = new System.Drawing.Size(315, 220);
            this.EatIn.TabIndex = 8;
            this.EatIn.Click += new System.EventHandler(this.EatButtonClick);
            // 
            // Takeaway
            // 
            this.Takeaway.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Takeaway.color = System.Drawing.SystemColors.ButtonHighlight;
            this.Takeaway.colorActive = System.Drawing.SystemColors.ButtonHighlight;
            this.Takeaway.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Takeaway.Font = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Takeaway.ForeColor = System.Drawing.Color.Black;
            this.Takeaway.Image = global::GUI.Properties.Resources.takeaway;
            this.Takeaway.ImagePosition = 6;
            this.Takeaway.ImageZoom = 44;
            this.Takeaway.LabelPosition = 55;
            this.Takeaway.LabelText = "TAKEAWAY";
            this.Takeaway.Location = new System.Drawing.Point(822, 489);
            this.Takeaway.Margin = new System.Windows.Forms.Padding(8);
            this.Takeaway.Name = "Takeaway";
            this.Takeaway.Size = new System.Drawing.Size(315, 220);
            this.Takeaway.TabIndex = 7;
            this.Takeaway.Click += new System.EventHandler(this.EatButtonClick);
            // 
            // MCLogo
            // 
            this.MCLogo.Image = global::GUI.Properties.Resources.McDonald_s_Logo;
            this.MCLogo.Location = new System.Drawing.Point(521, 12);
            this.MCLogo.Name = "MCLogo";
            this.MCLogo.Size = new System.Drawing.Size(340, 344);
            this.MCLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MCLogo.TabIndex = 4;
            this.MCLogo.TabStop = false;
            // 
            // Eat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.EatIn);
            this.Controls.Add(this.Takeaway);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.MCLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Eat";
            this.Text = "Eat";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Eat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MCLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MCLogo;
        private System.Windows.Forms.Label L1;
        private Bunifu.Framework.UI.BunifuTileButton EatIn;
        private Bunifu.Framework.UI.BunifuTileButton Takeaway;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.Timer timer1;
    }
}