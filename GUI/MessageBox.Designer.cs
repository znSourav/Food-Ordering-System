namespace GUI
{
    partial class MessageBox
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
            this.Message = new System.Windows.Forms.Label();
            this.PB2 = new System.Windows.Forms.PictureBox();
            this.PB1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).BeginInit();
            this.SuspendLayout();
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Font = new System.Drawing.Font("HP Simplified", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Message.Location = new System.Drawing.Point(124, 59);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(153, 37);
            this.Message.TabIndex = 1;
            this.Message.Text = "PERFECT !";
            // 
            // PB2
            // 
            this.PB2.Image = global::GUI.Properties.Resources.ezgif_com_resize;
            this.PB2.Location = new System.Drawing.Point(54, 46);
            this.PB2.Name = "PB2";
            this.PB2.Size = new System.Drawing.Size(64, 64);
            this.PB2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB2.TabIndex = 2;
            this.PB2.TabStop = false;
            // 
            // PB1
            // 
            this.PB1.Image = global::GUI.Properties.Resources.if_check_1930264__1_;
            this.PB1.Location = new System.Drawing.Point(54, 46);
            this.PB1.Name = "PB1";
            this.PB1.Size = new System.Drawing.Size(64, 64);
            this.PB1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PB1.TabIndex = 0;
            this.PB1.TabStop = false;
            // 
            // MessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(330, 160);
            this.Controls.Add(this.PB2);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.PB1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessageBox";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SuccessBox";
            ((System.ComponentModel.ISupportInitialize)(this.PB2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Message;
        private System.Windows.Forms.PictureBox PB2;
        private System.Windows.Forms.PictureBox PB1;
    }
}