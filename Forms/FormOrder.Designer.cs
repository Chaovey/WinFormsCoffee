namespace WinFormsCoffee.Forms
{
    partial class Order
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
            txtorderId = new TextBox();
            txtorderStatus = new TextBox();
            txtPrice = new TextBox();
            dataSoucre = new DataGridView();
            btnAdd = new Button();
            btnSreach = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label6 = new Label();
            txtId = new TextBox();
            btnRefresh = new Button();
            cbMenuId = new ComboBox();
            cbCustomerID = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataSoucre).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 104);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "OrderId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 175);
            label2.Name = "label2";
            label2.Size = new Size(87, 20);
            label2.TabIndex = 1;
            label2.Text = "OrderStatus";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 265);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 2;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 342);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 3;
            label4.Text = "MenuID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 431);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 4;
            label5.Text = "CustomerID";
            // 
            // txtorderId
            // 
            txtorderId.Location = new Point(125, 104);
            txtorderId.Multiline = true;
            txtorderId.Name = "txtorderId";
            txtorderId.Size = new Size(291, 34);
            txtorderId.TabIndex = 5;
            // 
            // txtorderStatus
            // 
            txtorderStatus.Location = new Point(125, 175);
            txtorderStatus.Multiline = true;
            txtorderStatus.Name = "txtorderStatus";
            txtorderStatus.Size = new Size(291, 34);
            txtorderStatus.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(123, 262);
            txtPrice.Multiline = true;
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(293, 34);
            txtPrice.TabIndex = 7;
            // 
            // dataSoucre
            // 
            dataSoucre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSoucre.Location = new Point(471, 39);
            dataSoucre.Name = "dataSoucre";
            dataSoucre.RowHeadersWidth = 51;
            dataSoucre.Size = new Size(631, 523);
            dataSoucre.TabIndex = 10;
            dataSoucre.CellClick += dataSoucre_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(13, 533);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 11;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSreach
            // 
            btnSreach.Location = new Point(125, 529);
            btnSreach.Name = "btnSreach";
            btnSreach.Size = new Size(94, 33);
            btnSreach.TabIndex = 12;
            btnSreach.Text = "Sreach";
            btnSreach.UseVisualStyleBackColor = true;
            btnSreach.Click += btnSreach_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(237, 531);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(356, 531);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 39);
            label6.Name = "label6";
            label6.Size = new Size(24, 20);
            label6.TabIndex = 15;
            label6.Text = "ID";
            // 
            // txtId
            // 
            txtId.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(125, 36);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(291, 34);
            txtId.TabIndex = 16;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(13, 483);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 17;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // cbMenuId
            // 
            cbMenuId.FormattingEnabled = true;
            cbMenuId.Location = new Point(125, 342);
            cbMenuId.Name = "cbMenuId";
            cbMenuId.Size = new Size(291, 28);
            cbMenuId.TabIndex = 18;
            cbMenuId.SelectedIndexChanged += cbMenuId_SelectedIndexChanged;
            // 
            // cbCustomerID
            // 
            cbCustomerID.FormattingEnabled = true;
            cbCustomerID.Location = new Point(125, 423);
            cbCustomerID.Name = "cbCustomerID";
            cbCustomerID.Size = new Size(291, 28);
            cbCustomerID.TabIndex = 19;
            cbCustomerID.SelectedIndexChanged += cbCustomerID_SelectedIndexChanged;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 584);
            Controls.Add(cbCustomerID);
            Controls.Add(cbMenuId);
            Controls.Add(btnRefresh);
            Controls.Add(txtId);
            Controls.Add(label6);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSreach);
            Controls.Add(btnAdd);
            Controls.Add(dataSoucre);
            Controls.Add(txtPrice);
            Controls.Add(txtorderStatus);
            Controls.Add(txtorderId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Order";
            Text = "Order";
            Load += FormOrder_Load;
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
        private TextBox txtorderId;
        private TextBox txtorderStatus;
        private TextBox txtPrice;
        private DataGridView dataSoucre;
        private Button btnAdd;
        private Button btnSreach;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label6;
        private TextBox txtId;
        private Button btnRefresh;
        private ComboBox cbMenuId;
        private ComboBox cbCustomerID;
    }
}