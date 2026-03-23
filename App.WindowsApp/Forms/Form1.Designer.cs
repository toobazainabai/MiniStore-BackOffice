namespace App.WinForms.Forms
{
    partial class Form1
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
            tblProductForm = new TableLayoutPanel();
            lblName = new Label();
            lblCategory = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            lblStatus = new Label();
            lblID = new Label();
            txtbxName = new TextBox();
            combxCategory = new ComboBox();
            numUDPrice = new NumericUpDown();
            combxStatus = new ComboBox();
            txtbxID = new TextBox();
            numUDStock = new NumericUpDown();
            flpProductForm = new FlowLayoutPanel();
            btnCancel = new Button();
            btnSave = new Button();
            tblProductForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numUDPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUDStock).BeginInit();
            flpProductForm.SuspendLayout();
            SuspendLayout();
            // 
            // tblProductForm
            // 
            tblProductForm.ColumnCount = 2;
            tblProductForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tblProductForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tblProductForm.Controls.Add(lblName, 0, 0);
            tblProductForm.Controls.Add(lblCategory, 0, 1);
            tblProductForm.Controls.Add(lblPrice, 0, 2);
            tblProductForm.Controls.Add(lblStock, 0, 3);
            tblProductForm.Controls.Add(lblStatus, 0, 4);
            tblProductForm.Controls.Add(lblID, 0, 5);
            tblProductForm.Controls.Add(txtbxName, 1, 0);
            tblProductForm.Controls.Add(combxCategory, 1, 1);
            tblProductForm.Controls.Add(numUDPrice, 1, 2);
            tblProductForm.Controls.Add(combxStatus, 1, 4);
            tblProductForm.Controls.Add(txtbxID, 1, 5);
            tblProductForm.Controls.Add(numUDStock, 1, 3);
            tblProductForm.Dock = DockStyle.Top;
            tblProductForm.Location = new Point(0, 0);
            tblProductForm.Name = "tblProductForm";
            tblProductForm.RowCount = 6;
            tblProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tblProductForm.Size = new Size(800, 183);
            tblProductForm.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(39, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            lblName.Click += label1_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Dock = DockStyle.Top;
            lblCategory.Location = new Point(3, 30);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(194, 15);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Dock = DockStyle.Top;
            lblPrice.Location = new Point(3, 60);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(194, 15);
            lblPrice.TabIndex = 2;
            lblPrice.Text = "Price";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Dock = DockStyle.Top;
            lblStock.Location = new Point(3, 90);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(194, 15);
            lblStock.TabIndex = 3;
            lblStock.Text = "Stock";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Dock = DockStyle.Top;
            lblStatus.Location = new Point(3, 120);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(194, 15);
            lblStatus.TabIndex = 4;
            lblStatus.Text = "Status";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(3, 150);
            lblID.Name = "lblID";
            lblID.Size = new Size(18, 15);
            lblID.TabIndex = 5;
            lblID.Text = "ID";
            lblID.Click += label6_Click;
            // 
            // txtbxName
            // 
            txtbxName.Dock = DockStyle.Fill;
            txtbxName.Location = new Point(203, 3);
            txtbxName.Name = "txtbxName";
            txtbxName.Size = new Size(594, 23);
            txtbxName.TabIndex = 6;
            // 
            // combxCategory
            // 
            combxCategory.Dock = DockStyle.Fill;
            combxCategory.FormattingEnabled = true;
            combxCategory.Location = new Point(203, 33);
            combxCategory.Name = "combxCategory";
            combxCategory.Size = new Size(594, 23);
            combxCategory.TabIndex = 7;
            // 
            // numUDPrice
            // 
            numUDPrice.Dock = DockStyle.Fill;
            numUDPrice.Location = new Point(203, 63);
            numUDPrice.Name = "numUDPrice";
            numUDPrice.Size = new Size(594, 23);
            numUDPrice.TabIndex = 8;
            // 
            // combxStatus
            // 
            combxStatus.Dock = DockStyle.Fill;
            combxStatus.FormattingEnabled = true;
            combxStatus.Location = new Point(203, 123);
            combxStatus.Name = "combxStatus";
            combxStatus.Size = new Size(594, 23);
            combxStatus.TabIndex = 9;
            // 
            // txtbxID
            // 
            txtbxID.Dock = DockStyle.Fill;
            txtbxID.Location = new Point(203, 153);
            txtbxID.Name = "txtbxID";
            txtbxID.Size = new Size(594, 23);
            txtbxID.TabIndex = 10;
            // 
            // numUDStock
            // 
            numUDStock.Dock = DockStyle.Fill;
            numUDStock.Location = new Point(203, 93);
            numUDStock.Name = "numUDStock";
            numUDStock.Size = new Size(594, 23);
            numUDStock.TabIndex = 11;
            // 
            // flpProductForm
            // 
            flpProductForm.Controls.Add(btnCancel);
            flpProductForm.Controls.Add(btnSave);
            flpProductForm.Dock = DockStyle.Bottom;
            flpProductForm.FlowDirection = FlowDirection.RightToLeft;
            flpProductForm.Location = new Point(0, 350);
            flpProductForm.Name = "flpProductForm";
            flpProductForm.Size = new Size(800, 100);
            flpProductForm.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(722, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(641, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flpProductForm);
            Controls.Add(tblProductForm);
            Name = "Form1";
            Text = "Form1";
            tblProductForm.ResumeLayout(false);
            tblProductForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numUDPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUDStock).EndInit();
            flpProductForm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblProductForm;
        private Label lblStatus;
        private Label lblID;
        private Label lblName;
        private Label lblCategory;
        private Label lblPrice;
        private Label lblStock;
        private FlowLayoutPanel flpProductForm;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtbxName;
        private ComboBox combxCategory;
        private NumericUpDown numUDPrice;
        private ComboBox combxStatus;
        private TextBox txtbxID;
        private NumericUpDown numUDStock;
    }
}