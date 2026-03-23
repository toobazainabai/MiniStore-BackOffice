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


namespace App.WindowsApp.Views
{
    public partial class ProductsView : UserControl
    {
        IProductService _service;

        BindingSource _dgvBindingSource = new BindingSource();

        public ProductsView(IProductService _service)
        {
            this._service = _service;
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
            cmbCategory.Items.Clear();
            cmbCategory.Items.Add("--ALL--");
            cmbCategory.Items.AddRange(Enum.GetNames(typeof(ProductCategoryEnum)));
            cmbCategory.SelectedIndex = 0;

            cmbStockStatus.Items.Clear();
            cmbStockStatus.Items.Add("--ALL--");
            cmbStockStatus.Items.AddRange(Enum.GetNames(typeof(ProductStatusEnum)));
            cmbStockStatus.SelectedIndex = 0;

            if (_service == null)
                return;

            _dgvBindingSource.DataSource = _service.GetAll();
        }

        private void tsAdd_Click(object sender, EventArgs e)
        {
            ProductForm prodForm =  new ProductForm(ProductFormModeEnum.Add , null);
            prodForm.ShowDialog();
        }

        private void tsEdit_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvBindingSource.Current as Product;
            if ( selectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.Edit, selectedProduct);
                prodForm.ShowDialog();

            }
            
        }

        private void tsView_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvBindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.View, selectedProduct);
                prodForm.ShowDialog();

            }
        }
    }
    // copilet



}
