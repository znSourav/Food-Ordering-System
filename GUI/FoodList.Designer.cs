namespace GUI
{
    partial class FoodList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FoodList));
            this.FoodListLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BurgerPanel = new System.Windows.Forms.Panel();
            this.FoodGridView = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.burgerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fOS_DatabaseDataSet = new GUI.FOS_DatabaseDataSet();
            this.burgerTableAdapter = new GUI.FOS_DatabaseDataSetTableAdapters.BurgerTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.DeleteFood = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LogOut = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.BurgerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FoodGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.burgerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOS_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogOut)).BeginInit();
            this.SuspendLayout();
            // 
            // FoodListLabel
            // 
            this.FoodListLabel.AutoSize = true;
            this.FoodListLabel.Font = new System.Drawing.Font("HP Simplified", 60F, System.Drawing.FontStyle.Bold);
            this.FoodListLabel.ForeColor = System.Drawing.Color.White;
            this.FoodListLabel.Location = new System.Drawing.Point(621, 77);
            this.FoodListLabel.Name = "FoodListLabel";
            this.FoodListLabel.Size = new System.Drawing.Size(225, 92);
            this.FoodListLabel.TabIndex = 36;
            this.FoodListLabel.Text = "FOOD";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("HP Simplified", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(38, 189);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(170, 41);
            this.Title.TabIndex = 35;
            this.Title.Text = "FOOD LIST";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources.images1;
            this.pictureBox1.Location = new System.Drawing.Point(21, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // BurgerPanel
            // 
            this.BurgerPanel.Controls.Add(this.FoodGridView);
            this.BurgerPanel.Font = new System.Drawing.Font("HP Simplified", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BurgerPanel.Location = new System.Drawing.Point(190, 285);
            this.BurgerPanel.Name = "BurgerPanel";
            this.BurgerPanel.Size = new System.Drawing.Size(1044, 432);
            this.BurgerPanel.TabIndex = 37;
            // 
            // FoodGridView
            // 
            this.FoodGridView.AllowUserToAddRows = false;
            this.FoodGridView.AllowUserToDeleteRows = false;
            this.FoodGridView.AllowUserToResizeColumns = false;
            this.FoodGridView.AllowUserToResizeRows = false;
            this.FoodGridView.AutoGenerateColumns = false;
            this.FoodGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FoodGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.FoodGridView.BackgroundColor = System.Drawing.Color.White;
            this.FoodGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("HP Simplified", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FoodGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.FoodGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FoodGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.foodTypeDataGridViewTextBoxColumn,
            this.imageDataGridViewImageColumn});
            this.FoodGridView.DataSource = this.burgerBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("HP Simplified", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FoodGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.FoodGridView.GridColor = System.Drawing.Color.White;
            this.FoodGridView.Location = new System.Drawing.Point(0, 0);
            this.FoodGridView.Name = "FoodGridView";
            this.FoodGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("HP Simplified", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FoodGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.FoodGridView.RowHeadersWidth = 40;
            this.FoodGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("HP Simplified", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.FoodGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.FoodGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FoodGridView.Size = new System.Drawing.Size(1006, 429);
            this.FoodGridView.TabIndex = 0;
            this.FoodGridView.Visible = false;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 250F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 250;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.FillWeight = 150F;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // foodTypeDataGridViewTextBoxColumn
            // 
            this.foodTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.foodTypeDataGridViewTextBoxColumn.DataPropertyName = "Food Type";
            this.foodTypeDataGridViewTextBoxColumn.FillWeight = 200F;
            this.foodTypeDataGridViewTextBoxColumn.HeaderText = "Food Type";
            this.foodTypeDataGridViewTextBoxColumn.Name = "foodTypeDataGridViewTextBoxColumn";
            this.foodTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.foodTypeDataGridViewTextBoxColumn.Width = 200;
            // 
            // imageDataGridViewImageColumn
            // 
            this.imageDataGridViewImageColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.imageDataGridViewImageColumn.DataPropertyName = "Image";
            this.imageDataGridViewImageColumn.FillWeight = 230F;
            this.imageDataGridViewImageColumn.HeaderText = "Image";
            this.imageDataGridViewImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.imageDataGridViewImageColumn.Name = "imageDataGridViewImageColumn";
            this.imageDataGridViewImageColumn.ReadOnly = true;
            this.imageDataGridViewImageColumn.Width = 230;
            // 
            // burgerBindingSource
            // 
            this.burgerBindingSource.DataMember = "Burger";
            this.burgerBindingSource.DataSource = this.fOS_DatabaseDataSet;
            // 
            // fOS_DatabaseDataSet
            // 
            this.fOS_DatabaseDataSet.DataSetName = "FOS_DatabaseDataSet";
            this.fOS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // burgerTableAdapter
            // 
            this.burgerTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(993, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 25);
            this.label1.TabIndex = 49;
            this.label1.Text = "-";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("HP Simplified", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(1014, 238);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(47, 30);
            this.textBox2.TabIndex = 47;
            this.textBox2.Text = "100";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("HP Simplified", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(942, 238);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 30);
            this.textBox1.TabIndex = 46;
            this.textBox1.Text = "0";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "All Items",
            "Burger",
            "Drink",
            "Set Menu",
            "Dessert",
            "Extras"});
            this.metroComboBox1.DisplayFocus = true;
            this.metroComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "All Items",
            "Burger",
            "Drink",
            "ComboMeal",
            "Dessert",
            "Extras"});
            this.metroComboBox1.Location = new System.Drawing.Point(268, 240);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.PromptText = "All Items";
            this.metroComboBox1.Size = new System.Drawing.Size(211, 29);
            this.metroComboBox1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroComboBox1.TabIndex = 45;
            this.metroComboBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // DeleteFood
            // 
            this.DeleteFood.Activecolor = System.Drawing.Color.White;
            this.DeleteFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.DeleteFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeleteFood.BorderRadius = 5;
            this.DeleteFood.ButtonText = "SEARCH";
            this.DeleteFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteFood.DisabledColor = System.Drawing.Color.Gray;
            this.DeleteFood.Font = new System.Drawing.Font("HP Simplified", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteFood.ForeColor = System.Drawing.Color.Black;
            this.DeleteFood.Iconcolor = System.Drawing.Color.Transparent;
            this.DeleteFood.Iconimage = null;
            this.DeleteFood.Iconimage_right = null;
            this.DeleteFood.Iconimage_right_Selected = null;
            this.DeleteFood.Iconimage_Selected = null;
            this.DeleteFood.IconMarginLeft = 0;
            this.DeleteFood.IconMarginRight = 0;
            this.DeleteFood.IconRightVisible = true;
            this.DeleteFood.IconRightZoom = 0D;
            this.DeleteFood.IconVisible = true;
            this.DeleteFood.IconZoom = 90D;
            this.DeleteFood.IsTab = false;
            this.DeleteFood.Location = new System.Drawing.Point(1078, 238);
            this.DeleteFood.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.DeleteFood.Name = "DeleteFood";
            this.DeleteFood.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.DeleteFood.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(0)))));
            this.DeleteFood.OnHoverTextColor = System.Drawing.Color.Black;
            this.DeleteFood.selected = false;
            this.DeleteFood.Size = new System.Drawing.Size(115, 31);
            this.DeleteFood.TabIndex = 50;
            this.DeleteFood.Text = "SEARCH";
            this.DeleteFood.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteFood.Textcolor = System.Drawing.Color.Black;
            this.DeleteFood.TextFont = new System.Drawing.Font("HP Simplified", 18F, System.Drawing.FontStyle.Bold);
            this.DeleteFood.Click += new System.EventHandler(this.Search);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("HP Simplified", 20F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(844, 238);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(94, 32);
            this.bunifuCustomLabel1.TabIndex = 51;
            this.bunifuCustomLabel1.Text = "PRICE :";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("HP Simplified", 20F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(184, 239);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(87, 32);
            this.bunifuCustomLabel2.TabIndex = 52;
            this.bunifuCustomLabel2.Text = "TYPE :";
            // 
            // LogOut
            // 
            this.LogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOut.Image = global::GUI.Properties.Resources.Log_Out;
            this.LogOut.Location = new System.Drawing.Point(1302, 30);
            this.LogOut.Name = "LogOut";
            this.LogOut.Size = new System.Drawing.Size(37, 38);
            this.LogOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogOut.TabIndex = 53;
            this.LogOut.TabStop = false;
            this.LogOut.Click += new System.EventHandler(this.LogOutClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("HP Simplified", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(556, 238);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(242, 32);
            this.textBox3.TabIndex = 55;
            this.textBox3.KeyUp += new System.Windows.Forms.KeyEventHandler(this.SearchKey);
            // 
            // FoodList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.LogOut);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.DeleteFood);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.BurgerPanel);
            this.Controls.Add(this.FoodListLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FoodList";
            this.Text = "FoodList";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FoodList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.BurgerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FoodGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.burgerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOS_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuCustomLabel FoodListLabel;
        private Bunifu.Framework.UI.BunifuCustomLabel Title;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel BurgerPanel;
        private System.Windows.Forms.DataGridView FoodGridView;
        private FOS_DatabaseDataSet fOS_DatabaseDataSet;
        private System.Windows.Forms.BindingSource burgerBindingSource;
        private FOS_DatabaseDataSetTableAdapters.BurgerTableAdapter burgerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foodTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imageDataGridViewImageColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private Bunifu.Framework.UI.BunifuFlatButton DeleteFood;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.PictureBox LogOut;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox3;
    }
}