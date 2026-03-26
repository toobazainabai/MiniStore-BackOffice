using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.WindowsApp.Views;
using App.Core.Contracts;
using App.Core.Utilities;
using App.Core.Services;
using App.WindowsApp.Forms;
using App.Core.Models;
using System.Drawing.Text;


namespace App.WindowsApp.Views
{
    public partial class ProductsView : UserControl
    {
        IProductService _service;

        BindingSource _dgvBindingSource = new BindingSource();

        public ProductsView(IProductService service)
        {
            this._service = service;
            InitializeComponent();
            dgvProducts.DataSource = _dgvBindingSource;
            dgvProducts.AllowUserToAddRows = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ProductsView_Load(object sender, EventArgs e)
        {
            cmbCategory.DataSource = new object[] { "--All--" }
                .Concat(Enum.GetValues<ProductCategoryEnum>().Cast<object>())
                .ToList();
            cmbCategory.SelectedIndex = 0;

            cmbStockStatus.DataSource = new object[] { "--All--" }
                .Concat(Enum.GetValues<ProductStatusEnum>().Cast<object>())
                .ToList();
            cmbStockStatus.SelectedIndex = 0;

            if (_service == null) return;
            _dgvBindingSource.DataSource = _service.GetAll();
        }

        private void tsAdd_Click(object sender, EventArgs e)
        {
            ProductForm prodForm = new ProductForm(ProductFormModeEnum.Add, null, _service);
            prodForm.ShowDialog();
            RefreshGrid();
        }

        private void tsEdit_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvBindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.Edit, selectedProduct, _service);
                prodForm.ShowDialog();
                RefreshGrid();

            }

        }

        private void tsView_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvBindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.View, selectedProduct, _service);
                prodForm.ShowDialog();

            }

        }
        private void RefreshGrid()
        {
           string searchText = txtSearch.Text;

            ProductCategoryEnum? selectedCategory =
                cmbCategory.SelectedItem is ProductCategoryEnum category ? category : null;

            ProductStatusEnum? selectedstatus =
                cmbStockStatus.SelectedItem is ProductStatusEnum status ? status : null;

            _dgvBindingSource.DataSource = _service.Search(searchText, selectedCategory, selectedstatus);
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cmbStockStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
        // copilet



    }
}
