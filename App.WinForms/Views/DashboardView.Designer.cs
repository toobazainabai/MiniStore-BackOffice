namespace App.WinForms.Views
{
    partial class DashboardView
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
            this.pnlRecentOrder = new System.Windows.Forms.Panel();
            this.pnlLowStock = new System.Windows.Forms.Panel();
            this.flpKPI = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlRevenue = new System.Windows.Forms.Panel();
            this.lblRevenueT = new System.Windows.Forms.Label();
            this.lblRevenueV = new System.Windows.Forms.Label();
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.lblOrdersT = new System.Windows.Forms.Label();
            this.lblOrdersV = new System.Windows.Forms.Label();
            this.pnlSales = new System.Windows.Forms.Panel();
            this.llblSalesT = new System.Windows.Forms.Label();
            this.lblSalesV = new System.Windows.Forms.Label();
            this.tblDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.lvLowStock = new System.Windows.Forms.ListView();
            this.colProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblLowStock = new System.Windows.Forms.Label();
            this.pnlReOrders = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.colOrderid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCustomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblReOrders = new System.Windows.Forms.Label();
            this.pnlRecentOrder.SuspendLayout();
            this.pnlLowStock.SuspendLayout();
            this.flpKPI.SuspendLayout();
            this.pnlRevenue.SuspendLayout();
            this.pnlOrders.SuspendLayout();
            this.pnlSales.SuspendLayout();
            this.tblDashboard.SuspendLayout();
            this.pnlReOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRecentOrder
            // 
            this.pnlRecentOrder.Controls.Add(this.pnlReOrders);
            this.pnlRecentOrder.Location = new System.Drawing.Point(3, 336);
            this.pnlRecentOrder.Name = "pnlRecentOrder";
            this.pnlRecentOrder.Size = new System.Drawing.Size(775, 207);
            this.pnlRecentOrder.TabIndex = 2;
            this.pnlRecentOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRecentOrder_Paint);
            // 
            // pnlLowStock
            // 
            this.pnlLowStock.BackColor = System.Drawing.Color.White;
            this.pnlLowStock.Controls.Add(this.lblLowStock);
            this.pnlLowStock.Controls.Add(this.lvLowStock);
            this.pnlLowStock.Location = new System.Drawing.Point(3, 123);
            this.pnlLowStock.Name = "pnlLowStock";
            this.pnlLowStock.Size = new System.Drawing.Size(775, 207);
            this.pnlLowStock.TabIndex = 1;
            // 
            // flpKPI
            // 
            this.flpKPI.Controls.Add(this.pnlSales);
            this.flpKPI.Controls.Add(this.pnlOrders);
            this.flpKPI.Controls.Add(this.pnlRevenue);
            this.flpKPI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpKPI.Location = new System.Drawing.Point(3, 3);
            this.flpKPI.Name = "flpKPI";
            this.flpKPI.Size = new System.Drawing.Size(775, 114);
            this.flpKPI.TabIndex = 0;
            // 
            // pnlRevenue
            // 
            this.pnlRevenue.BackColor = System.Drawing.Color.White;
            this.pnlRevenue.Controls.Add(this.lblRevenueV);
            this.pnlRevenue.Controls.Add(this.lblRevenueT);
            this.pnlRevenue.Location = new System.Drawing.Point(476, 3);
            this.pnlRevenue.Name = "pnlRevenue";
            this.pnlRevenue.Size = new System.Drawing.Size(244, 100);
            this.pnlRevenue.TabIndex = 2;
            this.pnlRevenue.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlRevenue_Paint);
            // 
            // lblRevenueT
            // 
            this.lblRevenueT.AutoSize = true;
            this.lblRevenueT.Location = new System.Drawing.Point(19, 37);
            this.lblRevenueT.Name = "lblRevenueT";
            this.lblRevenueT.Size = new System.Drawing.Size(51, 13);
            this.lblRevenueT.TabIndex = 0;
            this.lblRevenueT.Text = "Revenue";
            // 
            // lblRevenueV
            // 
            this.lblRevenueV.AutoSize = true;
            this.lblRevenueV.Location = new System.Drawing.Point(149, 37);
            this.lblRevenueV.Name = "lblRevenueV";
            this.lblRevenueV.Size = new System.Drawing.Size(65, 13);
            this.lblRevenueV.TabIndex = 1;
            this.lblRevenueV.Text = "37,356 PKR";
            this.lblRevenueV.Click += new System.EventHandler(this.lblRevenueV_Click);
            // 
            // pnlOrders
            // 
            this.pnlOrders.BackColor = System.Drawing.Color.White;
            this.pnlOrders.Controls.Add(this.lblOrdersV);
            this.pnlOrders.Controls.Add(this.lblOrdersT);
            this.pnlOrders.Location = new System.Drawing.Point(238, 3);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(232, 100);
            this.pnlOrders.TabIndex = 1;
            this.pnlOrders.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlOrders_Paint);
            // 
            // lblOrdersT
            // 
            this.lblOrdersT.AutoSize = true;
            this.lblOrdersT.Location = new System.Drawing.Point(4, 37);
            this.lblOrdersT.Name = "lblOrdersT";
            this.lblOrdersT.Size = new System.Drawing.Size(38, 13);
            this.lblOrdersT.TabIndex = 0;
            this.lblOrdersT.Text = "Orders";
            // 
            // lblOrdersV
            // 
            this.lblOrdersV.AutoSize = true;
            this.lblOrdersV.Location = new System.Drawing.Point(164, 37);
            this.lblOrdersV.Name = "lblOrdersV";
            this.lblOrdersV.Size = new System.Drawing.Size(19, 13);
            this.lblOrdersV.TabIndex = 1;
            this.lblOrdersV.Text = "33";
            this.lblOrdersV.Click += new System.EventHandler(this.lblOrdersV_Click);
            // 
            // pnlSales
            // 
            this.pnlSales.BackColor = System.Drawing.Color.White;
            this.pnlSales.Controls.Add(this.lblSalesV);
            this.pnlSales.Controls.Add(this.llblSalesT);
            this.pnlSales.Location = new System.Drawing.Point(3, 3);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(229, 100);
            this.pnlSales.TabIndex = 0;
            // 
            // llblSalesT
            // 
            this.llblSalesT.AutoSize = true;
            this.llblSalesT.Location = new System.Drawing.Point(4, 37);
            this.llblSalesT.Name = "llblSalesT";
            this.llblSalesT.Size = new System.Drawing.Size(33, 13);
            this.llblSalesT.TabIndex = 0;
            this.llblSalesT.Text = "Sales";
            // 
            // lblSalesV
            // 
            this.lblSalesV.AutoSize = true;
            this.lblSalesV.Location = new System.Drawing.Point(153, 37);
            this.lblSalesV.Name = "lblSalesV";
            this.lblSalesV.Size = new System.Drawing.Size(25, 13);
            this.lblSalesV.TabIndex = 1;
            this.lblSalesV.Text = "163";
            // 
            // tblDashboard
            // 
            this.tblDashboard.BackColor = System.Drawing.Color.LightGray;
            this.tblDashboard.ColumnCount = 1;
            this.tblDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDashboard.Controls.Add(this.flpKPI, 0, 0);
            this.tblDashboard.Controls.Add(this.pnlRecentOrder, 0, 2);
            this.tblDashboard.Controls.Add(this.pnlLowStock, 0, 1);
            this.tblDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDashboard.Location = new System.Drawing.Point(0, 0);
            this.tblDashboard.Name = "tblDashboard";
            this.tblDashboard.RowCount = 3;
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashboard.Size = new System.Drawing.Size(781, 546);
            this.tblDashboard.TabIndex = 0;
            // 
            // lvLowStock
            // 
            this.lvLowStock.BackColor = System.Drawing.Color.White;
            this.lvLowStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProduct,
            this.colStock});
            this.lvLowStock.HideSelection = false;
            this.lvLowStock.Location = new System.Drawing.Point(3, 73);
            this.lvLowStock.Name = "lvLowStock";
            this.lvLowStock.Size = new System.Drawing.Size(752, 97);
            this.lvLowStock.TabIndex = 2;
            this.lvLowStock.UseCompatibleStateImageBehavior = false;
            this.lvLowStock.View = System.Windows.Forms.View.Details;
            this.lvLowStock.SelectedIndexChanged += new System.EventHandler(this.lvLowStock_SelectedIndexChanged);
            // 
            // colProduct
            // 
            this.colProduct.Text = "Product";
            // 
            // colStock
            // 
            this.colStock.Text = "Stock";
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStock.Location = new System.Drawing.Point(7, 55);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(63, 15);
            this.lblLowStock.TabIndex = 3;
            this.lblLowStock.Text = "Low Stock";
            // 
            // pnlReOrders
            // 
            this.pnlReOrders.BackColor = System.Drawing.Color.White;
            this.pnlReOrders.Controls.Add(this.lblReOrders);
            this.pnlReOrders.Controls.Add(this.listView1);
            this.pnlReOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlReOrders.Location = new System.Drawing.Point(0, 0);
            this.pnlReOrders.Name = "pnlReOrders";
            this.pnlReOrders.Size = new System.Drawing.Size(775, 207);
            this.pnlReOrders.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colOrderid,
            this.colCustomer,
            this.colTotal,
            this.colStatus});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 60);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(752, 97);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // colOrderid
            // 
            this.colOrderid.Text = "Order ID";
            // 
            // colCustomer
            // 
            this.colCustomer.Text = "Customer";
            // 
            // colTotal
            // 
            this.colTotal.Text = "Total";
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            // 
            // lblReOrders
            // 
            this.lblReOrders.AutoSize = true;
            this.lblReOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReOrders.Location = new System.Drawing.Point(4, 41);
            this.lblReOrders.Name = "lblReOrders";
            this.lblReOrders.Size = new System.Drawing.Size(86, 15);
            this.lblReOrders.TabIndex = 1;
            this.lblReOrders.Text = "Recent Orders";
            // 
            // DashboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.tblDashboard);
            this.Name = "DashboardView";
            this.Size = new System.Drawing.Size(781, 546);
            this.pnlRecentOrder.ResumeLayout(false);
            this.pnlLowStock.ResumeLayout(false);
            this.pnlLowStock.PerformLayout();
            this.flpKPI.ResumeLayout(false);
            this.pnlRevenue.ResumeLayout(false);
            this.pnlRevenue.PerformLayout();
            this.pnlOrders.ResumeLayout(false);
            this.pnlOrders.PerformLayout();
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            this.tblDashboard.ResumeLayout(false);
            this.pnlReOrders.ResumeLayout(false);
            this.pnlReOrders.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlRecentOrder;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.FlowLayoutPanel flpKPI;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.Label lblSalesV;
        private System.Windows.Forms.Label llblSalesT;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Label lblOrdersV;
        private System.Windows.Forms.Label lblOrdersT;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.Label lblRevenueV;
        private System.Windows.Forms.Label lblRevenueT;
        private System.Windows.Forms.TableLayoutPanel tblDashboard;
        private System.Windows.Forms.ListView lvLowStock;
        private System.Windows.Forms.ColumnHeader colProduct;
        private System.Windows.Forms.ColumnHeader colStock;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.Panel pnlReOrders;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colOrderid;
        private System.Windows.Forms.ColumnHeader colCustomer;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.Label lblReOrders;
    }
}
