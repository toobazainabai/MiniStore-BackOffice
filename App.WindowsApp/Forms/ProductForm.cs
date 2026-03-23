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
        public ProductForm(ProductFormModeEnum mode, Product? P)
        {
            InitializeComponent();
            numUDPrice.Maximum = Decimal.MaxValue;
            numUDStock.Maximum = Int32.MaxValue;

            combxCategory.Items.Clear();
            combxCategory.DataSource=Enum.GetValues(typeof(ProductCategoryEnum));
            combxCategory.SelectedIndex = 0;

            combxStatus.Items.Clear();
            combxStatus.DataSource=Enum.GetValues(typeof(ProductStatusEnum));
            combxStatus.SelectedIndex = 0;

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



        }
    }

