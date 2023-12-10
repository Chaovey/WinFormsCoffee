using CoffeeShop2.Models.Customers;
using CoffeeShop2.Models.Items;
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
    public partial class Item : Form
    {
        private BindingSource bd = new BindingSource();
        private string id { get; set; } = default!;
        public Item()
        {
            InitializeComponent();
            dataSoucre.DataSource = bd;
            dataSoucre.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Get();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private async void Get()
        {
            RestClient<ItemResponse> client = new RestClient<ItemResponse>(Program.BASE_URI);
            bd.DataSource = new List<ItemResponse>();
            var endpoit = "api/item";
            try
            {
                var response = await client.GetAsync<Result<List<ItemResponse>>>(endpoit);

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

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtitemId.Text, out int item) == false) return;
            var itemid = txtitemId.Text.Trim();
            if (string.IsNullOrEmpty(itemid) == true) return;
            var name = txtitemName.Text.Trim();
            var desciption = txtitemdes.Text.Trim();
            var size = txtsizeitem.Text.Trim();
            var item1 = new ItemCreateReq()
            {
                itemKey = itemid,
                Name = name,
                Description = desciption,
                size = size,
            };
            var endpoit = "api/item";
            RestClient<ItemCreateReq> client = new RestClient<ItemCreateReq>(Program.BASE_URI);
            try
            {
                var response = await client.PostAsync<ItemCreateReq, Result<string?>>(endpoit, item1);
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

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtitemId.Text, out int menu) == false) return;
            var id = txtitemId.Text.Trim();
            if (string.IsNullOrEmpty(id) == true) return;
            var endpoit = "api/customer";
            RestClient<ItemResponse> client = new RestClient<ItemResponse>(Program.BASE_URI);
            try
            {
                var response = await client.GetAsync<Result<List<ItemResponse>>>(endpoit);
                if (response!.Succeded)
                {
                    var result = response!.Data!.Where(p => p.itemCode.ToLower() == id.Trim().ToLower()).ToList() ?? new();
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
            if (int.TryParse(txtitemId.Text, out int item) == false) return;
            var itemid = txtitemId.Text.Trim();
            if (string.IsNullOrEmpty(itemid) == true) return;
            var name = txtitemName.Text.Trim();
            var desciption = txtitemdes.Text.Trim();
            var size = txtsizeitem.Text.Trim();
            var item1 = new ItemUpdateReq()
            {
                Id = id,
                itemKey = itemid,
                Name = name,
                Description = desciption,
                size = size,
            };
            var endpoit = "api/customer";
            RestClient<ItemUpdateReq> client = new RestClient<ItemUpdateReq>(Program.BASE_URI);
            try
            {
                var response = await client.PutAsync<ItemUpdateReq, Result<string?>>(endpoit, item1);
                if (response!.Succeded)
                {
                    var resultid = response!.Data;
                    var found = (bd.DataSource as List<ItemUpdateReq>)?.FirstOrDefault(b => b.Id == resultid);
                    if (found != null)
                    {
                        found.itemKey = itemid;
                        found.Name = name;
                        found.Description = desciption;
                        found.size = size;
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
            if (bd.Current is not ItemResponse item) return;
            if (MessageBox.Show($"Are you Sure to Delete the item is,{item.Id}", "Deleting",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            var endpoint = $"api/item/{item.Id}";
            RestClient<ItemResponse> client = new RestClient<ItemResponse>(Program.BASE_URI);
            try
            {
                var response = await client.DeleteAsync<Result<string?>>(endpoint);
                if (response!.Succeded)
                {
                    bd.RemoveCurrent();
                    bd.ResetBindings(false);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormItem_Load(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Get();
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
            txtitemId.Clear();
            txtitemdes.Clear(); 
            txtitemName.Clear();
            txtsizeitem.Clear();
        }
    }
}
