namespace GUI
{
    partial class ApproveSale
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MemoGridView = new System.Windows.Forms.DataGridView();
            this.fOS_DatabaseDataSet = new GUI.FOS_DatabaseDataSet();
            this.memoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.memoTableAdapter = new GUI.FOS_DatabaseDataSetTableAdapters.MemoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ApprovalButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.memoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MemoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOS_DatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("HP Simplified", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(37, 190);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(175, 41);
            this.Title.TabIndex = 21;
            this.Title.Text = "EMPLOYEE";
            // 
            // Logo
            // 
            this.Logo.Image = global::GUI.Properties.Resources.images1;
            this.Logo.Location = new System.Drawing.Point(43, 26);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(173, 161);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Logo.TabIndex = 20;
            this.Logo.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MemoGridView);
            this.panel1.Location = new System.Drawing.Point(307, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(635, 543);
            this.panel1.TabIndex = 22;
            // 
            // MemoGridView
            // 
            this.MemoGridView.AutoGenerateColumns = false;
            this.MemoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MemoGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memoIDDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.paidDataGridViewTextBoxColumn});
            this.MemoGridView.DataSource = this.memoBindingSource;
            this.MemoGridView.Location = new System.Drawing.Point(0, 0);
            this.MemoGridView.Name = "MemoGridView";
            this.MemoGridView.Size = new System.Drawing.Size(615, 543);
            this.MemoGridView.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(969, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 23;
            this.label1.Text = "MemoId :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1059, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 30);
            this.textBox1.TabIndex = 24;
            // 
            // ApprovalButton
            // 
            this.ApprovalButton.Activecolor = System.Drawing.Color.White;
            this.ApprovalButton.BackColor = System.Drawing.Color.White;
            this.ApprovalButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ApprovalButton.BorderRadius = 5;
            this.ApprovalButton.ButtonText = "Approve";
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
            this.ApprovalButton.Location = new System.Drawing.Point(1118, 177);
            this.ApprovalButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.ApprovalButton.Name = "ApprovalButton";
            this.ApprovalButton.Normalcolor = System.Drawing.Color.White;
            this.ApprovalButton.OnHovercolor = System.Drawing.Color.White;
            this.ApprovalButton.OnHoverTextColor = System.Drawing.Color.Black;
            this.ApprovalButton.selected = false;
            this.ApprovalButton.Size = new System.Drawing.Size(158, 54);
            this.ApprovalButton.TabIndex = 42;
            this.ApprovalButton.Text = "Approve";
            this.ApprovalButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ApprovalButton.Textcolor = System.Drawing.Color.Black;
            this.ApprovalButton.TextFont = new System.Drawing.Font("HP Simplified", 25F, System.Drawing.FontStyle.Bold);
            this.ApprovalButton.Click += new System.EventHandler(this.ApproveClick);
            // 
            // memoIDDataGridViewTextBoxColumn
            // 
            this.memoIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.memoIDDataGridViewTextBoxColumn.DataPropertyName = "MemoID";
            this.memoIDDataGridViewTextBoxColumn.FillWeight = 150F;
            this.memoIDDataGridViewTextBoxColumn.HeaderText = "MemoID";
            this.memoIDDataGridViewTextBoxColumn.Name = "memoIDDataGridViewTextBoxColumn";
            this.memoIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.FillWeight = 150F;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.FillWeight = 150F;
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // paidDataGridViewTextBoxColumn
            // 
            this.paidDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.paidDataGridViewTextBoxColumn.DataPropertyName = "Paid";
            this.paidDataGridViewTextBoxColumn.FillWeight = 120F;
            this.paidDataGridViewTextBoxColumn.HeaderText = "Paid";
            this.paidDataGridViewTextBoxColumn.Name = "paidDataGridViewTextBoxColumn";
            this.paidDataGridViewTextBoxColumn.Width = 120;
            // 
            // ApproveSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.ApprovalButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Logo);
            this.Font = new System.Drawing.Font("HP Simplified", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ApproveSale";
            this.Text = "ApproveSale";
            this.Load += new System.EventHandler(this.ApproveSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MemoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fOS_DatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel Title;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView MemoGridView;
        private FOS_DatabaseDataSet fOS_DatabaseDataSet;
        private System.Windows.Forms.BindingSource memoBindingSource;
        private FOS_DatabaseDataSetTableAdapters.MemoTableAdapter memoTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn memoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paidDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuFlatButton ApprovalButton;
    }
}