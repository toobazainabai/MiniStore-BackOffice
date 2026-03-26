    using App.Core.Contracts;
using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace App.WindowsApp.Forms
{
    public partial class ProductForm : Form
    {
        ProductFormModeEnum _mode;
        Product _product;
        IProductService _service;
        public ProductForm(ProductFormModeEnum mode, Product? P, IProductService service)
        {
            InitializeComponent();
            numUDPrice.Maximum = Decimal.MaxValue;
            numUDStock.Maximum = Int32.MaxValue;

            combxCategory.Items.Clear();
            combxCategory.DataSource = Enum.GetValues(typeof(ProductCategoryEnum));
            combxCategory.SelectedIndex = 0;

            combxStatus.Items.Clear();
            combxStatus.DataSource = Enum.GetValues(typeof(ProductStatusEnum));
            combxStatus.SelectedIndex = 0;
            _mode = mode;
            _product = P;
            _service = service;
            if (mode == ProductFormModeEnum.Edit)
            {
                btnSave.Text = "Update";
            }

            else if (mode == ProductFormModeEnum.View)
            {
                btnSave.Visible = false;

            }
            if (mode == ProductFormModeEnum.Edit || mode == ProductFormModeEnum.View)
            {
                if (P != null)
                {
                    txtbxID.Text = P.Id;
                    txtbxName.Text = P.Name;
                    combxCategory.SelectedItem = P.Category;
                    combxStatus.SelectedItem = P.Status;
                    numUDPrice.Value = P.Price;
                    numUDStock.Value = P.Stock;
                }
            }


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Safety check: Ensure the service is available
            if (_service == null)
            {
                MessageBox.Show("Error: Product Service is not initialized.", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_mode == ProductFormModeEnum.Add)
            {
                Product newproduct = new Product();
                newproduct.Name = txtbxName.Text;

                // Fallback to default enums if selection is missing
                newproduct.Category = combxCategory.SelectedItem != null ? (ProductCategoryEnum)combxCategory.SelectedItem : ProductCategoryEnum.Electronics;
                newproduct.Status = combxStatus.SelectedItem != null ? (ProductStatusEnum)combxStatus.SelectedItem : ProductStatusEnum.Active;

                newproduct.Price = numUDPrice.Value;
                newproduct.Stock = (int)numUDStock.Value;

                Product temp = _service.Add(newproduct);
                txtbxID.Text = temp?.Id ?? "";
            }
            else if (_mode == ProductFormModeEnum.Edit)
            {
                // Safety check: Ensure the product exists before editing
                if (_product != null)
                {
                    _product.Name = txtbxName.Text;
                    _product.Category = combxCategory.SelectedItem != null ? (ProductCategoryEnum)combxCategory.SelectedItem : _product.Category;
                    _product.Status = combxStatus.SelectedItem != null ? (ProductStatusEnum)combxStatus.SelectedItem : _product.Status;
                    _product.Price = numUDPrice.Value;
                    _product.Stock = (int)numUDStock.Value;

                    bool isUpdated = _service.Update(_product);
                }
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
