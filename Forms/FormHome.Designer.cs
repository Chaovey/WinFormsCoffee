namespace WinFormsCoffee.Forms
{
    partial class Menu
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
            txtMenuID = new TextBox();
            txtmenuName = new TextBox();
            txtmenuDes = new TextBox();
            txtmenuPrice = new TextBox();
            dataSoucre = new DataGridView();
            btnAdd = new Button();
            btnSreach = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            txtID = new TextBox();
            label5 = new Label();
            btnRefeash = new Button();
            ((System.ComponentModel.ISupportInitialize)dataSoucre).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 132);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "MenuId";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(16, 226);
            label2.Name = "label2";
            label2.Size = new Size(51, 19);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Book Antiqua", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 335);
            label3.Name = "label3";
            label3.Size = new Size(91, 19);
            label3.TabIndex = 2;
            label3.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Book Antiqua", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 431);
            label4.Name = "label4";
            label4.Size = new Size(50, 22);
            label4.TabIndex = 3;
            label4.Text = "Price";
            // 
            // txtMenuID
            // 
            txtMenuID.Location = new Point(132, 123);
            txtMenuID.Multiline = true;
            txtMenuID.Name = "txtMenuID";
            txtMenuID.Size = new Size(316, 34);
            txtMenuID.TabIndex = 4;
            // 
            // txtmenuName
            // 
            txtmenuName.Location = new Point(132, 223);
            txtmenuName.Multiline = true;
            txtmenuName.Name = "txtmenuName";
            txtmenuName.Size = new Size(316, 34);
            txtmenuName.TabIndex = 5;
            txtmenuName.TextChanged += textBox2_TextChanged;
            // 
            // txtmenuDes
            // 
            txtmenuDes.Location = new Point(132, 321);
            txtmenuDes.Multiline = true;
            txtmenuDes.Name = "txtmenuDes";
            txtmenuDes.Size = new Size(316, 34);
            txtmenuDes.TabIndex = 6;
            // 
            // txtmenuPrice
            // 
            txtmenuPrice.Location = new Point(132, 420);
            txtmenuPrice.Multiline = true;
            txtmenuPrice.Name = "txtmenuPrice";
            txtmenuPrice.Size = new Size(316, 34);
            txtmenuPrice.TabIndex = 7;
            // 
            // dataSoucre
            // 
            dataSoucre.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dataSoucre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSoucre.Location = new Point(551, 26);
            dataSoucre.Name = "dataSoucre";
            dataSoucre.RowHeadersWidth = 51;
            dataSoucre.Size = new Size(569, 571);
            dataSoucre.TabIndex = 8;
            dataSoucre.CellClick += dataSoucre_CellClick_1;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(5, 559);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(121, 38);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnSreach
            // 
            btnSreach.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSreach.Location = new Point(132, 559);
            btnSreach.Name = "btnSreach";
            btnSreach.Size = new Size(137, 38);
            btnSreach.TabIndex = 10;
            btnSreach.Text = "Search";
            btnSreach.UseVisualStyleBackColor = true;
            btnSreach.Click += btnSreach_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(275, 559);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(129, 38);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(410, 559);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(121, 38);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(132, 45);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(316, 34);
            txtID.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Book Antiqua", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(16, 48);
            label5.Name = "label5";
            label5.Size = new Size(26, 20);
            label5.TabIndex = 14;
            label5.Text = "ID";
            // 
            // btnRefeash
            // 
            btnRefeash.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRefeash.Location = new Point(5, 498);
            btnRefeash.Name = "btnRefeash";
            btnRefeash.Size = new Size(121, 38);
            btnRefeash.TabIndex = 15;
            btnRefeash.Text = "Refresh";
            btnRefeash.UseVisualStyleBackColor = true;
            btnRefeash.Click += btnRefeash_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 631);
            Controls.Add(btnRefeash);
            Controls.Add(label5);
            Controls.Add(txtID);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSreach);
            Controls.Add(btnAdd);
            Controls.Add(dataSoucre);
            Controls.Add(txtmenuPrice);
            Controls.Add(txtmenuDes);
            Controls.Add(txtmenuName);
            Controls.Add(txtMenuID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            Text = "Menu";
            Load += FormHome_Load;
            ((System.ComponentModel.ISupportInitialize)dataSoucre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtMenuID;
        private TextBox txtmenuName;
        private TextBox txtmenuDes;
        private TextBox txtmenuPrice;
        private DataGridView dataSoucre;
        private Button btnAdd;
        private Button btnSreach;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox txtID;
        private Label label5;
        private Button btnRefeash;
    }
}