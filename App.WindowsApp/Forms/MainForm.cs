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
using App.Core.Services;

namespace App.WindowsApp.Forms
{
        
      public partial class MainForm : Form
       {
        InMemoryProductService _ProductService = new InMemoryProductService();
        private readonly Dictionary<Type, UserControl> _views = new Dictionary<Type, UserControl>();
// copilet
        private readonly IProductService _productService;

        public MainForm()
        {
            InitializeComponent();
            _productService = new InMemoryProductService();             
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flpNav_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            this.pnlContent.Controls.Clear();
            this.pnlContent.Controls.Add(new DashboardView());
        }

       

        private void btnLogs_Click(object sender, EventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.pnlContent.Controls.Clear();
            this.pnlContent.Controls.Add(new ProductsView(_productService));
        }
        private void ShowView<T>(Func<T> factory) where T : UserControl

        {

            var key =typeof(T);
            if (!_views.TryGetValue(key, out var view))
            {
                view = factory();
                view.Dock = DockStyle.Fill;
                _views[key] = view;
            }

            if (!pnlContent.Controls.Contains(view))
            {
                pnlContent.Controls.Clear();
                pnlContent.Controls.Add(view);
            }   

            view.BringToFront();


        }


        }
}