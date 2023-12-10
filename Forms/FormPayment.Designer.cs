namespace WinFormsCoffee.Forms
{
    partial class Payment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtPaymentId = new TextBox();
            txtPaymentAmount = new TextBox();
            dataSoucre = new DataGridView();
            btnAdd = new Button();
            btnSreach = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefreash = new Button();
            label6 = new Label();
            txtId = new TextBox();
            dtPayment = new DateTimePicker();
            cbCustomerId = new ComboBox();
            cbOrderId = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataSoucre).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 91);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "PaymentId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 158);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 1;
            label2.Text = "PaymentAmount";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 241);
            label3.Name = "label3";
            label3.Size = new Size(101, 20);
            label3.TabIndex = 2;
            label3.Text = "Payment Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 318);
            label4.Name = "label4";
            label4.Size = new Size(85, 20);
            label4.TabIndex = 3;
            label4.Text = "CustomerId";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 402);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 4;
            label5.Text = "OrderId";
            // 
            // txtPaymentId
            // 
            txtPaymentId.Location = new Point(164, 91);
            txtPaymentId.Multiline = true;
            txtPaymentId.Name = "txtPaymentId";
            txtPaymentId.Size = new Size(297, 34);
            txtPaymentId.TabIndex = 5;
            // 
            // txtPaymentAmount
            // 
            txtPaymentAmount.Location = new Point(164, 155);
            txtPaymentAmount.Multiline = true;
            txtPaymentAmount.Name = "txtPaymentAmount";
            txtPaymentAmount.Size = new Size(297, 34);
            txtPaymentAmount.TabIndex = 6;
            // 
            // dataSoucre
            // 
            dataSoucre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSoucre.Location = new Point(507, 28);
            dataSoucre.Name = "dataSoucre";
            dataSoucre.RowHeadersWidth = 51;
            dataSoucre.Size = new Size(612, 512);
            dataSoucre.TabIndex = 10;
            dataSoucre.CellClick += dataSoucre_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(15, 511);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSreach
            // 
            btnSreach.Location = new Point(136, 511);
            btnSreach.Name = "btnSreach";
            btnSreach.Size = new Size(94, 29);
            btnSreach.TabIndex = 12;
            btnSreach.Text = "Sreach";
            btnSreach.UseVisualStyleBackColor = true;
            btnSreach.Click += btnSreach_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(258, 511);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(393, 511);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnRefreash
            // 
            btnRefreash.Location = new Point(12, 457);
            btnRefreash.Name = "btnRefreash";
            btnRefreash.Size = new Size(94, 29);
            btnRefreash.TabIndex = 15;
            btnRefreash.Text = "Refreash";
            btnRefreash.UseVisualStyleBackColor = true;
            btnRefreash.Click += btnRefreash_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 28);
            label6.Name = "label6";
            label6.Size = new Size(24, 20);
            label6.TabIndex = 16;
            label6.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(112, 28);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(349, 34);
            txtId.TabIndex = 17;
            // 
            // dtPayment
            // 
            dtPayment.Location = new Point(164, 234);
            dtPayment.Name = "dtPayment";
            dtPayment.Size = new Size(297, 27);
            dtPayment.TabIndex = 18;
            // 
            // cbCustomerId
            // 
            cbCustomerId.FormattingEnabled = true;
            cbCustomerId.Location = new Point(164, 310);
            cbCustomerId.Name = "cbCustomerId";
            cbCustomerId.Size = new Size(297, 28);
            cbCustomerId.TabIndex = 19;
            cbCustomerId.SelectedIndexChanged += cbCustomerId_SelectedIndexChanged;
            // 
            // cbOrderId
            // 
            cbOrderId.FormattingEnabled = true;
            cbOrderId.Location = new Point(164, 399);
            cbOrderId.Name = "cbOrderId";
            cbOrderId.Size = new Size(297, 28);
            cbOrderId.TabIndex = 20;
            cbOrderId.SelectedIndexChanged += cbOrderId_SelectedIndexChanged;
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 584);
            Controls.Add(cbOrderId);
            Controls.Add(cbCustomerId);
            Controls.Add(dtPayment);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(btnRefreash);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSreach);
            Controls.Add(btnAdd);
            Controls.Add(dataSoucre);
            Controls.Add(txtPaymentAmount);
            Controls.Add(txtPaymentId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Payment";
            Text = "Payment";
            Load += Payment_Load;
            ((System.ComponentModel.ISupportInitialize)dataSoucre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtPaymentId;
        private TextBox txtPaymentAmount;
        private DataGridView dataSoucre;
        private Button btnAdd;
        private Button btnSreach;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefreash;
        private Label label6;
        private TextBox txtId;
        private DateTimePicker dtPayment;
        private ComboBox cbCustomerId;
        private ComboBox cbOrderId;
    }
}