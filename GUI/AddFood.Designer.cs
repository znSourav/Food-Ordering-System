namespace GUI
{
    partial class AddFood
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFood));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FoodName = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.FILabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FoodItem = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.PLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FoodPrice = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.FIDLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.FoodId = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.PanelX = new System.Windows.Forms.Panel();
            this.PictureBX = new System.Windows.Forms.PictureBox();
            this.FPLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Browse = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Upload = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Back = new Bunifu.Framework.UI.BunifuFlatButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBX)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.images1;
            this.pictureBox1.Location = new System.Drawing.Point(42, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NLabel
            // 
            this.NLabel.AutoSize = true;
            this.NLabel.Font = new System.Drawing.Font("HP Simplified", 15F, System.Drawing.FontStyle.Bold);
            this.NLabel.ForeColor = System.Drawing.Color.White;
            this.NLabel.Location = new System.Drawing.Point(287, 395);
            this.NLabel.Name = "NLabel";
            this.NLabel.Size = new System.Drawing.Size(108, 24);
            this.NLabel.TabIndex = 12;
            this.NLabel.Text = "FOOD NAME";
            // 
            // FoodName
            // 
            this.FoodName.BorderColorFocused = System.Drawing.Color.White;
            this.FoodName.BorderColorIdle = System.Drawing.Color.White;
            this.FoodName.BorderColorMouseHover = System.Drawing.Color.White;
            this.FoodName.BorderThickness = 3;
            this.FoodName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FoodName.Font = new System.Drawing.Font("HP Simplified", 25F);
            this.FoodName.ForeColor = System.Drawing.Color.White;
            this.FoodName.isPassword = false;
            this.FoodName.Location = new System.Drawing.Point(405, 366);
            this.FoodName.Margin = new System.Windows.Forms.Padding(7);
            this.FoodName.Name = "FoodName";
            this.FoodName.Size = new System.Drawing.Size(387, 73);
            this.FoodName.TabIndex = 3;
            this.FoodName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FILabel
            // 
            this.FILabel.AutoSize = true;
            this.FILabel.Font = new System.Drawing.Font("HP Simplified", 15F, System.Drawing.FontStyle.Bold);
            this.FILabel.ForeColor = System.Drawing.Color.White;
            this.FILabel.Location = new System.Drawing.Point(295, 151);
            this.FILabel.Name = "FILabel";
            this.FILabel.Size = new System.Drawing.Size(100, 24);
            this.FILabel.TabIndex = 10;
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
            this.FoodItem.Location = new System.Drawing.Point(405, 127);
            this.FoodItem.Margin = new System.Windows.Forms.Padding(7);
            this.FoodItem.Name = "FoodItem";
            this.FoodItem.Size = new System.Drawing.Size(387, 73);
            this.FoodItem.TabIndex = 1;
            this.FoodItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PLabel
            // 
            this.PLabel.AutoSize = true;
            this.PLabel.Font = new System.Drawing.Font("HP Simplified", 15F, System.Drawing.FontStyle.Bold);
            this.PLabel.ForeColor = System.Drawing.Color.White;
            this.PLabel.Location = new System.Drawing.Point(287, 513);
            this.PLabel.Name = "PLabel";
            this.PLabel.Size = new System.Drawing.Size(108, 24);
            this.PLabel.TabIndex = 14;
            this.PLabel.Text = "FOOD PRICE";
            // 
            // FoodPrice
            // 
            this.FoodPrice.BorderColorFocused = System.Drawing.Color.White;
            this.FoodPrice.BorderColorIdle = System.Drawing.Color.White;
            this.FoodPrice.BorderColorMouseHover = System.Drawing.Color.White;
            this.FoodPrice.BorderThickness = 3;
            this.FoodPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FoodPrice.Font = new System.Drawing.Font("HP Simplified", 25F);
            this.FoodPrice.ForeColor = System.Drawing.Color.White;
            this.FoodPrice.isPassword = false;
            this.FoodPrice.Location = new System.Drawing.Point(405, 489);
            this.FoodPrice.Margin = new System.Windows.Forms.Padding(7);
            this.FoodPrice.Name = "FoodPrice";
            this.FoodPrice.Size = new System.Drawing.Size(387, 73);
            this.FoodPrice.TabIndex = 4;
            this.FoodPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FIDLabel
            // 
            this.FIDLabel.AutoSize = true;
            this.FIDLabel.Font = new System.Drawing.Font("HP Simplified", 15F, System.Drawing.FontStyle.Bold);
            this.FIDLabel.ForeColor = System.Drawing.Color.White;
            this.FIDLabel.Location = new System.Drawing.Point(318, 272);
            this.FIDLabel.Name = "FIDLabel";
            this.FIDLabel.Size = new System.Drawing.Size(77, 24);
            this.FIDLabel.TabIndex = 16;
            this.FIDLabel.Text = "FOOD ID";
            // 
            // FoodId
            // 
            this.FoodId.BorderColorFocused = System.Drawing.Color.White;
            this.FoodId.BorderColorIdle = System.Drawing.Color.White;
            this.FoodId.BorderColorMouseHover = System.Drawing.Color.White;
            this.FoodId.BorderThickness = 3;
            this.FoodId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FoodId.Font = new System.Drawing.Font("HP Simplified", 25F);
            this.FoodId.ForeColor = System.Drawing.Color.White;
            this.FoodId.isPassword = false;
            this.FoodId.Location = new System.Drawing.Point(405, 245);
            this.FoodId.Margin = new System.Windows.Forms.Padding(7);
            this.FoodId.Name = "FoodId";
            this.FoodId.Size = new System.Drawing.Size(387, 73);
            this.FoodId.TabIndex = 2;
            this.FoodId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("HP Simplified", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(41, 190);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(169, 41);
            this.Title.TabIndex = 17;
            this.Title.Text = "ADD FOOD";
            // 
            // PanelX
            // 
            this.PanelX.BackColor = System.Drawing.Color.White;
            this.PanelX.Controls.Add(this.PictureBX);
            this.PanelX.Location = new System.Drawing.Point(913, 158);
            this.PanelX.Name = "PanelX";
            this.PanelX.Size = new System.Drawing.Size(380, 380);
            this.PanelX.TabIndex = 18;
            // 
            // PictureBX
            // 
            this.PictureBX.Location = new System.Drawing.Point(0, 0);
            this.PictureBX.Name = "PictureBX";
            this.PictureBX.Size = new System.Drawing.Size(100, 50);
            this.PictureBX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PictureBX.TabIndex = 23;
            this.PictureBX.TabStop = false;
            // 
            // FPLabel
            // 
            this.FPLabel.AutoSize = true;
            this.FPLabel.Font = new System.Drawing.Font("HP Simplified", 15F, System.Drawing.FontStyle.Bold);
            this.FPLabel.ForeColor = System.Drawing.Color.White;
            this.FPLabel.Location = new System.Drawing.Point(909, 127);
            this.FPLabel.Name = "FPLabel";
            this.FPLabel.Size = new System.Drawing.Size(113, 24);
            this.FPLabel.TabIndex = 19;
            this.FPLabel.Text = "FOOD IMAGE";
            // 
            // Browse
            // 
            this.Browse.Activecolor = System.Drawing.Color.White;
            this.Browse.BackColor = System.Drawing.Color.White;
            this.Browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Browse.BorderRadius = 5;
            this.Browse.ButtonText = "BROWSE";
            this.Browse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Browse.DisabledColor = System.Drawing.Color.Gray;
            this.Browse.Iconcolor = System.Drawing.Color.Transparent;
            this.Browse.Iconimage = null;
            this.Browse.Iconimage_right = null;
            this.Browse.Iconimage_right_Selected = null;
            this.Browse.Iconimage_Selected = null;
            this.Browse.IconMarginLeft = 0;
            this.Browse.IconMarginRight = 0;
            this.Browse.IconRightVisible = true;
            this.Browse.IconRightZoom = 0D;
            this.Browse.IconVisible = true;
            this.Browse.IconZoom = 90D;
            this.Browse.IsTab = false;
            this.Browse.Location = new System.Drawing.Point(1198, 547);
            this.Browse.Name = "Browse";
            this.Browse.Normalcolor = System.Drawing.Color.White;
            this.Browse.OnHovercolor = System.Drawing.Color.White;
            this.Browse.OnHoverTextColor = System.Drawing.Color.Black;
            this.Browse.selected = false;
            this.Browse.Size = new System.Drawing.Size(95, 30);
            this.Browse.TabIndex = 20;
            this.Browse.Text = "BROWSE";
            this.Browse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Browse.Textcolor = System.Drawing.Color.Black;
            this.Browse.TextFont = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Browse.Click += new System.EventHandler(this.BrowseClick);
            // 
            // Upload
            // 
            this.Upload.Activecolor = System.Drawing.Color.White;
            this.Upload.BackColor = System.Drawing.Color.White;
            this.Upload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Upload.BorderRadius = 5;
            this.Upload.ButtonText = "UPLOAD";
            this.Upload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Upload.DisabledColor = System.Drawing.Color.Gray;
            this.Upload.Font = new System.Drawing.Font("HP Simplified", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upload.ForeColor = System.Drawing.Color.Black;
            this.Upload.Iconcolor = System.Drawing.Color.Transparent;
            this.Upload.Iconimage = null;
            this.Upload.Iconimage_right = null;
            this.Upload.Iconimage_right_Selected = null;
            this.Upload.Iconimage_Selected = null;
            this.Upload.IconMarginLeft = 0;
            this.Upload.IconMarginRight = 0;
            this.Upload.IconRightVisible = true;
            this.Upload.IconRightZoom = 0D;
            this.Upload.IconVisible = true;
            this.Upload.IconZoom = 90D;
            this.Upload.IsTab = false;
            this.Upload.Location = new System.Drawing.Point(661, 632);
            this.Upload.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Upload.Name = "Upload";
            this.Upload.Normalcolor = System.Drawing.Color.White;
            this.Upload.OnHovercolor = System.Drawing.Color.White;
            this.Upload.OnHoverTextColor = System.Drawing.Color.Black;
            this.Upload.selected = false;
            this.Upload.Size = new System.Drawing.Size(180, 72);
            this.Upload.TabIndex = 21;
            this.Upload.Text = "UPLOAD";
            this.Upload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Upload.Textcolor = System.Drawing.Color.Black;
            this.Upload.TextFont = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold);
            this.Upload.Click += new System.EventHandler(this.UploadClick);
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
            this.Back.Location = new System.Drawing.Point(370, 632);
            this.Back.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Back.Name = "Back";
            this.Back.Normalcolor = System.Drawing.Color.White;
            this.Back.OnHovercolor = System.Drawing.Color.White;
            this.Back.OnHoverTextColor = System.Drawing.Color.Black;
            this.Back.selected = false;
            this.Back.Size = new System.Drawing.Size(180, 72);
            this.Back.TabIndex = 22;
            this.Back.Text = "BACK";
            this.Back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Back.Textcolor = System.Drawing.Color.Black;
            this.Back.TextFont = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold);
            this.Back.Click += new System.EventHandler(this.BackClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AddFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.Browse);
            this.Controls.Add(this.FPLabel);
            this.Controls.Add(this.PanelX);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.FIDLabel);
            this.Controls.Add(this.FoodId);
            this.Controls.Add(this.PLabel);
            this.Controls.Add(this.FoodPrice);
            this.Controls.Add(this.NLabel);
            this.Controls.Add(this.FoodName);
            this.Controls.Add(this.FILabel);
            this.Controls.Add(this.FoodItem);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddFood";
            this.Text = "AddFood";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelX.ResumeLayout(false);
            this.PanelX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel NLabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox FoodName;
        private Bunifu.Framework.UI.BunifuCustomLabel FILabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox FoodItem;
        private Bunifu.Framework.UI.BunifuCustomLabel PLabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox FoodPrice;
        private Bunifu.Framework.UI.BunifuCustomLabel FIDLabel;
        private Bunifu.Framework.UI.BunifuMetroTextbox FoodId;
        private Bunifu.Framework.UI.BunifuCustomLabel Title;
        private System.Windows.Forms.Panel PanelX;
        private Bunifu.Framework.UI.BunifuCustomLabel FPLabel;
        private Bunifu.Framework.UI.BunifuFlatButton Browse;
        private Bunifu.Framework.UI.BunifuFlatButton Upload;
        private Bunifu.Framework.UI.BunifuFlatButton Back;
        private System.Windows.Forms.PictureBox PictureBX;
        private System.Windows.Forms.Timer timer1;
    }
}