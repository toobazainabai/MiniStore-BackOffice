namespace App.WindowsApp.Views
{
    partial class CustomerView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblCustomer = new TableLayoutPanel();
            tsCustommer = new ToolStrip();
            tsbtnAdd = new ToolStripButton();
            tsbtnEdit = new ToolStripButton();
            tsbtnView = new ToolStripButton();
            tsbtnDelete = new ToolStripButton();
            tsSeperator = new ToolStripSeparator();
            tsbtnRefresh = new ToolStripButton();
            flpSearch = new FlowLayoutPanel();
            lblSearch = new Label();
            txtboxSerach = new TextBox();
            lblCount = new Label();
            pnlCustomerData = new Panel();
            dgvCustomers = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            colEmail = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            tblCustomer.SuspendLayout();
            tsCustommer.SuspendLayout();
            flpSearch.SuspendLayout();
            pnlCustomerData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            SuspendLayout();
            // 
            // tblCustomer
            // 
            tblCustomer.BackColor = SystemColors.Window;
            tblCustomer.ColumnCount = 1;
            tblCustomer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblCustomer.Controls.Add(tsCustommer, 0, 0);
            tblCustomer.Controls.Add(flpSearch, 0, 1);
            tblCustomer.Controls.Add(pnlCustomerData, 0, 2);
            tblCustomer.Dock = DockStyle.Fill;
            tblCustomer.Location = new Point(0, 0);
            tblCustomer.Name = "tblCustomer";
            tblCustomer.RowCount = 3;
            tblCustomer.RowStyles.Add(new RowStyle(SizeType.Percent, 10.2359123F));
            tblCustomer.RowStyles.Add(new RowStyle(SizeType.Percent, 10.1942587F));
            tblCustomer.RowStyles.Add(new RowStyle(SizeType.Percent, 79.56983F));
            tblCustomer.Size = new Size(711, 381);
            tblCustomer.TabIndex = 0;
            tblCustomer.Paint += tableLayoutPanel1_Paint;
            // 
            // tsCustommer
            // 
            tsCustommer.Items.AddRange(new ToolStripItem[] { tsbtnAdd, tsbtnEdit, tsbtnView, tsbtnDelete, tsSeperator, tsbtnRefresh });
            tsCustommer.Location = new Point(0, 0);
            tsCustommer.Name = "tsCustommer";
            tsCustommer.Size = new Size(711, 25);
            tsCustommer.TabIndex = 0;
            tsCustommer.Text = "toolStrip1";
            tsCustommer.ItemClicked += tsCustommer_ItemClicked;
            // 
            // tsbtnAdd
            // 
            tsbtnAdd.Image = Properties.Resources.ico_Add;
            tsbtnAdd.ImageTransparentColor = Color.Magenta;
            tsbtnAdd.Name = "tsbtnAdd";
            tsbtnAdd.Size = new Size(49, 22);
            tsbtnAdd.Text = "Add";
            tsbtnAdd.Click += tsbtnAdd_Click;
            // 
            // tsbtnEdit
            // 
            tsbtnEdit.Image = Properties.Resources.ico_edit;
            tsbtnEdit.ImageTransparentColor = Color.Magenta;
            tsbtnEdit.Name = "tsbtnEdit";
            tsbtnEdit.Size = new Size(47, 22);
            tsbtnEdit.Text = "Edit";
            tsbtnEdit.Click += tsbtnEdit_Click;
            // 
            // tsbtnView
            // 
            tsbtnView.Image = Properties.Resources.ico_View;
            tsbtnView.ImageTransparentColor = Color.Magenta;
            tsbtnView.Name = "tsbtnView";
            tsbtnView.Size = new Size(52, 22);
            tsbtnView.Text = "View";
            tsbtnView.Click += tsbtnView_Click;
            // 
            // tsbtnDelete
            // 
            tsbtnDelete.Image = Properties.Resources.ico_Delete;
            tsbtnDelete.ImageTransparentColor = Color.Magenta;
            tsbtnDelete.Name = "tsbtnDelete";
            tsbtnDelete.Size = new Size(60, 22);
            tsbtnDelete.Text = "Delete";
            tsbtnDelete.Click += tsbtnDelete_Click;
            // 
            // tsSeperator
            // 
            tsSeperator.Name = "tsSeperator";
            tsSeperator.Size = new Size(6, 25);
            // 
            // tsbtnRefresh
            // 
            tsbtnRefresh.Image = Properties.Resources.ico_Refresh;
            tsbtnRefresh.ImageTransparentColor = Color.Magenta;
            tsbtnRefresh.Name = "tsbtnRefresh";
            tsbtnRefresh.Size = new Size(66, 22);
            tsbtnRefresh.Text = "Refresh";
            tsbtnRefresh.Click += tsbtnRefresh_Click;
            // 
            // flpSearch
            // 
            flpSearch.Controls.Add(lblSearch);
            flpSearch.Controls.Add(txtboxSerach);
            flpSearch.Controls.Add(lblCount);
            flpSearch.Dock = DockStyle.Fill;
            flpSearch.Location = new Point(3, 41);
            flpSearch.Name = "flpSearch";
            flpSearch.Size = new Size(705, 32);
            flpSearch.TabIndex = 3;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Dock = DockStyle.Top;
            lblSearch.Location = new Point(3, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(42, 15);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "Search";
            // 
            // txtboxSerach
            // 
            txtboxSerach.Dock = DockStyle.Top;
            txtboxSerach.Location = new Point(51, 3);
            txtboxSerach.Name = "txtboxSerach";
            txtboxSerach.Size = new Size(394, 23);
            txtboxSerach.TabIndex = 4;
            txtboxSerach.TextChanged += txtboxSerach_TextChanged;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Dock = DockStyle.Top;
            lblCount.Location = new Point(451, 0);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(49, 15);
            lblCount.TabIndex = 3;
            lblCount.Text = "Count 0";
            // 
            // pnlCustomerData
            // 
            pnlCustomerData.Controls.Add(dgvCustomers);
            pnlCustomerData.Dock = DockStyle.Fill;
            pnlCustomerData.Location = new Point(3, 79);
            pnlCustomerData.Name = "pnlCustomerData";
            pnlCustomerData.Size = new Size(705, 299);
            pnlCustomerData.TabIndex = 4;
            // 
            // dgvCustomers
            // 
            dgvCustomers.AllowUserToAddRows = false;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.BackgroundColor = SystemColors.Window;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Columns.AddRange(new DataGridViewColumn[] { colId, colName, colPhone, colEmail, colAddress });
            dgvCustomers.Dock = DockStyle.Fill;
            dgvCustomers.Location = new Point(0, 0);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.ReadOnly = true;
            dgvCustomers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCustomers.Size = new Size(705, 299);
            dgvCustomers.TabIndex = 0;
            // 
            // colId
            // 
            colId.DataPropertyName = "id";
            colId.HeaderText = "ID";
            colId.Name = "colId";
            colId.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colPhone
            // 
            colPhone.DataPropertyName = "Phone";
            colPhone.HeaderText = "Phone";
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            // 
            // colEmail
            // 
            colEmail.DataPropertyName = "Email";
            colEmail.HeaderText = "Email";
            colEmail.Name = "colEmail";
            colEmail.ReadOnly = true;
            // 
            // colAddress
            // 
            colAddress.DataPropertyName = "Address";
            colAddress.HeaderText = "Address";
            colAddress.Name = "colAddress";
            colAddress.ReadOnly = true;
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblCustomer);
            Name = "CustomerView";
            Size = new Size(711, 381);
            tblCustomer.ResumeLayout(false);
            tblCustomer.PerformLayout();
            tsCustommer.ResumeLayout(false);
            tsCustommer.PerformLayout();
            flpSearch.ResumeLayout(false);
            flpSearch.PerformLayout();
            pnlCustomerData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblCustomer;
        private ToolStrip tsCustommer;
        private ToolStripButton tsbtnAdd;
        private ToolStripButton tsbtnEdit;
        private ToolStripButton tsbtnView;
        private ToolStripButton tsbtnDelete;
        private ToolStripSeparator tsSeperator;
        private ToolStripButton tsbtnRefresh;
        private FlowLayoutPanel flpSearch;
        private Label lblSearch;
        private TextBox txtboxSerach;
        private Label lblCount;
        private Panel pnlCustomerData;
        private DataGridView dgvCustomers;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colPhone;
        private DataGridViewTextBoxColumn colEmail;
        private DataGridViewTextBoxColumn colAddress;
    }
}
