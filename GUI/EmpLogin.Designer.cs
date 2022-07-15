namespace GUI
{
    partial class EmpLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpLogin));
            this.Username = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.UNLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Password = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Back = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Login = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MCLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MCLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Username
            // 
            this.Username.BorderColorFocused = System.Drawing.Color.White;
            this.Username.BorderColorIdle = System.Drawing.Color.White;
            this.Username.BorderColorMouseHover = System.Drawing.Color.White;
            this.Username.BorderThickness = 3;
            this.Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username.Font = new System.Drawing.Font("HP Simplified", 25F);
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.isPassword = false;
            this.Username.Location = new System.Drawing.Point(499, 373);
            this.Username.Margin = new System.Windows.Forms.Padding(7);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(387, 73);
            this.Username.TabIndex = 1;
            this.Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UNLabel
            // 
            this.UNLabel.AutoSize = true;
            this.UNLabel.Font = new System.Drawing.Font("HP Simplified", 15F, System.Drawing.FontStyle.Bold);
            this.UNLabel.ForeColor = System.Drawing.Color.White;
            this.UNLabel.Location = new System.Drawing.Point(635, 342);
            this.UNLabel.Name = "UNLabel";
            this.UNLabel.Size = new System.Drawing.Size(102, 24);
            this.UNLabel.TabIndex = 6;
            this.UNLabel.Text = "USERNAME";
            // 
            // PLabel
            // 
            this.PLabel.AutoSize = true;
            this.PLabel.Font = new System.Drawing.Font("HP Simplified", 15F, System.Drawing.FontStyle.Bold);
            this.PLabel.ForeColor = System.Drawing.Color.White;
            this.PLabel.Location = new System.Drawing.Point(635, 479);
            this.PLabel.Name = "PLabel";
            this.PLabel.Size = new System.Drawing.Size(105, 24);
            this.PLabel.TabIndex = 8;
            this.PLabel.Text = "PASSWORD";
            // 
            // Password
            // 
            this.Password.BorderColorFocused = System.Drawing.Color.White;
            this.Password.BorderColorIdle = System.Drawing.Color.White;
            this.Password.BorderColorMouseHover = System.Drawing.Color.White;
            this.Password.BorderThickness = 3;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Font = new System.Drawing.Font("HP Simplified", 25F);
            this.Password.ForeColor = System.Drawing.Color.White;
            this.Password.isPassword = true;
            this.Password.Location = new System.Drawing.Point(499, 510);
            this.Password.Margin = new System.Windows.Forms.Padding(7);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(387, 73);
            this.Password.TabIndex = 2;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Back
            // 
            this.Back.Activecolor = System.Drawing.Color.White;
            this.Back.BackColor = System.Drawing.Color.White;
            this.Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Back.BorderRadius = 5;
            this.Back.ButtonText = "BACK";
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.DisabledColor = System.Drawing.Color.Gray;
            this.Back.Font = new System.Drawing.Font("HP Simplified", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.Color.Black;
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
            this.Back.Location = new System.Drawing.Point(499, 644);
            this.Back.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Back.Name = "Back";
            this.Back.Normalcolor = System.Drawing.Color.White;
            this.Back.OnHovercolor = System.Drawing.Color.White;
            this.Back.OnHoverTextColor = System.Drawing.Color.Black;
            this.Back.selected = false;
            this.Back.Size = new System.Drawing.Size(165, 57);
            this.Back.TabIndex = 24;
            this.Back.Text = "BACK";
            this.Back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Back.Textcolor = System.Drawing.Color.Black;
            this.Back.TextFont = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold);
            this.Back.Click += new System.EventHandler(this.BackClick);
            // 
            // Login
            // 
            this.Login.Activecolor = System.Drawing.Color.White;
            this.Login.BackColor = System.Drawing.Color.White;
            this.Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login.BorderRadius = 5;
            this.Login.ButtonText = "LOGIN";
            this.Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login.DisabledColor = System.Drawing.Color.Gray;
            this.Login.Font = new System.Drawing.Font("HP Simplified", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.Black;
            this.Login.Iconcolor = System.Drawing.Color.Transparent;
            this.Login.Iconimage = null;
            this.Login.Iconimage_right = null;
            this.Login.Iconimage_right_Selected = null;
            this.Login.Iconimage_Selected = null;
            this.Login.IconMarginLeft = 0;
            this.Login.IconMarginRight = 0;
            this.Login.IconRightVisible = true;
            this.Login.IconRightZoom = 0D;
            this.Login.IconVisible = true;
            this.Login.IconZoom = 90D;
            this.Login.IsTab = false;
            this.Login.Location = new System.Drawing.Point(721, 644);
            this.Login.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Login.Name = "Login";
            this.Login.Normalcolor = System.Drawing.Color.White;
            this.Login.OnHovercolor = System.Drawing.Color.White;
            this.Login.OnHoverTextColor = System.Drawing.Color.Black;
            this.Login.selected = false;
            this.Login.Size = new System.Drawing.Size(165, 57);
            this.Login.TabIndex = 23;
            this.Login.Text = "LOGIN";
            this.Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Login.Textcolor = System.Drawing.Color.Black;
            this.Login.TextFont = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold);
            this.Login.Click += new System.EventHandler(this.LoginClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MCLogo
            // 
            this.MCLogo.Image = global::GUI.Properties.Resources.McDonald_s_Logo;
            this.MCLogo.Location = new System.Drawing.Point(512, 12);
            this.MCLogo.Name = "MCLogo";
            this.MCLogo.Size = new System.Drawing.Size(361, 366);
            this.MCLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MCLogo.TabIndex = 4;
            this.MCLogo.TabStop = false;
            // 
            // EmpLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.PLabel);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.UNLabel);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.MCLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmpLogin";
            this.Text = "EmpLogin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmpLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MCLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MCLogo;
        private Bunifu.Framework.UI.BunifuMetroTextbox Username;
        private Bunifu.Framework.UI.BunifuCustomLabel UNLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel PLabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox Password;
        private Bunifu.Framework.UI.BunifuFlatButton Back;
        private Bunifu.Framework.UI.BunifuFlatButton Login;
        private System.Windows.Forms.Timer timer1;
    }
}