namespace WinFormsCoffee
{
    partial class Coffee
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Coffee));
            panelMenu = new Panel();
            btnPayment = new Button();
            btnCustomer = new Button();
            btnOrderitem = new Button();
            panelLogo = new Panel();
            label1 = new Label();
            button2 = new Button();
            btnOrder = new Button();
            btnMenu = new Button();
            panelHeader = new Panel();
            btnSub = new Button();
            btnFull = new Button();
            btnClose = new Button();
            lbHeader = new Label();
            panelBody = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(0, 0, 192);
            panelMenu.Controls.Add(btnPayment);
            panelMenu.Controls.Add(btnCustomer);
            panelMenu.Controls.Add(btnOrderitem);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(btnOrder);
            panelMenu.Controls.Add(btnMenu);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(172, 692);
            panelMenu.TabIndex = 0;
            // 
            // btnPayment
            // 
            btnPayment.FlatAppearance.BorderSize = 0;
            btnPayment.FlatStyle = FlatStyle.Flat;
            btnPayment.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPayment.Location = new Point(0, 537);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(172, 46);
            btnPayment.TabIndex = 6;
            btnPayment.Text = "Payment";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.FlatAppearance.BorderSize = 0;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCustomer.Location = new Point(0, 456);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(172, 46);
            btnCustomer.TabIndex = 5;
            btnCustomer.Text = "Customer";
            btnCustomer.UseVisualStyleBackColor = true;
            btnCustomer.Click += btnCustomer_Click;
            // 
            // btnOrderitem
            // 
            btnOrderitem.FlatAppearance.BorderSize = 0;
            btnOrderitem.FlatStyle = FlatStyle.Flat;
            btnOrderitem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrderitem.ForeColor = Color.Black;
            btnOrderitem.Location = new Point(3, 363);
            btnOrderitem.Name = "btnOrderitem";
            btnOrderitem.Size = new Size(172, 46);
            btnOrderitem.TabIndex = 4;
            btnOrderitem.Text = "Order Item";
            btnOrderitem.UseVisualStyleBackColor = true;
            btnOrderitem.Click += button1_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.Navy;
            panelLogo.Controls.Add(label1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(172, 64);
            panelLogo.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 0;
            label1.Text = "Coffee System";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(3, 285);
            button2.Name = "button2";
            button2.Size = new Size(172, 46);
            button2.TabIndex = 2;
            button2.Text = "Item";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnOrder
            // 
            btnOrder.FlatAppearance.BorderSize = 0;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrder.ForeColor = Color.Black;
            btnOrder.Location = new Point(3, 214);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(172, 46);
            btnOrder.TabIndex = 1;
            btnOrder.Text = "Order";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnMenu
            // 
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = Color.Black;
            btnMenu.Location = new Point(0, 141);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(172, 46);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnHome_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.Teal;
            panelHeader.Controls.Add(btnSub);
            panelHeader.Controls.Add(btnFull);
            panelHeader.Controls.Add(btnClose);
            panelHeader.Controls.Add(lbHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(172, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1149, 61);
            panelHeader.TabIndex = 1;
            // 
            // btnSub
            // 
            btnSub.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSub.FlatAppearance.BorderSize = 0;
            btnSub.FlatStyle = FlatStyle.Flat;
            btnSub.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSub.ForeColor = Color.White;
            btnSub.Location = new Point(1035, 12);
            btnSub.Name = "btnSub";
            btnSub.Size = new Size(30, 30);
            btnSub.TabIndex = 0;
            btnSub.Text = "-";
            btnSub.UseVisualStyleBackColor = true;
            btnSub.Click += btnSub_Click_1;
            // 
            // btnFull
            // 
            btnFull.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnFull.FlatAppearance.BorderSize = 0;
            btnFull.FlatStyle = FlatStyle.Flat;
            btnFull.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFull.ForeColor = Color.White;
            btnFull.Location = new Point(1071, 12);
            btnFull.Name = "btnFull";
            btnFull.Size = new Size(30, 30);
            btnFull.TabIndex = 2;
            btnFull.Text = "O";
            btnFull.UseVisualStyleBackColor = true;
            btnFull.Click += btnFull_Click_1;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1107, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 1;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // lbHeader
            // 
            lbHeader.AutoSize = true;
            lbHeader.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbHeader.Location = new Point(506, 19);
            lbHeader.Name = "lbHeader";
            lbHeader.Size = new Size(75, 31);
            lbHeader.TabIndex = 0;
            lbHeader.Text = "Home";
            // 
            // panelBody
            // 
            panelBody.BackColor = SystemColors.ActiveCaption;
            panelBody.BackgroundImage = (Image)resources.GetObject("panelBody.BackgroundImage");
            panelBody.BackgroundImageLayout = ImageLayout.Zoom;
            panelBody.Dock = DockStyle.Fill;
            panelBody.Location = new Point(172, 61);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(1149, 631);
            panelBody.TabIndex = 2;
            panelBody.MouseDown += panelBody_MouseDown;
            // 
            // Coffee
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1321, 692);
            Controls.Add(panelBody);
            Controls.Add(panelHeader);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Coffee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Coffee";
            Load += Form1_Load;
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            panelLogo.PerformLayout();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button btnHome;
        private Button button2;
        private Button btnOrder;
        private Panel panelHeader;
        private Label lbHeader;
        private Panel panelLogo;
        private Label label1;
        private Panel panelBody;
        private Button btnClose;
        private Button btnSub;
        private Button btnFull;
        private Button btnMenu;
        private Button btnOrderitem;
        private Button btnPayment;
        private Button btnCustomer;
    }
}
