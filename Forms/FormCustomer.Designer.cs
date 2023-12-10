namespace WinFormsCoffee.Forms
{
    partial class Customer
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
            dataGridView1 = new DataGridView();
            txtCustomerId = new TextBox();
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtOrderH = new TextBox();
            btnAdd = new Button();
            btnSreach = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtID = new TextBox();
            label5 = new Label();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 120);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 0;
            label1.Text = "CustomerId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 219);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 317);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 413);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 3;
            label4.Text = "OrderHistory";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(460, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(659, 470);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(159, 120);
            txtCustomerId.Multiline = true;
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(244, 34);
            txtCustomerId.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(159, 205);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(244, 34);
            txtName.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(159, 303);
            txtPhone.Multiline = true;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(244, 34);
            txtPhone.TabIndex = 7;
            // 
            // txtOrderH
            // 
            txtOrderH.Location = new Point(159, 399);
            txtOrderH.Multiline = true;
            txtOrderH.Name = "txtOrderH";
            txtOrderH.Size = new Size(244, 34);
            txtOrderH.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 506);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSreach
            // 
            btnSreach.Location = new Point(125, 506);
            btnSreach.Name = "btnSreach";
            btnSreach.Size = new Size(94, 29);
            btnSreach.TabIndex = 10;
            btnSreach.Text = "Sreach";
            btnSreach.UseVisualStyleBackColor = true;
            btnSreach.Click += btnSreach_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(235, 506);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(349, 506);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(159, 49);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(244, 34);
            txtID.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 52);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 14;
            label5.Text = "ID";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(12, 457);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 15;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 584);
            Controls.Add(btnRefresh);
            Controls.Add(label5);
            Controls.Add(txtID);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSreach);
            Controls.Add(btnAdd);
            Controls.Add(txtOrderH);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(txtCustomerId);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Customer";
            Text = "Customer";
            Load += FormCustomer_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private TextBox txtCustomerId;
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtOrderH;
        private Button btnAdd;
        private Button btnSreach;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtID;
        private Label label5;
        private Button btnRefresh;
    }
}