using CoffeeShop2.Models.Customers;
using CoffeeShop2.Models.OrderItems;
using CoffeeShop2.Models.Orders;
using CoffeeShop2.Models.Payments;
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
    public partial class Payment : Form
    {
        private BindingSource bd = new BindingSource();
        private string id { get; set; } = default!;
        private string orderId { get; set; } = default!;
        private string customerId { get; set; } = default!;
        private List<string>? listorder = [];
        private List<string>? listcustomer = [];
        public Payment()
        {
            InitializeComponent();
            dataSoucre.DataSource = bd;
            dataSoucre.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Get();
            Order();
            Customer();
        }

        private void btnRefreash_Click(object sender, EventArgs e)
        {
            Get();
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtPaymentId.Text, out int id1) == false) return;
            var paymentid = txtPaymentId.Text.Trim();
            if (string.IsNullOrEmpty(paymentid) == true) return;
            var paymentamount=txtPaymentAmount.Text.Trim();
            var paymentDate = dtPayment.Text.Trim();
            var customer = customerId;
            var order = orderId;
            var orderItem = new PaymentCreateReq()
            {
                paymentKey = paymentid,
                paymentAmount = Convert.ToDouble(paymentamount),
                paymentDate=Convert.ToDateTime(paymentDate),
                CustomerId = customer,
                orderId=order,
            };
            var endpoit = "api/payment";
            RestClient<PaymentCreateReq> client = new RestClient<PaymentCreateReq>(Program.BASE_URI);
            try
            {
                var response = await client.PostAsync<PaymentCreateReq, Result<string?>>(endpoit, orderItem);
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
            if (int.TryParse(txtPaymentId.Text, out int menu) == false) return;
            var id = txtPaymentId.Text.Trim();
            if (string.IsNullOrEmpty(id) == true) return;
            var endpoit = "api/payment";
            RestClient<PaymentResponse> client = new RestClient<PaymentResponse>(Program.BASE_URI);
            try
            {
                var response = await client.GetAsync<Result<List<PaymentResponse>>>(endpoit);
                if (response!.Succeded)
                {
                    var result = response!.Data!.Where(p => p.paymentCode.ToLower() == id.Trim().ToLower()).ToList() ?? new();
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
            if (int.TryParse(txtPaymentId.Text, out int item) == false) return;
            var paymentid = txtPaymentId.Text.Trim();
            if (string.IsNullOrEmpty(paymentid) == true) return;
            var paymentamount = txtPaymentAmount.Text.Trim();
            var paymentDate = dtPayment.Text.Trim();
            var customer = customerId;
            var order = orderId;
            var orderitem = new PaymentUpdateReq()
            {
                Id = id,
                paymentKey = paymentid,
                paymentAmount = Convert.ToDouble(paymentamount),
                paymentDate = Convert.ToDateTime(paymentDate),
                CustomerId = customer,
                orderId = order,
            };
            var endpoit = "api/payment";
            RestClient<PaymentUpdateReq> client = new RestClient<PaymentUpdateReq>(Program.BASE_URI);
            try
            {
                var response = await client.PutAsync<PaymentUpdateReq, Result<string?>>(endpoit, orderitem);
                if (response!.Succeded)
                {
                    var resultid = response!.Data;
                    var found = (bd.DataSource as List<PaymentUpdateReq>)?.FirstOrDefault(b => b.Id == resultid);
                    if (found != null)
                    {
                        found.paymentKey = paymentid;
                        found.paymentAmount = Convert.ToDouble(paymentamount);
                        found.paymentDate = Convert.ToDateTime(paymentDate);
                        found.CustomerId = customer;
                        found.orderId = order;
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

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (bd.Current == null) return;
            if (bd.Current is not PaymentResponse payment) return;
            if (MessageBox.Show($"Are you Sure to Delete the payment is,{payment.paymentCode}", "Deleting",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            var endpoint = $"api/orderitem/{payment.Id}";
            RestClient<PaymentResponse> client = new RestClient<PaymentResponse>(Program.BASE_URI);
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

        private void dataSoucre_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataSoucre.Rows[e.RowIndex];
            id = selectedRow.Cells["id"].Value.ToString();
            txtId.Text = Convert.ToString(id);
        }
        private async void Get()
        {
            bd.DataSource = new List<OrderResponse>();
            var endpoit = "api/payment";
            RestClient<PaymentResponse> client = new RestClient<PaymentResponse>(Program.BASE_URI);
            try
            {
                var response = await client.GetAsync<Result<List<PaymentResponse>>>(endpoit);
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
                        cbOrderId.Items.Add(item.orderCode);
                        listorder.Add(item.Id);
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
                    var result = response!.Data;
                    foreach (var item in result)
                    {
                        cbCustomerId.Items.Add(item.customerCode);
                        listcustomer.Add(item.Id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbCustomerId_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index=cbCustomerId.SelectedIndex;
            customerId = listcustomer[index];
        }

        private void cbOrderId_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cbOrderId.SelectedIndex;
            orderId = listorder[index];
        }
        private void clear()
        {
            txtId.Clear();
            txtPaymentAmount.Clear();
            txtPaymentId.Clear();
            cbCustomerId.SelectedIndex = 0;
            cbOrderId.SelectedIndex = 0;
        }
    }
}
