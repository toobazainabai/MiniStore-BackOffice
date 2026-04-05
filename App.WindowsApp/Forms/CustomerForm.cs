using App.Core.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using App.Core.Models;

namespace App.WindowsApp.Forms
{
    public partial class CustomerForm : Form
    {
        private ICustomerService _customerService;
        private CustomerFormModeEnum _mode;
        private Customer _customer;

        public CustomerForm(ICustomerService customerService, CustomerFormModeEnum mode, Customer customer = null)
        {
            InitializeComponent();
            _customerService = customerService;
            _mode = mode;
            _customer = customer ?? new Customer();

            PopularFeild();
            SetupMode();
        }
        private void PopularFeild()
        {
            txtName.Text = _customer.Name;
            txtPhone.Text = _customer.Phone;
            txtEmail.Text = _customer.Email;
            txtAddress.Text = _customer.Address;
            txtid.Text = _customer.Id;

        }
        private void SetupMode()
        {
            switch (_mode)
            {
                case CustomerFormModeEnum.Add:
                    this.Text = "Add Customer";
                    lblid.Visible = false;
                    txtid.Visible = false;
                    break;
                case CustomerFormModeEnum.Edit:
                    this.Text = "Edit Customer";
                    break;

                case CustomerFormModeEnum.View:
                    this.Text = "View Customer";
                    txtName.ReadOnly = true;
                    txtPhone.ReadOnly = true;
                    txtEmail.ReadOnly = true;
                    txtAddress.ReadOnly = true;
                    txtid.ReadOnly = true;
                    btnSave.Visible = false;
                    break;
            }
        }
        private bool validateData()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Name is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (validateData())
                {
                    _customer.Name = txtName.Text;
                    _customer.Phone = txtPhone.Text;
                    _customer.Email = txtEmail.Text;
                    _customer.Address = txtAddress.Text;
                    if (_mode == CustomerFormModeEnum.Add)
                    {
                        _customerService.Add(_customer);
                    }
                    else if (_mode == CustomerFormModeEnum.Edit)
                    {
                        _customerService.Update(_customer);
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}