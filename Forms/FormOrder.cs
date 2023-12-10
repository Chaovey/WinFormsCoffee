using CoffeeShop2.Models.Customers;
using CoffeeShop2.Models.Menus;
using CoffeeShop2.Models.Orders;
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
using System.Xml.Linq;

namespace WinFormsCoffee.Forms
{
    public partial class Order : Form
    {
        private BindingSource bd = new BindingSource();
        private string id { get; set; } = default!;
        private string menuId { get; set; } = default!;
        private string customerId { get; set; } = default!;
        private List<string>? listmenu = [];
        private List<string>? listcustomer = [];
        public Order()
        {
            InitializeComponent();
            dataSoucre.DataSource = bd;
            dataSoucre.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Get();
            Menu();
            Customer();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Get();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtorderId.Text, out int id1) == false) return;
            var id = txtorderId.Text.Trim();
            if (string.IsNullOrEmpty(id) == true) return;
            var orderStatus = txtorderStatus.Text.Trim();
            var price = txtPrice.Text.Trim();
            var menu = menuId;
            var customer = customerId;
            var order = new OrderCreateReq()
            {
                orderKey = id,
                orderStatus = orderStatus,
                Price = Convert.ToDouble(price),
                MenuId = menuId,
                CustomerId = customerId,
            };
            var endpoit = "api/order";
            RestClient<OrderCreateReq> client = new RestClient<OrderCreateReq>(Program.BASE_URI);
            try
            {
                var response = await client.PostAsync<OrderCreateReq, Result<string?>>(endpoit, order);
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

        private  async void btnSreach_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtorderId.Text, out int menu) == false) return;
            var id = txtorderId.Text.Trim();
            if (string.IsNullOrEmpty(id) == true) return;
            var endpoit = "api/order";
            RestClient<OrderResponse> client = new RestClient<OrderResponse>(Program.BASE_URI);
            try
            {
                var response = await client.GetAsync<Result<List<OrderResponse>>>(endpoit);
                if (response!.Succeded)
                {
                    var result = response!.Data!.Where(p => p.orderCode.ToLower() == id.Trim().ToLower()).ToList() ?? new();
                    bd.DataSource = result;
                    bd.ResetBindings(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private  async void btnUpdate_Click(object sender, EventArgs e)
        {
            var orderid = txtorderId.Text.Trim();
            var orderstatus = txtorderStatus.Text.Trim();
            var price = txtPrice.Text.Trim();
            var menu = menuId;
            var customer = customerId;
            var order = new OrderUpdateReq()
            {
                Id = id,
                orderKey = orderid,
                ordderStatus = orderstatus,
                Price=Convert.ToDouble(price),
                MenuId=menu,
                CustomerId=customer,
            };
            var endpoit = "api/order";
            RestClient<OrderUpdateReq> client = new RestClient<OrderUpdateReq>(Program.BASE_URI);
            try
            {
                var response = await client.PutAsync<OrderUpdateReq, Result<string?>>(endpoit, order);
                if (response!.Succeded)
                {
                    var resultid = response!.Data;
                    var found = (bd.DataSource as List<OrderUpdateReq>)?.FirstOrDefault(b => b.Id == resultid);
                    if (found != null)
                    {
                        found.orderKey = orderid;
                        found.ordderStatus = orderstatus;
                        found.Price =Convert.ToDouble(price);
                        found.CustomerId = customerId;
                        found.MenuId = menuId;
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
            if (bd.Current is not OrderResponse order) return;
            if (MessageBox.Show($"Are you Sure to Delete the order is,{order.orderCode}", "Deleting",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            var endpoint = $"api/order/{order.Id}";
            RestClient<OrderResponse> client = new RestClient<OrderResponse>(Program.BASE_URI);
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
            bd.DataSource = new List<OrderResponse>();
            var endpoit = "api/order";
            RestClient<OrderResponse> client = new RestClient<OrderResponse>(Program.BASE_URI);
            try
            {
                var response = await client.GetAsync<Result<List<OrderResponse>>>(endpoit);
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
        private async void Menu()
        {
            var endpoit = "api/menu";
            RestClient<MenuResponse> client = new RestClient<MenuResponse>(Program.BASE_URI);
            try
            {
                var response = await client.GetAsync<Result<List<MenuResponse>>>(endpoit);
                if (response!.Succeded)
                {
                    var resutl = response!.Data;
                    foreach (var item in resutl)
                    {
                        cbMenuId.Items.Add(item.menuCode);
                        listmenu.Add(item.Id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void Customer()
        {
            var endpoit = "api/customer";
            RestClient<CustomerResponse> client = new RestClient<CustomerResponse>(Program.BASE_URI);
            try
            {
                var response = await client.GetAsync<Result<List<CustomerResponse>>>(endpoit);
                if (response!.Succeded)
                {
                    var resutl = response!.Data;
                    foreach (var item in resutl)
                    {
                        cbCustomerID.Items.Add(item.customerCode);
                        listcustomer.Add(item.Id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void cbMenuId_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cbMenuId.SelectedIndex;
            menuId = listmenu[index];
        }

        private void cbCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cbCustomerID.SelectedIndex;
            customerId = listcustomer[index];
        }

        private void dataSoucre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataSoucre.Rows[e.RowIndex];
            id = selectedRow.Cells["id"].Value.ToString();
            txtId.Text = Convert.ToString(id);
        }
        private void clear()
        {
            txtId.Clear();
            txtorderId.Clear();
            txtorderStatus.Clear();
            txtPrice.Clear();
        }
    }
}
