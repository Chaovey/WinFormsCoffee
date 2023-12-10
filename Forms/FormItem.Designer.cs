namespace WinFormsCoffee.Forms
{
    partial class Item
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
            txtitemId = new TextBox();
            txtitemName = new TextBox();
            txtitemdes = new TextBox();
            txtsizeitem = new TextBox();
            dataSoucre = new DataGridView();
            btnAdd = new Button();
            btnSearch = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label5 = new Label();
            txtId = new TextBox();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataSoucre).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 125);
            label1.Name = "label1";
            label1.Size = new Size(54, 20);
            label1.TabIndex = 0;
            label1.Text = "ItemID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 219);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(23, 330);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(23, 421);
            label4.Name = "label4";
            label4.Size = new Size(40, 23);
            label4.TabIndex = 3;
            label4.Text = "Size";
            // 
            // txtitemId
            // 
            txtitemId.Location = new Point(142, 111);
            txtitemId.Multiline = true;
            txtitemId.Name = "txtitemId";
            txtitemId.Size = new Size(319, 34);
            txtitemId.TabIndex = 4;
            // 
            // txtitemName
            // 
            txtitemName.Location = new Point(142, 205);
            txtitemName.Multiline = true;
            txtitemName.Name = "txtitemName";
            txtitemName.Size = new Size(319, 34);
            txtitemName.TabIndex = 5;
            // 
            // txtitemdes
            // 
            txtitemdes.Location = new Point(142, 316);
            txtitemdes.Multiline = true;
            txtitemdes.Name = "txtitemdes";
            txtitemdes.Size = new Size(319, 34);
            txtitemdes.TabIndex = 6;
            // 
            // txtsizeitem
            // 
            txtsizeitem.Location = new Point(142, 410);
            txtsizeitem.Multiline = true;
            txtsizeitem.Name = "txtsizeitem";
            txtsizeitem.Size = new Size(319, 34);
            txtsizeitem.TabIndex = 7;
            // 
            // dataSoucre
            // 
            dataSoucre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSoucre.Location = new Point(539, 43);
            dataSoucre.Name = "dataSoucre";
            dataSoucre.RowHeadersWidth = 51;
            dataSoucre.Size = new Size(615, 515);
            dataSoucre.TabIndex = 8;
            dataSoucre.CellClick += dataSoucre_CellClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(11, 529);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(135, 529);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(268, 529);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(404, 529);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(23, 46);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 13;
            label5.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(142, 43);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(319, 34);
            txtId.TabIndex = 14;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(11, 479);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 15;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // Item
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 590);
            Controls.Add(btnRefresh);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSearch);
            Controls.Add(btnAdd);
            Controls.Add(dataSoucre);
            Controls.Add(txtsizeitem);
            Controls.Add(txtitemdes);
            Controls.Add(txtitemName);
            Controls.Add(txtitemId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Item";
            Text = "Item";
            Load += FormItem_Load;
            ((System.ComponentModel.ISupportInitialize)dataSoucre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtitemId;
        private TextBox txtitemName;
        private TextBox txtitemdes;
        private TextBox txtsizeitem;
        private DataGridView dataSoucre;
        private Button btnAdd;
        private Button btnSearch;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label5;
        private TextBox txtId;
        private Button btnRefresh;
    }
}