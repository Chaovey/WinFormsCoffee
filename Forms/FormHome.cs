
using CoffeeShop2.Models.Menus;
using CoffeeShop2.Result;
using RestClientLib;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsCoffee.Forms
{
    public partial class Menu : Form
    {
        private BindingSource bd = new BindingSource();
        private string id { get; set; } = default!;
        public Menu()
        {
            InitializeComponent();
            dataSoucre.DataSource = bd;
            dataSoucre.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Get();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private async void Get()
        {
            bd.DataSource = new List<MenuResponse>();
            var endpoit = "api/menu";
            RestClient<MenuResponse> client = new RestClient<MenuResponse>(Program.BASE_URI);
            try
            {
                var response = await client.GetAsync<Result<List<MenuResponse>>>(endpoit);
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

        private void FormHome_Load(object sender, EventArgs e)
        {

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (bd.Current == null) return;
            if (bd.Current is not MenuResponse menu) return;
            if (MessageBox.Show($"Are you Sure to Delete the menu is,{menu.menuCode}", "Deleting",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            var endpoint = $"api/menu/{menu.Id}";
            RestClient<MenuResponse> client = new RestClient<MenuResponse>(Program.BASE_URI);
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

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMenuID.Text, out int id1) == false) return;
            var id = txtMenuID.Text.Trim();
            if (string.IsNullOrEmpty(id) == true) return;
            var name = txtmenuName.Text.Trim();
            var desciption = txtmenuDes.Text.Trim();
            var price = txtmenuPrice.Text.Trim();
            var menu = new MenuCreateReq()
            {
                menuKey = id,
                Name = name,
                Description = desciption,
                Price = Convert.ToDouble(price),
            };
            var endpoit = "api/menu";
            RestClient<MenuCreateReq> client = new RestClient<MenuCreateReq>(Program.BASE_URI);
            try
            {
                var response = await client.PostAsync<MenuCreateReq, Result<string?>>(endpoit, menu);
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

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            var menuid = txtMenuID.Text.Trim();
            var name = txtmenuName.Text.Trim();
            var desciption = txtmenuDes.Text.Trim();
            var price = txtmenuPrice.Text.Trim();
            var menu = new MenuUpdateReq()
            {
                Id = id,
                menuKey = menuid,
                Name = name,
                Description = desciption,
                Price = Convert.ToDouble(price),
            };
            var endpoit = "api/menu/";
            RestClient<MenuUpdateReq> client = new RestClient<MenuUpdateReq>(Program.BASE_URI);
            try
            {
                var response = await client.PutAsync<MenuUpdateReq, Result<string?>>(endpoit, menu);
                if (response!.Succeded)
                {
                    var resultid = response!.Data;
                    var found = (bd.DataSource as List<MenuUpdateReq>)?.FirstOrDefault(b => b.Id == resultid);
                    if (found != null)
                    {
                        found.menuKey = menuid;
                        found.Name = name;
                        found.Description = desciption;
                        found.Price = Convert.ToDouble(price);
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

        private void btnRefeash_Click(object sender, EventArgs e)
        {
            Get();
        }

        private async void btnSreach_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMenuID.Text, out int menu) == false) return;
            var id = txtMenuID.Text.Trim();
            if (string.IsNullOrEmpty(id) == true) return;
            var endpoit = "api/menu";
            RestClient<MenuResponse> client = new RestClient<MenuResponse>(Program.BASE_URI);
            try
            {
                var response = await client.GetAsync<Result<List<MenuResponse>>>(endpoit);
                if (response!.Succeded)
                {
                    var result = response!.Data!.Where(p => p.menuCode.ToLower() == id.Trim().ToLower()).ToList() ?? new();
                    bd.DataSource = result;
                    bd.ResetBindings(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void dataSoucre_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataSoucre.Rows[e.RowIndex];
            id = selectedRow.Cells["id"].Value.ToString();
            txtID.Text = Convert.ToString(id);
        }
        private void clear()
        {
            txtID.Clear();
            txtMenuID.Clear();
            txtmenuDes.Clear();
            txtmenuName.Clear();
            txtmenuPrice.Clear();
        }
    }
}
