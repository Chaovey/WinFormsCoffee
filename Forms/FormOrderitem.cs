using CoffeeShop2.Models.Customers;
using CoffeeShop2.Models.Items;
using CoffeeShop2.Models.OrderItems;
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

namespace WinFormsCoffee.Forms
{
    public partial class Orderitem : Form
    {
        private BindingSource bd = new BindingSource();
        private string id { get; set; } = default!;
        private string orderId { get; set; } = default!;
        private string itemId { get; set; } = default!;
        private List<string>? listorder = [];
        private List<string>? listitem = [];
        public Orderitem()
        {
            InitializeComponent();
            dataSoucre.DataSource = bd;
            dataSoucre.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Get();
            Order();
            Item();
        }

        private void btnRefreash_Click(object sender, EventArgs e)
        {
            Get();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtorderItemId.Text, out int id1) == false) return;
            var id = txtorderItemId.Text.Trim();
            if (string.IsNullOrEmpty(id) == true) return;
            var quanity = txtQuanity.Text.Trim();
            var order = orderId;
            var item = itemId;
            var orderItem = new OrderItemCreateReq()
            {
                orderItemKey = id,
                quantity = Convert.ToInt32(quanity),
                orderId = order,
                itemId = item
            };
            var endpoit = "api/orderitem";
            RestClient<OrderItemCreateReq> client = new RestClient<OrderItemCreateReq>(Program.BASE_URI);
            try
            {
                var response = await client.PostAsync<OrderItemCreateReq, Result<string?>>(endpoit, orderItem);
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

        private async void brnSreach_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtorderItemId.Text, out int menu) == false) return;
            var id = txtorderItemId.Text.Trim();
            if (string.IsNullOrEmpty(id) == true) return;
            var endpoit = "api/orderitem";
            RestClient<OrderItemResponse> client = new RestClient<OrderItemResponse>(Program.BASE_URI);
            try
            {
                var response = await client.GetAsync<Result<List<OrderItemResponse>>>(endpoit);
                if (response!.Succeded)
                {
                    var result = response!.Data!.Where(p => p.orderItemCode.ToLower() == id.Trim().ToLower()).ToList() ?? new();
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
            if (int.TryParse(txtorderItemId.Text, out int item) == false) return;
            var orderitemid = txtorderItemId.Text.Trim();
            if (string.IsNullOrEmpty(orderitemid) == true) return;
            var quanity = txtQuanity.Text.Trim();
            var orderitem = new OrderItemUpdateReq()
            {
                Id = id,
                orderItemKey = orderitemid,
                quantity = Convert.ToInt32(quanity),
                orderId = orderId,
                itemId = orderitemid,
            };
            var endpoit = "api/orderitem";
            RestClient<OrderItemUpdateReq> client = new RestClient<OrderItemUpdateReq>(Program.BASE_URI);
            try
            {
                var response = await client.PutAsync<OrderItemUpdateReq, Result<string?>>(endpoit, orderitem);
                if (response!.Succeded)
                {
                    var resultid = response!.Data;
                    var found = (bd.DataSource as List<OrderItemUpdateReq>)?.FirstOrDefault(b => b.Id == resultid);
                    if (found != null)
                    {
                        found.orderItemKey = orderitemid;
                        found.quantity = Convert.ToInt32(quanity);
                        found.orderId = orderId;
                        found.itemId = itemId;
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
            if (bd.Current is not OrderItemResponse orderitem) return;
            if (MessageBox.Show($"Are you Sure to Delete the orderitem is,{orderitem.orderItemCode}", "Deleting",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            var endpoint = $"api/orderitem/{orderitem.Id}";
            RestClient<OrderItemResponse> client = new RestClient<OrderItemResponse>(Program.BASE_URI);
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
            var endpoit = "api/orderitem";
            RestClient<OrderItemResponse> client = new RestClient<OrderItemResponse>(Program.BASE_URI);
            try
            {
                var response = await client.GetAsync<Result<List<OrderItemResponse>>>(endpoit);
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
        private async void Order()
        {
            var endpoit = "api/order";
            RestClient<OrderResponse> client = new RestClient<OrderResponse>(Program.BASE_URI);
            try
            {
                var response = await client.GetAsync<Result<List<OrderResponse>>>(endpoit);
                if (response!.Succeded)
                {
                    var result = response!.Data;
                    foreach (var item in result)
                    {
                        cborderId.Items.Add(item.orderCode);
                        listorder.Add(item.Id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private async void Item()
        {
            var endpoit = "api/item";
            RestClient<ItemResponse> client = new RestClient<ItemResponse>(Program.BASE_URI);
            try
            {
                var response = await client.GetAsync<Result<List<ItemResponse>>>(endpoit);
                if (response!.Succeded)
                {
                    var result = response!.Data;
                    foreach (var item in result)
                    {
                        cbItemId.Items.Add(item.itemCode);
                        listitem.Add(item.Id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cborderId_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cborderId.SelectedIndex;
            orderId = listorder[index];
        }
        private void cbItemId_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cbItemId.SelectedIndex;
            itemId = listitem[index];
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
            txtorderItemId.Clear();
            txtQuanity.Clear();
        }
    }
}
