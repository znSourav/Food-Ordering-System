namespace GUI
{
    partial class Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.L1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Back = new System.Windows.Forms.PictureBox();
            this.PayAtCounter = new Bunifu.Framework.UI.BunifuTileButton();
            this.PayHere = new Bunifu.Framework.UI.BunifuTileButton();
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
            this.L1.Location = new System.Drawing.Point(347, 359);
            this.L1.Name = "L1";
            this.L1.Size = new System.Drawing.Size(688, 55);
            this.L1.TabIndex = 4;
            this.L1.Text = "WHERE WOULD YOU LIKE TO PAY ?";
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
            this.Back.TabIndex = 39;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.BackClick);
            // 
            // PayAtCounter
            // 
            this.PayAtCounter.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.PayAtCounter.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PayAtCounter.color = System.Drawing.SystemColors.ButtonHighlight;
            this.PayAtCounter.colorActive = System.Drawing.SystemColors.ButtonHighlight;
            this.PayAtCounter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PayAtCounter.Font = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayAtCounter.ForeColor = System.Drawing.Color.Black;
            this.PayAtCounter.Image = global::GUI.Properties.Resources.if_2___Cash_Register_2102044;
            this.PayAtCounter.ImagePosition = -10;
            this.PayAtCounter.ImageZoom = 60;
            this.PayAtCounter.LabelPosition = 55;
            this.PayAtCounter.LabelText = "PAY AT COUNTER";
            this.PayAtCounter.Location = new System.Drawing.Point(259, 489);
            this.PayAtCounter.Margin = new System.Windows.Forms.Padding(8);
            this.PayAtCounter.Name = "PayAtCounter";
            this.PayAtCounter.Size = new System.Drawing.Size(315, 220);
            this.PayAtCounter.TabIndex = 6;
            this.PayAtCounter.Click += new System.EventHandler(this.PayWhereClick);
            // 
            // PayHere
            // 
            this.PayHere.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PayHere.color = System.Drawing.SystemColors.ButtonHighlight;
            this.PayHere.colorActive = System.Drawing.SystemColors.ButtonHighlight;
            this.PayHere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PayHere.Font = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayHere.ForeColor = System.Drawing.Color.Black;
            this.PayHere.Image = global::GUI.Properties.Resources._512px_MasterCard_logo1;
            this.PayHere.ImagePosition = -40;
            this.PayHere.ImageZoom = 80;
            this.PayHere.LabelPosition = 55;
            this.PayHere.LabelText = "PAY HERE";
            this.PayHere.Location = new System.Drawing.Point(822, 489);
            this.PayHere.Margin = new System.Windows.Forms.Padding(8);
            this.PayHere.Name = "PayHere";
            this.PayHere.Size = new System.Drawing.Size(315, 220);
            this.PayHere.TabIndex = 5;
            this.PayHere.Click += new System.EventHandler(this.PayWhereClick);
            // 
            // MCLogo
            // 
            this.MCLogo.Image = global::GUI.Properties.Resources.McDonald_s_Logo;
            this.MCLogo.Location = new System.Drawing.Point(521, 12);
            this.MCLogo.Name = "MCLogo";
            this.MCLogo.Size = new System.Drawing.Size(340, 344);
            this.MCLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MCLogo.TabIndex = 3;
            this.MCLogo.TabStop = false;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.PayAtCounter);
            this.Controls.Add(this.PayHere);
            this.Controls.Add(this.L1);
            this.Controls.Add(this.MCLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Payment";
            this.Text = "Payment";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MCLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox MCLogo;
        private System.Windows.Forms.Label L1;
        private Bunifu.Framework.UI.BunifuTileButton PayHere;
        private Bunifu.Framework.UI.BunifuTileButton PayAtCounter;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.Timer timer1;
    }
}