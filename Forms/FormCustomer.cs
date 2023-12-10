using CoffeeShop2.Models.Customers;
using CoffeeShop2.Result;
using RestClientLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsCoffee.Forms
{
    public partial class Customer : Form
    {
        private BindingSource bd = new BindingSource();
        private string id { get; set; } = default!;
        public Customer()
        {
            InitializeComponent();
            dataGridView1.DataSource = bd;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Get();
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {

        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCustomerId.Text, out int id) == false) return;
            var customerid = txtCustomerId.Text.Trim();
            if (string.IsNullOrEmpty(customerid) == true) return;
            var name = txtName.Text.Trim();
            var phone = txtPhone.Text.Trim();
            var orderH = txtOrderH.Text.Trim();
            var customer = new CustomerCreateReq()
            {
                customerKey = customerid,
                Name = name,
                Phone = phone,
                Order_history = Convert.ToInt32(orderH),
            };
            var endpoit = "api/customer";
            RestClient<CustomerCreateReq> client = new RestClient<CustomerCreateReq>(Program.BASE_URI);
            try
            {
                var response = await client.PostAsync<CustomerCreateReq, Result<string?>>(endpoit, customer);
                if (response!.Succeded)
                {
                    bd.DataSource = response!.Data;
                    bd.ResetBindings(false);
                    Get();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            clear();
        }

        private async void btnSreach_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCustomerId.Text, out int menu) == false) return;
            var id = txtCustomerId.Text.Trim();
            if (string.IsNullOrEmpty(id) == true) return;
            var endpoit = "api/customer";
            RestClient<CustomerResponse> client = new RestClient<CustomerResponse>(Program.BASE_URI);
            try
            {
                var response = await client.GetAsync<Result<List<CustomerResponse>>>(endpoit);
                if (response!.Succeded)
                {
                    var result = response!.Data!.Where(p => p.customerCode.ToLower() == id.Trim().ToLower()).ToList() ?? new();
                    bd.DataSource = result;
                    bd.ResetBindings(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            var customerid = txtCustomerId.Text.Trim();
            var name = txtName.Text.Trim();
            var phne = txtPhone.Text.Trim();
            var orderH = txtOrderH.Text.Trim();
            var customer = new CustomerUpdateReq()
            {
                Id = id,
                customerKey = customerid,
                Name = name,
                Phone = phne,
                Order_history = Convert.ToInt32(orderH),
            };
            var endpoit = "api/customer";
            RestClient<CustomerUpdateReq> client = new RestClient<CustomerUpdateReq>(Program.BASE_URI);
            try
            {
                var response = await client.PutAsync<CustomerUpdateReq, Result<string?>>(endpoit, customer);
                if (response!.Succeded)
                {
                    var resultid = response!.Data;
                    var found = (bd.DataSource as List<CustomerUpdateReq>)?.FirstOrDefault(b => b.Id == resultid);
                    if (found != null)
                    {
                        found.customerKey = customerid;
                        found.Name = name;
                        found.Phone = phne;
                        found.Order_history = Convert.ToInt32(orderH);
                        bd.ResetBindings(false);
                    }
                    Get();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            clear();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (bd.Current == null) return;
            if (bd.Current is not CustomerResponse customer) return;
            if (MessageBox.Show($"Are you Sure to Delete the customer is,{customer.customerCode}", "Deleting",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            var endpoint = $"api/customer/{customer.Id}";
            RestClient<CustomerResponse> client = new RestClient<CustomerResponse>(Program.BASE_URI);
            try
            {
                var response = await client.DeleteAsync<Result<string?>>(endpoint);
                if (response!.Succeded)
                {
                    bd.ResetBindings(false);
                    Get();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void Get()
        {
            bd.DataSource = new List<CustomerResponse>();
            var endpoit = "api/customer";
            RestClient<CustomerResponse> client = new RestClient<CustomerResponse>(Program.BASE_URI);
            try
            {
                var response = await client.GetAsync<Result<List<CustomerResponse>>>(endpoit);
                if (response!.Succeded)
                {
                    bd.DataSource = response!.Data;
                    bd.ResetBindings(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Get();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
            id = selectedRow.Cells["id"].Value.ToString();
            txtID.Text = Convert.ToString(id);
        }
        private void clear()
        {
            txtID.Clear();
            txtCustomerId.Clear();
            txtName.Clear();
            txtOrderH.Clear();
            txtPhone.Clear();
        }
    }
}
