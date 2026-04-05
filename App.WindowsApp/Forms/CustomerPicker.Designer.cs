namespace App.WindowsApp.Forms
{
    partial class CustomerPicker
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
            tblpanelCpicker = new TableLayoutPanel();
            flpSearchBar = new FlowLayoutPanel();
            lblSearchText = new Label();
            txtSearchQuery = new TextBox();
            flpButtons = new FlowLayoutPanel();
            btnSelect = new Button();
            btnCancel = new Button();
            lsCustomers = new ListBox();
            tblpanelCpicker.SuspendLayout();
            flpSearchBar.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tblpanelCpicker
            // 
            tblpanelCpicker.ColumnCount = 1;
            tblpanelCpicker.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblpanelCpicker.Controls.Add(flpSearchBar, 0, 0);
            tblpanelCpicker.Controls.Add(flpButtons, 0, 2);
            tblpanelCpicker.Controls.Add(lsCustomers, 0, 1);
            tblpanelCpicker.Dock = DockStyle.Fill;
            tblpanelCpicker.Location = new Point(0, 0);
            tblpanelCpicker.Name = "tblpanelCpicker";
            tblpanelCpicker.RowCount = 3;
            tblpanelCpicker.RowStyles.Add(new RowStyle(SizeType.Percent, 10.092535F));
            tblpanelCpicker.RowStyles.Add(new RowStyle(SizeType.Percent, 80.01903F));
            tblpanelCpicker.RowStyles.Add(new RowStyle(SizeType.Percent, 9.888438F));
            tblpanelCpicker.Size = new Size(800, 450);
            tblpanelCpicker.TabIndex = 0;
            // 
            // flpSearchBar
            // 
            flpSearchBar.BackColor = SystemColors.Window;
            flpSearchBar.Controls.Add(lblSearchText);
            flpSearchBar.Controls.Add(txtSearchQuery);
            flpSearchBar.Dock = DockStyle.Fill;
            flpSearchBar.Location = new Point(3, 3);
            flpSearchBar.Name = "flpSearchBar";
            flpSearchBar.Size = new Size(794, 39);
            flpSearchBar.TabIndex = 0;
            flpSearchBar.Paint += flpSearchBar_Paint;
            // 
            // lblSearchText
            // 
            lblSearchText.AutoSize = true;
            lblSearchText.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchText.Location = new Point(3, 0);
            lblSearchText.Name = "lblSearchText";
            lblSearchText.Size = new Size(96, 20);
            lblSearchText.TabIndex = 0;
            lblSearchText.Text = "Search Query";
            // 
            // txtSearchQuery
            // 
            txtSearchQuery.Location = new Point(105, 3);
            txtSearchQuery.Name = "txtSearchQuery";
            txtSearchQuery.Size = new Size(347, 23);
            txtSearchQuery.TabIndex = 1;
            txtSearchQuery.TextChanged += txtSearchQuery_TextChanged;
            // 
            // flpButtons
            // 
            flpButtons.BackColor = SystemColors.Window;
            flpButtons.Controls.Add(btnSelect);
            flpButtons.Controls.Add(btnCancel);
            flpButtons.Dock = DockStyle.Fill;
            flpButtons.FlowDirection = FlowDirection.RightToLeft;
            flpButtons.Location = new Point(3, 408);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(794, 39);
            flpButtons.TabIndex = 1;
            // 
            // btnSelect
            // 
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSelect.Image = Properties.Resources.ico_Select;
            btnSelect.Location = new Point(716, 3);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 33);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "Select";
            btnSelect.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Image = Properties.Resources.ico_Cancel;
            btnCancel.Location = new Point(635, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 33);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lsCustomers
            // 
            lsCustomers.Dock = DockStyle.Fill;
            lsCustomers.FormattingEnabled = true;
            lsCustomers.Location = new Point(3, 48);
            lsCustomers.Name = "lsCustomers";
            lsCustomers.Size = new Size(794, 354);
            lsCustomers.TabIndex = 2;
            lsCustomers.DoubleClick += lsCustomers_DoubleClick;
            // 
            // CustomerPicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tblpanelCpicker);
            Name = "CustomerPicker";
            Text = "CustomerPicker";
            tblpanelCpicker.ResumeLayout(false);
            flpSearchBar.ResumeLayout(false);
            flpSearchBar.PerformLayout();
            flpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblpanelCpicker;
        private FlowLayoutPanel flpSearchBar;
        private FlowLayoutPanel flpButtons;
        private Label lblSearchText;
        private TextBox txtSearchQuery;
        private Button btnSelect;
        private Button btnCancel;
        private ListBox lsCustomers;
    }
}