namespace App.WindowsApp.Views
{
    partial class ProductsView
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
            tblProducts = new TableLayoutPanel();
            tblFilters = new TableLayoutPanel();
            lblSearch = new Label();
            lblCategory = new Label();
            lblStockStatus = new Label();
            txtSearch = new TextBox();
            cmbCategory = new ComboBox();
            cmbStockStatus = new ComboBox();
            pnlFilters = new Panel();
            pnltsProduct = new Panel();
            tsProducts = new ToolStrip();
            tsAdd = new ToolStripButton();
            tsEdit = new ToolStripButton();
            tsView = new ToolStripButton();
            tsDelete = new ToolStripButton();
            toolStrpseprator = new ToolStripSeparator();
            tsRefresh = new ToolStripButton();
            pnlGrid = new Panel();
            dgvProducts = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colCategory = new DataGridViewTextBoxColumn();
            colPrice = new DataGridViewTextBoxColumn();
            colStock = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            tblProducts.SuspendLayout();
            tblFilters.SuspendLayout();
            pnlFilters.SuspendLayout();
            pnltsProduct.SuspendLayout();
            tsProducts.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // tblProducts
            // 
            tblProducts.ColumnCount = 1;
            tblProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblProducts.Controls.Add(tblFilters, 0, 1);
            tblProducts.Controls.Add(pnlFilters, 0, 0);
            tblProducts.Controls.Add(pnlGrid, 0, 2);
            tblProducts.Dock = DockStyle.Fill;
            tblProducts.Location = new Point(0, 0);
            tblProducts.Margin = new Padding(4, 3, 4, 3);
            tblProducts.Name = "tblProducts";
            tblProducts.RowCount = 3;
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 81F));
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblProducts.Size = new Size(839, 537);
            tblProducts.TabIndex = 0;
            // 
            // tblFilters
            // 
            tblFilters.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblFilters.BackColor = Color.White;
            tblFilters.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tblFilters.ColumnCount = 3;
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblFilters.Controls.Add(lblSearch, 0, 0);
            tblFilters.Controls.Add(lblCategory, 1, 0);
            tblFilters.Controls.Add(lblStockStatus, 2, 0);
            tblFilters.Controls.Add(txtSearch, 0, 1);
            tblFilters.Controls.Add(cmbCategory, 1, 1);
            tblFilters.Controls.Add(cmbStockStatus, 2, 1);
            tblFilters.Dock = DockStyle.Fill;
            tblFilters.Location = new Point(4, 66);
            tblFilters.Margin = new Padding(4, 3, 4, 3);
            tblFilters.Name = "tblFilters";
            tblFilters.RowCount = 2;
            tblFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblFilters.Size = new Size(831, 75);
            tblFilters.TabIndex = 2;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Dock = DockStyle.Fill;
            lblSearch.ForeColor = Color.FromArgb(102, 100, 110);
            lblSearch.Location = new Point(5, 1);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(322, 36);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.ForeColor = Color.FromArgb(102, 100, 110);
            lblCategory.Location = new Point(336, 1);
            lblCategory.Margin = new Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(240, 36);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category";
            // 
            // lblStockStatus
            // 
            lblStockStatus.AutoSize = true;
            lblStockStatus.Dock = DockStyle.Fill;
            lblStockStatus.ForeColor = Color.FromArgb(102, 100, 110);
            lblStockStatus.Location = new Point(585, 1);
            lblStockStatus.Margin = new Padding(4, 0, 4, 0);
            lblStockStatus.Name = "lblStockStatus";
            lblStockStatus.Size = new Size(241, 36);
            lblStockStatus.TabIndex = 2;
            lblStockStatus.Text = "StockStatus";
            // 
            // txtSearch
            // 
            txtSearch.Dock = DockStyle.Fill;
            txtSearch.Location = new Point(5, 41);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(322, 23);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // cmbCategory
            // 
            cmbCategory.Dock = DockStyle.Fill;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(336, 41);
            cmbCategory.Margin = new Padding(4, 3, 4, 3);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(240, 23);
            cmbCategory.TabIndex = 4;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // cmbStockStatus
            // 
            cmbStockStatus.Dock = DockStyle.Fill;
            cmbStockStatus.FormattingEnabled = true;
            cmbStockStatus.Location = new Point(585, 41);
            cmbStockStatus.Margin = new Padding(4, 3, 4, 3);
            cmbStockStatus.Name = "cmbStockStatus";
            cmbStockStatus.Size = new Size(241, 23);
            cmbStockStatus.TabIndex = 5;
            cmbStockStatus.SelectedIndexChanged += cmbStockStatus_SelectedIndexChanged;
            // 
            // pnlFilters
            // 
            pnlFilters.Controls.Add(pnltsProduct);
            pnlFilters.Dock = DockStyle.Fill;
            pnlFilters.Location = new Point(4, 3);
            pnlFilters.Margin = new Padding(4, 3, 4, 3);
            pnlFilters.Name = "pnlFilters";
            pnlFilters.Padding = new Padding(14, 12, 14, 22);
            pnlFilters.Size = new Size(831, 57);
            pnlFilters.TabIndex = 0;
            // 
            // pnltsProduct
            // 
            pnltsProduct.Controls.Add(tsProducts);
            pnltsProduct.Dock = DockStyle.Top;
            pnltsProduct.Location = new Point(14, 12);
            pnltsProduct.Margin = new Padding(4, 3, 4, 3);
            pnltsProduct.Name = "pnltsProduct";
            pnltsProduct.Size = new Size(803, 43);
            pnltsProduct.TabIndex = 2;
            // 
            // tsProducts
            // 
            tsProducts.BackColor = Color.White;
            tsProducts.Dock = DockStyle.Fill;
            tsProducts.Items.AddRange(new ToolStripItem[] { tsAdd, tsEdit, tsView, tsDelete, toolStrpseprator, tsRefresh });
            tsProducts.Location = new Point(0, 0);
            tsProducts.Name = "tsProducts";
            tsProducts.Size = new Size(803, 43);
            tsProducts.TabIndex = 1;
            tsProducts.Text = "toolStrip1";
            // 
            // tsAdd
            // 
            tsAdd.Image = Properties.Resources.ico_Add;
            tsAdd.ImageTransparentColor = Color.Magenta;
            tsAdd.Name = "tsAdd";
            tsAdd.Size = new Size(49, 40);
            tsAdd.Text = "Add";
            tsAdd.Click += tsAdd_Click;
            // 
            // tsEdit
            // 
            tsEdit.Image = Properties.Resources.ico_edit;
            tsEdit.ImageTransparentColor = Color.Magenta;
            tsEdit.Name = "tsEdit";
            tsEdit.Size = new Size(47, 40);
            tsEdit.Text = "Edit";
            tsEdit.Click += tsEdit_Click;
            // 
            // tsView
            // 
            tsView.Image = Properties.Resources.ico_View;
            tsView.ImageTransparentColor = Color.Magenta;
            tsView.Name = "tsView";
            tsView.Size = new Size(52, 40);
            tsView.Text = "View";
            tsView.Click += tsView_Click;
            // 
            // tsDelete
            // 
            tsDelete.Image = Properties.Resources.ico_Delete;
            tsDelete.ImageTransparentColor = Color.Magenta;
            tsDelete.Name = "tsDelete";
            tsDelete.Size = new Size(60, 40);
            tsDelete.Text = "Delete";
            // 
            // toolStrpseprator
            // 
            toolStrpseprator.Name = "toolStrpseprator";
            toolStrpseprator.Size = new Size(6, 43);
            // 
            // tsRefresh
            // 
            tsRefresh.Image = Properties.Resources.ico_Refresh;
            tsRefresh.ImageTransparentColor = Color.Magenta;
            tsRefresh.Name = "tsRefresh";
            tsRefresh.Size = new Size(66, 40);
            tsRefresh.Text = "Refresh";
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.White;
            pnlGrid.Controls.Add(dgvProducts);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(4, 147);
            pnlGrid.Margin = new Padding(4, 3, 4, 3);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(14);
            pnlGrid.Size = new Size(831, 387);
            pnlGrid.TabIndex = 1;
            // 
            // dgvProducts
            // 
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { colID, colName, colCategory, colPrice, colStock, colStatus });
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(14, 14);
            dgvProducts.Margin = new Padding(4, 3, 4, 3);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(803, 359);
            dgvProducts.TabIndex = 0;
            dgvProducts.CellContentClick += dgvProducts_CellContentClick;
            // 
            // colID
            // 
            colID.DataPropertyName = "id";
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            // 
            // colName
            // 
            colName.DataPropertyName = "Name";
            colName.HeaderText = "Name";
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colCategory
            // 
            colCategory.DataPropertyName = "Category";
            colCategory.HeaderText = "Category";
            colCategory.Name = "colCategory";
            colCategory.ReadOnly = true;
            // 
            // colPrice
            // 
            colPrice.DataPropertyName = "Price";
            colPrice.HeaderText = "Price";
            colPrice.Name = "colPrice";
            colPrice.ReadOnly = true;
            // 
            // colStock
            // 
            colStock.DataPropertyName = "Stock";
            colStock.HeaderText = "Stock";
            colStock.Name = "colStock";
            colStock.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblProducts);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ProductsView";
            Size = new Size(839, 537);
            Load += ProductsView_Load;
            tblProducts.ResumeLayout(false);
            tblFilters.ResumeLayout(false);
            tblFilters.PerformLayout();
            pnlFilters.ResumeLayout(false);
            pnltsProduct.ResumeLayout(false);
            pnltsProduct.PerformLayout();
            tsProducts.ResumeLayout(false);
            tsProducts.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblProducts;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.TableLayoutPanel tblFilters;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblStockStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbStockStatus;
        private System.Windows.Forms.Panel pnltsProduct;
        private System.Windows.Forms.ToolStrip tsProducts;
        private System.Windows.Forms.ToolStripButton tsAdd;
        private System.Windows.Forms.ToolStripButton tsEdit;
        private System.Windows.Forms.ToolStripButton tsView;
        private System.Windows.Forms.ToolStripButton tsDelete;
        private System.Windows.Forms.ToolStripSeparator toolStrpseprator;
        private System.Windows.Forms.ToolStripButton tsRefresh;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colCategory;
        private DataGridViewTextBoxColumn colPrice;
        private DataGridViewTextBoxColumn colStock;
        private DataGridViewTextBoxColumn colStatus;
    }
}
