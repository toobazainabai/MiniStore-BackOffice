namespace App.WinForms.Views
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
            this.tblProducts = new System.Windows.Forms.TableLayoutPanel();
            this.tblFilters = new System.Windows.Forms.TableLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblStockStatus = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbStockStatus = new System.Windows.Forms.ComboBox();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.pnltsProduct = new System.Windows.Forms.Panel();
            this.tsProducts = new System.Windows.Forms.ToolStrip();
            this.tsAdd = new System.Windows.Forms.ToolStripButton();
            this.tsEdit = new System.Windows.Forms.ToolStripButton();
            this.tsView = new System.Windows.Forms.ToolStripButton();
            this.tsDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStrpseprator = new System.Windows.Forms.ToolStripSeparator();
            this.tsRefresh = new System.Windows.Forms.ToolStripButton();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblProducts.SuspendLayout();
            this.tblFilters.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.pnltsProduct.SuspendLayout();
            this.tsProducts.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tblProducts
            // 
            this.tblProducts.ColumnCount = 1;
            this.tblProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblProducts.Controls.Add(this.tblFilters, 0, 1);
            this.tblProducts.Controls.Add(this.pnlFilters, 0, 0);
            this.tblProducts.Controls.Add(this.pnlGrid, 0, 2);
            this.tblProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblProducts.Location = new System.Drawing.Point(0, 0);
            this.tblProducts.Name = "tblProducts";
            this.tblProducts.RowCount = 3;
            this.tblProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tblProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tblProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblProducts.Size = new System.Drawing.Size(719, 465);
            this.tblProducts.TabIndex = 0;
            // 
            // tblFilters
            // 
            this.tblFilters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tblFilters.BackColor = System.Drawing.Color.White;
            this.tblFilters.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblFilters.ColumnCount = 3;
            this.tblFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tblFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblFilters.Controls.Add(this.lblSearch, 0, 0);
            this.tblFilters.Controls.Add(this.lblCategory, 1, 0);
            this.tblFilters.Controls.Add(this.lblStockStatus, 2, 0);
            this.tblFilters.Controls.Add(this.txtSearch, 0, 1);
            this.tblFilters.Controls.Add(this.cmbCategory, 1, 1);
            this.tblFilters.Controls.Add(this.cmbStockStatus, 2, 1);
            this.tblFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblFilters.Location = new System.Drawing.Point(3, 58);
            this.tblFilters.Name = "tblFilters";
            this.tblFilters.RowCount = 2;
            this.tblFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblFilters.Size = new System.Drawing.Size(713, 64);
            this.tblFilters.TabIndex = 2;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.lblSearch.Location = new System.Drawing.Point(4, 1);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(277, 30);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.lblCategory.Location = new System.Drawing.Point(288, 1);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(206, 30);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // lblStockStatus
            // 
            this.lblStockStatus.AutoSize = true;
            this.lblStockStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStockStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(100)))), ((int)(((byte)(110)))));
            this.lblStockStatus.Location = new System.Drawing.Point(501, 1);
            this.lblStockStatus.Name = "lblStockStatus";
            this.lblStockStatus.Size = new System.Drawing.Size(208, 30);
            this.lblStockStatus.TabIndex = 2;
            this.lblStockStatus.Text = "StockStatus";
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSearch.Location = new System.Drawing.Point(4, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(277, 20);
            this.txtSearch.TabIndex = 3;
            // 
            // cmbCategory
            // 
            this.cmbCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(288, 35);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(206, 21);
            this.cmbCategory.TabIndex = 4;
            // 
            // cmbStockStatus
            // 
            this.cmbStockStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbStockStatus.FormattingEnabled = true;
            this.cmbStockStatus.Location = new System.Drawing.Point(501, 35);
            this.cmbStockStatus.Name = "cmbStockStatus";
            this.cmbStockStatus.Size = new System.Drawing.Size(208, 21);
            this.cmbStockStatus.TabIndex = 5;
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.pnltsProduct);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilters.Location = new System.Drawing.Point(3, 3);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Padding = new System.Windows.Forms.Padding(12, 10, 12, 19);
            this.pnlFilters.Size = new System.Drawing.Size(713, 49);
            this.pnlFilters.TabIndex = 0;
            // 
            // pnltsProduct
            // 
            this.pnltsProduct.Controls.Add(this.tsProducts);
            this.pnltsProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltsProduct.Location = new System.Drawing.Point(12, 10);
            this.pnltsProduct.Name = "pnltsProduct";
            this.pnltsProduct.Size = new System.Drawing.Size(689, 37);
            this.pnltsProduct.TabIndex = 2;
            // 
            // tsProducts
            // 
            this.tsProducts.BackColor = System.Drawing.Color.White;
            this.tsProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAdd,
            this.tsEdit,
            this.tsView,
            this.tsDelete,
            this.toolStrpseprator,
            this.tsRefresh});
            this.tsProducts.Location = new System.Drawing.Point(0, 0);
            this.tsProducts.Name = "tsProducts";
            this.tsProducts.Size = new System.Drawing.Size(689, 37);
            this.tsProducts.TabIndex = 1;
            this.tsProducts.Text = "toolStrip1";
            // 
            // tsAdd
            // 
            this.tsAdd.Image = global::App.WinForms.Properties.Resources.ico_Add;
            this.tsAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAdd.Name = "tsAdd";
            this.tsAdd.Size = new System.Drawing.Size(49, 34);
            this.tsAdd.Text = "Add";
            // 
            // tsEdit
            // 
            this.tsEdit.Image = global::App.WinForms.Properties.Resources.ico_edit;
            this.tsEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsEdit.Name = "tsEdit";
            this.tsEdit.Size = new System.Drawing.Size(47, 34);
            this.tsEdit.Text = "Edit";
            // 
            // tsView
            // 
            this.tsView.Image = global::App.WinForms.Properties.Resources.ico_View;
            this.tsView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsView.Name = "tsView";
            this.tsView.Size = new System.Drawing.Size(52, 34);
            this.tsView.Text = "View";
            // 
            // tsDelete
            // 
            this.tsDelete.Image = global::App.WinForms.Properties.Resources.ico_Delete;
            this.tsDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsDelete.Name = "tsDelete";
            this.tsDelete.Size = new System.Drawing.Size(60, 34);
            this.tsDelete.Text = "Delete";
            // 
            // toolStrpseprator
            // 
            this.toolStrpseprator.Name = "toolStrpseprator";
            this.toolStrpseprator.Size = new System.Drawing.Size(6, 37);
            // 
            // tsRefresh
            // 
            this.tsRefresh.Image = global::App.WinForms.Properties.Resources.ico_Refresh;
            this.tsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRefresh.Name = "tsRefresh";
            this.tsRefresh.Size = new System.Drawing.Size(66, 34);
            this.tsRefresh.Text = "Refresh";
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Controls.Add(this.dgvProducts);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(3, 128);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(12);
            this.pnlGrid.Size = new System.Drawing.Size(713, 334);
            this.pnlGrid.TabIndex = 1;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colCategory,
            this.colPrice,
            this.colStock,
            this.colStatus});
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(12, 12);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(689, 310);
            this.dgvProducts.TabIndex = 0;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colCategory
            // 
            this.colCategory.HeaderText = "Category";
            this.colCategory.Name = "colCategory";
            this.colCategory.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Stock";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            // 
            // colStatus
            // 
            this.colStatus.HeaderText = "Status";
            this.colStatus.Name = "colStatus";
            this.colStatus.ReadOnly = true;
            // 
            // ProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblProducts);
            this.Name = "ProductsView";
            this.Size = new System.Drawing.Size(719, 465);
            this.tblProducts.ResumeLayout(false);
            this.tblFilters.ResumeLayout(false);
            this.tblFilters.PerformLayout();
            this.pnlFilters.ResumeLayout(false);
            this.pnltsProduct.ResumeLayout(false);
            this.pnltsProduct.PerformLayout();
            this.tsProducts.ResumeLayout(false);
            this.tsProducts.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblProducts;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStatus;
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
    }
}
