namespace WinFormsCoffee.Forms
{
    partial class Orderitem
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
            dataSoucre = new DataGridView();
            txtorderItemId = new TextBox();
            txtQuanity = new TextBox();
            btnAdd = new Button();
            brnSreach = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            label5 = new Label();
            txtId = new TextBox();
            cborderId = new ComboBox();
            cbItemId = new ComboBox();
            btnRefreash = new Button();
            ((System.ComponentModel.ISupportInitialize)dataSoucre).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 119);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 0;
            label1.Text = "Order_Item ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 200);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 1;
            label2.Text = "Quanity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(31, 289);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "OrderID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 391);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "ItemID";
            // 
            // dataSoucre
            // 
            dataSoucre.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataSoucre.Location = new Point(454, 63);
            dataSoucre.Name = "dataSoucre";
            dataSoucre.RowHeadersWidth = 51;
            dataSoucre.Size = new Size(665, 488);
            dataSoucre.TabIndex = 4;
            dataSoucre.CellClick += dataSoucre_CellClick;
            // 
            // txtorderItemId
            // 
            txtorderItemId.Location = new Point(155, 119);
            txtorderItemId.Multiline = true;
            txtorderItemId.Name = "txtorderItemId";
            txtorderItemId.Size = new Size(243, 34);
            txtorderItemId.TabIndex = 5;
            // 
            // txtQuanity
            // 
            txtQuanity.Location = new Point(155, 200);
            txtQuanity.Multiline = true;
            txtQuanity.Name = "txtQuanity";
            txtQuanity.Size = new Size(243, 34);
            txtQuanity.TabIndex = 6;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 503);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 34);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // brnSreach
            // 
            brnSreach.Location = new Point(112, 503);
            brnSreach.Name = "brnSreach";
            brnSreach.Size = new Size(101, 34);
            brnSreach.TabIndex = 10;
            brnSreach.Text = "Sreach";
            brnSreach.UseVisualStyleBackColor = true;
            brnSreach.Click += brnSreach_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(219, 503);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(98, 34);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(333, 503);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(106, 34);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 63);
            label5.Name = "label5";
            label5.Size = new Size(24, 20);
            label5.TabIndex = 13;
            label5.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(88, 49);
            txtId.Multiline = true;
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(310, 34);
            txtId.TabIndex = 14;
            // 
            // cborderId
            // 
            cborderId.FormattingEnabled = true;
            cborderId.Location = new Point(155, 289);
            cborderId.Name = "cborderId";
            cborderId.Size = new Size(243, 28);
            cborderId.TabIndex = 15;
            cborderId.SelectedIndexChanged += cborderId_SelectedIndexChanged;
            // 
            // cbItemId
            // 
            cbItemId.FormattingEnabled = true;
            cbItemId.Location = new Point(155, 383);
            cbItemId.Name = "cbItemId";
            cbItemId.Size = new Size(243, 28);
            cbItemId.TabIndex = 16;
            cbItemId.SelectedIndexChanged += cbItemId_SelectedIndexChanged;
            // 
            // btnRefreash
            // 
            btnRefreash.Location = new Point(12, 446);
            btnRefreash.Name = "btnRefreash";
            btnRefreash.Size = new Size(94, 34);
            btnRefreash.TabIndex = 17;
            btnRefreash.Text = "Refreash";
            btnRefreash.UseVisualStyleBackColor = true;
            btnRefreash.Click += btnRefreash_Click;
            // 
            // Orderitem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 584);
            Controls.Add(btnRefreash);
            Controls.Add(cbItemId);
            Controls.Add(cborderId);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(brnSreach);
            Controls.Add(btnAdd);
            Controls.Add(txtQuanity);
            Controls.Add(txtorderItemId);
            Controls.Add(dataSoucre);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Orderitem";
            Text = "Orderitem";
            ((System.ComponentModel.ISupportInitialize)dataSoucre).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataSoucre;
        private TextBox txtorderItemId;
        private TextBox txtQuanity;
        private Button btnAdd;
        private Button brnSreach;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label5;
        private TextBox txtId;
        private ComboBox cborderId;
        private ComboBox cbItemId;
        private Button btnRefreash;
    }
}