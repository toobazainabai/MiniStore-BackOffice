namespace App.WindowsApp.Forms
{
    partial class MainForm
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
            pnlHeader = new Panel();
            flpRight = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            lblUser = new Label();
            flpLeft = new FlowLayoutPanel();
            pbLogo = new PictureBox();
            pnlSidebar = new Panel();
            flpNav = new FlowLayoutPanel();
            btnDashboard = new Button();
            btnProducts = new Button();
            btnOrders = new Button();
            btnReports = new Button();
            btnSync = new Button();
            btnLogs = new Button();
            btnSettings = new Button();
            pnlContent = new Panel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            statusStrip = new StatusStrip();
            btnCustomer = new Button();
            pnlHeader.SuspendLayout();
            flpRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flpLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            pnlSidebar.SuspendLayout();
            flpNav.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.Controls.Add(flpRight);
            pnlHeader.Controls.Add(flpLeft);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Margin = new Padding(4, 3, 4, 3);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(968, 38);
            pnlHeader.TabIndex = 0;
            // 
            // flpRight
            // 
            flpRight.Controls.Add(pictureBox1);
            flpRight.Controls.Add(lblUser);
            flpRight.Dock = DockStyle.Right;
            flpRight.Location = new Point(866, 0);
            flpRight.Margin = new Padding(4, 3, 4, 3);
            flpRight.Name = "flpRight";
            flpRight.Size = new Size(102, 38);
            flpRight.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ico_admin;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 32);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(41, 0);
            lblUser.Name = "lblUser";
            lblUser.Padding = new Padding(0, 10, 0, 0);
            lblUser.Size = new Size(43, 25);
            lblUser.TabIndex = 2;
            lblUser.Text = "Admin";
            lblUser.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpLeft
            // 
            flpLeft.Controls.Add(pbLogo);
            flpLeft.Dock = DockStyle.Left;
            flpLeft.Location = new Point(0, 0);
            flpLeft.Margin = new Padding(4, 3, 4, 3);
            flpLeft.Name = "flpLeft";
            flpLeft.Size = new Size(139, 38);
            flpLeft.TabIndex = 0;
            // 
            // pbLogo
            // 
            pbLogo.Image = Properties.Resources.ico_building;
            pbLogo.Location = new Point(3, 3);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(92, 35);
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            // 
            // pnlSidebar
            // 
            pnlSidebar.Controls.Add(flpNav);
            pnlSidebar.Dock = DockStyle.Left;
            pnlSidebar.Location = new Point(0, 38);
            pnlSidebar.Margin = new Padding(4, 3, 4, 3);
            pnlSidebar.Name = "pnlSidebar";
            pnlSidebar.Size = new Size(163, 509);
            pnlSidebar.TabIndex = 1;
            // 
            // flpNav
            // 
            flpNav.Controls.Add(btnDashboard);
            flpNav.Controls.Add(btnProducts);
            flpNav.Controls.Add(btnCustomer);
            flpNav.Controls.Add(btnOrders);
            flpNav.Controls.Add(btnReports);
            flpNav.Controls.Add(btnSync);
            flpNav.Controls.Add(btnLogs);
            flpNav.Controls.Add(btnSettings);
            flpNav.Dock = DockStyle.Fill;
            flpNav.FlowDirection = FlowDirection.TopDown;
            flpNav.Location = new Point(0, 0);
            flpNav.Margin = new Padding(4, 3, 4, 3);
            flpNav.Name = "flpNav";
            flpNav.Size = new Size(163, 509);
            flpNav.TabIndex = 0;
            flpNav.Paint += flpNav_Paint;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Image = Properties.Resources.ico_dashboard;
            btnDashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Location = new Point(3, 3);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(160, 45);
            btnDashboard.TabIndex = 0;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnProducts
            // 
            btnProducts.FlatAppearance.BorderSize = 0;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.Image = Properties.Resources.ico_products;
            btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
            btnProducts.Location = new Point(3, 54);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(160, 40);
            btnProducts.TabIndex = 1;
            btnProducts.Text = "Products";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnProducts.UseVisualStyleBackColor = true;
            btnProducts.Click += btnProducts_Click;
            // 
            // btnOrders
            // 
            btnOrders.FlatAppearance.BorderSize = 0;
            btnOrders.FlatStyle = FlatStyle.Flat;
            btnOrders.Image = Properties.Resources.ico_order;
            btnOrders.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrders.Location = new Point(3, 146);
            btnOrders.Name = "btnOrders";
            btnOrders.Size = new Size(160, 40);
            btnOrders.TabIndex = 2;
            btnOrders.Text = "Orders";
            btnOrders.TextAlign = ContentAlignment.MiddleLeft;
            btnOrders.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnOrders.UseVisualStyleBackColor = true;
            // 
            // btnReports
            // 
            btnReports.FlatAppearance.BorderSize = 0;
            btnReports.FlatStyle = FlatStyle.Flat;
            btnReports.Image = Properties.Resources.ico_reports;
            btnReports.ImageAlign = ContentAlignment.MiddleLeft;
            btnReports.Location = new Point(3, 192);
            btnReports.Name = "btnReports";
            btnReports.Size = new Size(160, 40);
            btnReports.TabIndex = 3;
            btnReports.Text = "Reports";
            btnReports.TextAlign = ContentAlignment.MiddleLeft;
            btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnReports.UseVisualStyleBackColor = true;
            // 
            // btnSync
            // 
            btnSync.FlatAppearance.BorderSize = 0;
            btnSync.FlatStyle = FlatStyle.Flat;
            btnSync.Image = Properties.Resources.ico_sync;
            btnSync.ImageAlign = ContentAlignment.MiddleLeft;
            btnSync.Location = new Point(3, 238);
            btnSync.Name = "btnSync";
            btnSync.Size = new Size(160, 40);
            btnSync.TabIndex = 4;
            btnSync.Text = "Sync";
            btnSync.TextAlign = ContentAlignment.MiddleLeft;
            btnSync.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSync.UseVisualStyleBackColor = true;
            // 
            // btnLogs
            // 
            btnLogs.FlatAppearance.BorderSize = 0;
            btnLogs.FlatStyle = FlatStyle.Flat;
            btnLogs.Image = Properties.Resources.ico_logs;
            btnLogs.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogs.Location = new Point(3, 284);
            btnLogs.Name = "btnLogs";
            btnLogs.Size = new Size(160, 40);
            btnLogs.TabIndex = 5;
            btnLogs.Text = "Logs";
            btnLogs.TextAlign = ContentAlignment.MiddleLeft;
            btnLogs.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLogs.UseVisualStyleBackColor = true;
            btnLogs.Click += btnLogs_Click;
            // 
            // btnSettings
            // 
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Image = Properties.Resources.ico_settings;
            btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
            btnSettings.Location = new Point(3, 330);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(160, 40);
            btnSettings.TabIndex = 6;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(163, 38);
            pnlContent.Margin = new Padding(4, 3, 4, 3);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(805, 509);
            pnlContent.TabIndex = 2;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(39, 17);
            toolStripStatusLabel1.Text = "Ready";
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip.Location = new Point(0, 547);
            statusStrip.Name = "statusStrip";
            statusStrip.Padding = new Padding(1, 0, 16, 0);
            statusStrip.Size = new Size(968, 22);
            statusStrip.TabIndex = 3;
            statusStrip.Text = "statusStrip1";
            // 
            // btnCustomer
            // 
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Image = Properties.Resources.ico_Customers;
            btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnCustomer.Location = new Point(3, 100);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(160, 40);
            btnCustomer.TabIndex = 7;
            btnCustomer.Text = "Customer";
            btnCustomer.TextAlign = ContentAlignment.MiddleLeft;
            btnCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 569);
            Controls.Add(pnlContent);
            Controls.Add(pnlSidebar);
            Controls.Add(statusStrip);
            Controls.Add(pnlHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            WindowState = FormWindowState.Maximized;
            pnlHeader.ResumeLayout(false);
            flpRight.ResumeLayout(false);
            flpRight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flpLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            pnlSidebar.ResumeLayout(false);
            flpNav.ResumeLayout(false);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.FlowLayoutPanel flpRight;
        private System.Windows.Forms.FlowLayoutPanel flpLeft;
        private System.Windows.Forms.FlowLayoutPanel flpNav;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private Button btnCustomer;
    }
}