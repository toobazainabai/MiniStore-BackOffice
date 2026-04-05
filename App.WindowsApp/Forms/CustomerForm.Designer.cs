namespace App.WindowsApp.Forms
{
    partial class CustomerForm
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
            tblPanelCustomer = new TableLayoutPanel();
            lblName = new Label();
            lblPhone = new Label();
            lblEmail = new Label();
            lblAddress = new Label();
            lblid = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtid = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            tblPanelCustomer.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tblPanelCustomer
            // 
            tblPanelCustomer.ColumnCount = 2;
            tblPanelCustomer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.7894735F));
            tblPanelCustomer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.2105255F));
            tblPanelCustomer.Controls.Add(lblName, 0, 0);
            tblPanelCustomer.Controls.Add(lblPhone, 0, 1);
            tblPanelCustomer.Controls.Add(lblEmail, 0, 2);
            tblPanelCustomer.Controls.Add(lblAddress, 0, 3);
            tblPanelCustomer.Controls.Add(lblid, 0, 4);
            tblPanelCustomer.Controls.Add(txtName, 1, 0);
            tblPanelCustomer.Controls.Add(txtPhone, 1, 1);
            tblPanelCustomer.Controls.Add(txtEmail, 1, 2);
            tblPanelCustomer.Controls.Add(txtAddress, 1, 3);
            tblPanelCustomer.Controls.Add(txtid, 1, 4);
            tblPanelCustomer.Dock = DockStyle.Top;
            tblPanelCustomer.Font = new Font("Segoe UI", 12F);
            tblPanelCustomer.Location = new Point(0, 0);
            tblPanelCustomer.Name = "tblPanelCustomer";
            tblPanelCustomer.RowCount = 5;
            tblPanelCustomer.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblPanelCustomer.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblPanelCustomer.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblPanelCustomer.RowStyles.Add(new RowStyle());
            tblPanelCustomer.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblPanelCustomer.Size = new Size(777, 187);
            tblPanelCustomer.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Microsoft Sans Serif", 9F);
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(41, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Microsoft Sans Serif", 9F);
            lblPhone.Location = new Point(3, 29);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(43, 15);
            lblPhone.TabIndex = 1;
            lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Microsoft Sans Serif", 9F);
            lblEmail.Location = new Point(3, 58);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(39, 15);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Microsoft Sans Serif", 9F);
            lblAddress.Location = new Point(3, 87);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(51, 15);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Address";
            // 
            // lblid
            // 
            lblid.AutoSize = true;
            lblid.Font = new Font("Microsoft Sans Serif", 9F);
            lblid.Location = new Point(3, 151);
            lblid.Name = "lblid";
            lblid.Size = new Size(17, 15);
            lblid.TabIndex = 4;
            lblid.Text = "id";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(125, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(649, 29);
            txtName.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(125, 32);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(649, 29);
            txtPhone.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(125, 61);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(649, 29);
            txtEmail.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Dock = DockStyle.Fill;
            txtAddress.Location = new Point(125, 90);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ScrollBars = ScrollBars.Vertical;
            txtAddress.Size = new Size(649, 58);
            txtAddress.TabIndex = 8;
            // 
            // txtid
            // 
            txtid.Dock = DockStyle.Fill;
            txtid.Location = new Point(125, 154);
            txtid.Name = "txtid";
            txtid.ReadOnly = true;
            txtid.Size = new Size(649, 29);
            txtid.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 360);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(777, 46);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.Image = Properties.Resources.ico_Save;
            btnSave.Location = new Point(699, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 31);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Image = Properties.Resources.ico_Cancel;
            btnCancel.Location = new Point(618, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 31);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(777, 406);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tblPanelCustomer);
            Name = "CustomerForm";
            Text = "CustomerForm";
            tblPanelCustomer.ResumeLayout(false);
            tblPanelCustomer.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblPanelCustomer;
        private Label lblName;
        private Label lblPhone;
        private Label lblEmail;
        private Label lblAddress;
        private Label lblid;
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtid;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSave;
        private Button btnCancel;
    }
}