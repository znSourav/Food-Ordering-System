namespace GUI
{
    partial class Thankyou
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Thankyou));
            this.Label12 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MCLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.MCLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("HP Simplified", 80F, System.Drawing.FontStyle.Bold);
            this.Label12.ForeColor = System.Drawing.Color.White;
            this.Label12.Location = new System.Drawing.Point(381, 393);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(625, 123);
            this.Label12.TabIndex = 26;
            this.Label12.Text = "THANK YOU !";
            // 
            // MCLogo
            // 
            this.MCLogo.Image = global::GUI.Properties.Resources.McDonald_s_Logo;
            this.MCLogo.Location = new System.Drawing.Point(524, 46);
            this.MCLogo.Name = "MCLogo";
            this.MCLogo.Size = new System.Drawing.Size(340, 344);
            this.MCLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MCLogo.TabIndex = 4;
            this.MCLogo.TabStop = false;
            // 
            // Thankyou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.MCLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Thankyou";
            this.Text = "Thankyou";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.MCLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox MCLogo;
        private Bunifu.Framework.UI.BunifuCustomLabel Label12;
    }
}