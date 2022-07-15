namespace GUI
{
    partial class SellApprove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SellApprove));
            this.Logo = new System.Windows.Forms.PictureBox();
            this.Title = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.fOS_DatabaseDataSet = new GUI.FOS_DatabaseDataSet();
            this.memoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memoTableAdapter = new GUI.FOS_DatabaseDataSetTableAdapters.MemoTableAdapter();
            this.MemoGridView = new System.Windows.Forms.DataGridView();
            this.memoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FoodListLabel = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Back = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ApprovalButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOS_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Back)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = global::GUI.Properties.Resources.images1;
            this.Logo.Location = new System.Drawing.Point(42, 32);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(165, 155);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Logo.TabIndex = 22;
            this.Logo.TabStop = false;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("HP Simplified", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(8, 190);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(241, 41);
            this.Title.TabIndex = 23;
            this.Title.Text = "APPROVE  SELL";
            // 
            // fOS_DatabaseDataSet
            // 
            this.fOS_DatabaseDataSet.DataSetName = "FOS_DatabaseDataSet";
            this.fOS_DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // memoBindingSource
            // 
            this.memoBindingSource.DataMember = "Memo";
            this.memoBindingSource.DataSource = this.fOS_DatabaseDataSet;
            // 
            // memoTableAdapter
            // 
            this.memoTableAdapter.ClearBeforeFill = true;
            // 
            // MemoGridView
            // 
            this.MemoGridView.AllowUserToAddRows = false;
            this.MemoGridView.AllowUserToDeleteRows = false;
            this.MemoGridView.AutoGenerateColumns = false;
            this.MemoGridView.BackgroundColor = System.Drawing.Color.White;
            this.MemoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memoIDDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.locationTypeDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.paidDataGridViewTextBoxColumn});
            this.MemoGridView.DataSource = this.memoBindingSource;
            this.MemoGridView.Location = new System.Drawing.Point(0, 0);
            this.MemoGridView.Name = "MemoGridView";
            this.MemoGridView.ReadOnly = true;
            this.MemoGridView.Size = new System.Drawing.Size(615, 348);
            this.MemoGridView.TabIndex = 0;
            this.MemoGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.C_Click);
            // 
            // memoIDDataGridViewTextBoxColumn
            // 
            this.memoIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.memoIDDataGridViewTextBoxColumn.DataPropertyName = "MemoID";
            this.memoIDDataGridViewTextBoxColumn.HeaderText = "MemoID";
            this.memoIDDataGridViewTextBoxColumn.Name = "memoIDDataGridViewTextBoxColumn";
            this.memoIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locationTypeDataGridViewTextBoxColumn
            // 
            this.locationTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.locationTypeDataGridViewTextBoxColumn.DataPropertyName = "LocationType";
            this.locationTypeDataGridViewTextBoxColumn.FillWeight = 140F;
            this.locationTypeDataGridViewTextBoxColumn.HeaderText = "LocationType";
            this.locationTypeDataGridViewTextBoxColumn.Name = "locationTypeDataGridViewTextBoxColumn";
            this.locationTypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationTypeDataGridViewTextBoxColumn.Width = 140;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.FillWeight = 130F;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 130;
            // 
            // paidDataGridViewTextBoxColumn
            // 
            this.paidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.paidDataGridViewTextBoxColumn.DataPropertyName = "Paid";
            this.paidDataGridViewTextBoxColumn.HeaderText = "Paid";
            this.paidDataGridViewTextBoxColumn.Name = "paidDataGridViewTextBoxColumn";
            this.paidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MemoGridView);
            this.panel1.Font = new System.Drawing.Font("HP Simplified", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(390, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 347);
            this.panel1.TabIndex = 24;
            // 
            // FoodListLabel
            // 
            this.FoodListLabel.AutoSize = true;
            this.FoodListLabel.Font = new System.Drawing.Font("HP Simplified", 60F, System.Drawing.FontStyle.Bold);
            this.FoodListLabel.ForeColor = System.Drawing.Color.White;
            this.FoodListLabel.Location = new System.Drawing.Point(502, 81);
            this.FoodListLabel.Name = "FoodListLabel";
            this.FoodListLabel.Size = new System.Drawing.Size(425, 92);
            this.FoodListLabel.TabIndex = 37;
            this.FoodListLabel.Text = "MEMO  LIST";
            // 
            // Back
            // 
            this.Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Back.Image = global::GUI.Properties.Resources.Log_Out;
            this.Back.Location = new System.Drawing.Point(1285, 38);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(40, 38);
            this.Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Back.TabIndex = 38;
            this.Back.TabStop = false;
            this.Back.Click += new System.EventHandler(this.BackClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ApprovalButton
            // 
            this.ApprovalButton.Activecolor = System.Drawing.Color.White;
            this.ApprovalButton.BackColor = System.Drawing.Color.White;
            this.ApprovalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ApprovalButton.BorderRadius = 5;
            this.ApprovalButton.ButtonText = "APPROVE";
            this.ApprovalButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApprovalButton.DisabledColor = System.Drawing.Color.Gray;
            this.ApprovalButton.Font = new System.Drawing.Font("HP Simplified", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApprovalButton.ForeColor = System.Drawing.Color.Black;
            this.ApprovalButton.Iconcolor = System.Drawing.Color.Transparent;
            this.ApprovalButton.Iconimage = null;
            this.ApprovalButton.Iconimage_right = null;
            this.ApprovalButton.Iconimage_right_Selected = null;
            this.ApprovalButton.Iconimage_Selected = null;
            this.ApprovalButton.IconMarginLeft = 0;
            this.ApprovalButton.IconMarginRight = 0;
            this.ApprovalButton.IconRightVisible = true;
            this.ApprovalButton.IconRightZoom = 0D;
            this.ApprovalButton.IconVisible = true;
            this.ApprovalButton.IconZoom = 90D;
            this.ApprovalButton.IsTab = false;
            this.ApprovalButton.Location = new System.Drawing.Point(609, 670);
            this.ApprovalButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.ApprovalButton.Name = "ApprovalButton";
            this.ApprovalButton.Normalcolor = System.Drawing.Color.White;
            this.ApprovalButton.OnHovercolor = System.Drawing.Color.White;
            this.ApprovalButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.ApprovalButton.selected = false;
            this.ApprovalButton.Size = new System.Drawing.Size(171, 60);
            this.ApprovalButton.TabIndex = 45;
            this.ApprovalButton.Text = "APPROVE";
            this.ApprovalButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ApprovalButton.Textcolor = System.Drawing.Color.Black;
            this.ApprovalButton.TextFont = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold);
            this.ApprovalButton.Click += new System.EventHandler(this.ApproveClick);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("HP Simplified", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(668, 607);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(175, 38);
            this.textBox1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("HP Simplified", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(536, 613);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 32);
            this.label1.TabIndex = 43;
            this.label1.Text = "MEMO ID :";
            // 
            // SellApprove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.ApprovalButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.FoodListLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SellApprove";
            this.Text = "SellApprove";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.SellApprove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOS_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Logo;
        private Bunifu.Framework.UI.BunifuCustomLabel Title;
        private FOS_DatabaseDataSet fOS_DatabaseDataSet;
        private System.Windows.Forms.BindingSource memoBindingSource;
        private FOS_DatabaseDataSetTableAdapters.MemoTableAdapter memoTableAdapter;
        private System.Windows.Forms.DataGridView MemoGridView;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomLabel FoodListLabel;
        private System.Windows.Forms.PictureBox Back;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuFlatButton ApprovalButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}