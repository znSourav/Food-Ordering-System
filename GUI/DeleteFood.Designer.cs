namespace GUI
{
    partial class DeleteFood
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
            this.Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.IDLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FoodID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.FILabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FoodItem = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Back = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Delete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("HP Simplified", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(19, 190);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(225, 41);
            this.Title.TabIndex = 21;
            this.Title.Text = "DELETE  FOOD";
            // 
            // Logo
            // 
            this.Logo.Image = global::GUI.Properties.Resources.images1;
            this.Logo.Location = new System.Drawing.Point(42, 32);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(165, 155);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Logo.TabIndex = 20;
            this.Logo.TabStop = false;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("HP Simplified", 15F, System.Drawing.FontStyle.Bold);
            this.IDLabel.ForeColor = System.Drawing.Color.White;
            this.IDLabel.Location = new System.Drawing.Point(670, 397);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(77, 24);
            this.IDLabel.TabIndex = 25;
            this.IDLabel.Text = "FOOD ID";
            // 
            // FoodID
            // 
            this.FoodID.BorderColorFocused = System.Drawing.Color.White;
            this.FoodID.BorderColorIdle = System.Drawing.Color.White;
            this.FoodID.BorderColorMouseHover = System.Drawing.Color.White;
            this.FoodID.BorderThickness = 3;
            this.FoodID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FoodID.Font = new System.Drawing.Font("HP Simplified", 25F);
            this.FoodID.ForeColor = System.Drawing.Color.White;
            this.FoodID.isPassword = false;
            this.FoodID.Location = new System.Drawing.Point(519, 428);
            this.FoodID.Margin = new System.Windows.Forms.Padding(7);
            this.FoodID.Name = "FoodID";
            this.FoodID.Size = new System.Drawing.Size(387, 73);
            this.FoodID.TabIndex = 23;
            this.FoodID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FILabel
            // 
            this.FILabel.AutoSize = true;
            this.FILabel.Font = new System.Drawing.Font("HP Simplified", 15F, System.Drawing.FontStyle.Bold);
            this.FILabel.ForeColor = System.Drawing.Color.White;
            this.FILabel.Location = new System.Drawing.Point(655, 240);
            this.FILabel.Name = "FILabel";
            this.FILabel.Size = new System.Drawing.Size(100, 24);
            this.FILabel.TabIndex = 24;
            this.FILabel.Text = "FOOD ITEM";
            // 
            // FoodItem
            // 
            this.FoodItem.BorderColorFocused = System.Drawing.Color.White;
            this.FoodItem.BorderColorIdle = System.Drawing.Color.White;
            this.FoodItem.BorderColorMouseHover = System.Drawing.Color.White;
            this.FoodItem.BorderThickness = 3;
            this.FoodItem.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FoodItem.Font = new System.Drawing.Font("HP Simplified", 25F);
            this.FoodItem.ForeColor = System.Drawing.Color.White;
            this.FoodItem.isPassword = false;
            this.FoodItem.Location = new System.Drawing.Point(519, 271);
            this.FoodItem.Margin = new System.Windows.Forms.Padding(7);
            this.FoodItem.Name = "FoodItem";
            this.FoodItem.Size = new System.Drawing.Size(387, 73);
            this.FoodItem.TabIndex = 22;
            this.FoodItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Back.Location = new System.Drawing.Point(481, 580);
            this.Back.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Back.Name = "Back";
            this.Back.Normalcolor = System.Drawing.Color.White;
            this.Back.OnHovercolor = System.Drawing.Color.White;
            this.Back.OnHoverTextColor = System.Drawing.Color.Black;
            this.Back.selected = false;
            this.Back.Size = new System.Drawing.Size(180, 72);
            this.Back.TabIndex = 37;
            this.Back.Text = "BACK";
            this.Back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Back.Textcolor = System.Drawing.Color.Black;
            this.Back.TextFont = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold);
            this.Back.Click += new System.EventHandler(this.BackClick);
            // 
            // Delete
            // 
            this.Delete.Activecolor = System.Drawing.Color.White;
            this.Delete.BackColor = System.Drawing.Color.White;
            this.Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Delete.BorderRadius = 5;
            this.Delete.ButtonText = "DELETE";
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.DisabledColor = System.Drawing.Color.Gray;
            this.Delete.Font = new System.Drawing.Font("HP Simplified", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.Black;
            this.Delete.Iconcolor = System.Drawing.Color.Transparent;
            this.Delete.Iconimage = null;
            this.Delete.Iconimage_right = null;
            this.Delete.Iconimage_right_Selected = null;
            this.Delete.Iconimage_Selected = null;
            this.Delete.IconMarginLeft = 0;
            this.Delete.IconMarginRight = 0;
            this.Delete.IconRightVisible = true;
            this.Delete.IconRightZoom = 0D;
            this.Delete.IconVisible = true;
            this.Delete.IconZoom = 90D;
            this.Delete.IsTab = false;
            this.Delete.Location = new System.Drawing.Point(766, 577);
            this.Delete.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Delete.Name = "Delete";
            this.Delete.Normalcolor = System.Drawing.Color.White;
            this.Delete.OnHovercolor = System.Drawing.Color.White;
            this.Delete.OnHoverTextColor = System.Drawing.Color.Black;
            this.Delete.selected = false;
            this.Delete.Size = new System.Drawing.Size(180, 72);
            this.Delete.TabIndex = 36;
            this.Delete.Text = "DELETE";
            this.Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Delete.Textcolor = System.Drawing.Color.Black;
            this.Delete.TextFont = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold);
            this.Delete.Click += new System.EventHandler(this.DeleteClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DeleteFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.FoodID);
            this.Controls.Add(this.FILabel);
            this.Controls.Add(this.FoodItem);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteFood";
            this.Text = "DeleteFood";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DeleteFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel Title;
        private System.Windows.Forms.PictureBox Logo;
        private Bunifu.Framework.UI.BunifuCustomLabel IDLabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox FoodID;
        private Bunifu.Framework.UI.BunifuCustomLabel FILabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox FoodItem;
        private Bunifu.Framework.UI.BunifuFlatButton Back;
        private Bunifu.Framework.UI.BunifuFlatButton Delete;
        private System.Windows.Forms.Timer timer1;
    }
}