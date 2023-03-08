namespace Project_Database.CustomersPages
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.lblOrders = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbOrderID = new System.Windows.Forms.ComboBox();
            this.lblO_ID = new System.Windows.Forms.Label();
            this.lblTitleD = new System.Windows.Forms.Label();
            this.lblOrderStatusD = new System.Windows.Forms.Label();
            this.lblOrderStatus = new System.Windows.Forms.Label();
            this.lblOrderD = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblYearD = new System.Windows.Forms.Label();
            this.lblArtTypeD = new System.Windows.Forms.Label();
            this.lblPriceD = new System.Windows.Forms.Label();
            this.lblPaymentD = new System.Windows.Forms.Label();
            this.lblArtistD = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblArtType = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblArtistName = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrders
            // 
            this.lblOrders.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrders.Location = new System.Drawing.Point(508, 33);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(143, 54);
            this.lblOrders.TabIndex = 30;
            this.lblOrders.Text = "Orders";
            this.lblOrders.Click += new System.EventHandler(this.lblArtworks_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.Location = new System.Drawing.Point(625, 681);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 34);
            this.btnBack.TabIndex = 29;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDelete.Location = new System.Drawing.Point(443, 681);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 34);
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete Order";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.cmbOrderID);
            this.panel1.Controls.Add(this.lblO_ID);
            this.panel1.Controls.Add(this.lblTitleD);
            this.panel1.Controls.Add(this.lblOrderStatusD);
            this.panel1.Controls.Add(this.lblOrderStatus);
            this.panel1.Controls.Add(this.lblOrderD);
            this.panel1.Controls.Add(this.lblOrder);
            this.panel1.Controls.Add(this.lblYearD);
            this.panel1.Controls.Add(this.lblArtTypeD);
            this.panel1.Controls.Add(this.lblPriceD);
            this.panel1.Controls.Add(this.lblPaymentD);
            this.panel1.Controls.Add(this.lblArtistD);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Controls.Add(this.lblArtType);
            this.panel1.Controls.Add(this.lblPrice);
            this.panel1.Controls.Add(this.lblPayment);
            this.panel1.Controls.Add(this.lblArtistName);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Location = new System.Drawing.Point(104, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 533);
            this.panel1.TabIndex = 27;
            // 
            // cmbOrderID
            // 
            this.cmbOrderID.FormattingEnabled = true;
            this.cmbOrderID.Location = new System.Drawing.Point(269, 34);
            this.cmbOrderID.Name = "cmbOrderID";
            this.cmbOrderID.Size = new System.Drawing.Size(155, 33);
            this.cmbOrderID.TabIndex = 35;
            this.cmbOrderID.SelectedIndexChanged += new System.EventHandler(this.cmbOrderID_SelectedIndexChanged);
            // 
            // lblO_ID
            // 
            this.lblO_ID.AutoSize = true;
            this.lblO_ID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblO_ID.Location = new System.Drawing.Point(34, 29);
            this.lblO_ID.Name = "lblO_ID";
            this.lblO_ID.Size = new System.Drawing.Size(124, 38);
            this.lblO_ID.TabIndex = 34;
            this.lblO_ID.Text = "Order ID";
            // 
            // lblTitleD
            // 
            this.lblTitleD.AutoSize = true;
            this.lblTitleD.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleD.Location = new System.Drawing.Point(269, 83);
            this.lblTitleD.Name = "lblTitleD";
            this.lblTitleD.Size = new System.Drawing.Size(70, 38);
            this.lblTitleD.TabIndex = 33;
            this.lblTitleD.Text = "Title";
            // 
            // lblOrderStatusD
            // 
            this.lblOrderStatusD.AutoSize = true;
            this.lblOrderStatusD.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderStatusD.Location = new System.Drawing.Point(269, 479);
            this.lblOrderStatusD.Name = "lblOrderStatusD";
            this.lblOrderStatusD.Size = new System.Drawing.Size(171, 38);
            this.lblOrderStatusD.TabIndex = 32;
            this.lblOrderStatusD.Text = "Order Status";
            // 
            // lblOrderStatus
            // 
            this.lblOrderStatus.AutoSize = true;
            this.lblOrderStatus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderStatus.Location = new System.Drawing.Point(34, 479);
            this.lblOrderStatus.Name = "lblOrderStatus";
            this.lblOrderStatus.Size = new System.Drawing.Size(171, 38);
            this.lblOrderStatus.TabIndex = 31;
            this.lblOrderStatus.Text = "Order Status";
            // 
            // lblOrderD
            // 
            this.lblOrderD.AutoSize = true;
            this.lblOrderD.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderD.Location = new System.Drawing.Point(269, 428);
            this.lblOrderD.Name = "lblOrderD";
            this.lblOrderD.Size = new System.Drawing.Size(155, 38);
            this.lblOrderD.TabIndex = 30;
            this.lblOrderD.Text = "Order Date";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrder.Location = new System.Drawing.Point(34, 428);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(155, 38);
            this.lblOrder.TabIndex = 29;
            this.lblOrder.Text = "Order Date";
            // 
            // lblYearD
            // 
            this.lblYearD.AutoSize = true;
            this.lblYearD.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYearD.Location = new System.Drawing.Point(269, 264);
            this.lblYearD.Name = "lblYearD";
            this.lblYearD.Size = new System.Drawing.Size(69, 38);
            this.lblYearD.TabIndex = 28;
            this.lblYearD.Text = "Year";
            // 
            // lblArtTypeD
            // 
            this.lblArtTypeD.AutoSize = true;
            this.lblArtTypeD.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArtTypeD.Location = new System.Drawing.Point(269, 148);
            this.lblArtTypeD.Name = "lblArtTypeD";
            this.lblArtTypeD.Size = new System.Drawing.Size(120, 38);
            this.lblArtTypeD.TabIndex = 27;
            this.lblArtTypeD.Text = "Art Type";
            // 
            // lblPriceD
            // 
            this.lblPriceD.AutoSize = true;
            this.lblPriceD.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPriceD.Location = new System.Drawing.Point(269, 208);
            this.lblPriceD.Name = "lblPriceD";
            this.lblPriceD.Size = new System.Drawing.Size(78, 38);
            this.lblPriceD.TabIndex = 26;
            this.lblPriceD.Text = "Price";
            // 
            // lblPaymentD
            // 
            this.lblPaymentD.AutoSize = true;
            this.lblPaymentD.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPaymentD.Location = new System.Drawing.Point(269, 373);
            this.lblPaymentD.Name = "lblPaymentD";
            this.lblPaymentD.Size = new System.Drawing.Size(229, 38);
            this.lblPaymentD.TabIndex = 24;
            this.lblPaymentD.Text = "Payment Method";
            // 
            // lblArtistD
            // 
            this.lblArtistD.AutoSize = true;
            this.lblArtistD.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArtistD.Location = new System.Drawing.Point(269, 315);
            this.lblArtistD.Name = "lblArtistD";
            this.lblArtistD.Size = new System.Drawing.Size(82, 38);
            this.lblArtistD.TabIndex = 23;
            this.lblArtistD.Text = "Artist";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(632, 83);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 328);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(34, 264);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(69, 38);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year";
            // 
            // lblArtType
            // 
            this.lblArtType.AutoSize = true;
            this.lblArtType.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArtType.Location = new System.Drawing.Point(34, 148);
            this.lblArtType.Name = "lblArtType";
            this.lblArtType.Size = new System.Drawing.Size(120, 38);
            this.lblArtType.TabIndex = 6;
            this.lblArtType.Text = "Art Type";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrice.Location = new System.Drawing.Point(34, 208);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(78, 38);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "Price";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPayment.Location = new System.Drawing.Point(34, 373);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(229, 38);
            this.lblPayment.TabIndex = 12;
            this.lblPayment.Text = "Payment Method";
            // 
            // lblArtistName
            // 
            this.lblArtistName.AutoSize = true;
            this.lblArtistName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblArtistName.Location = new System.Drawing.Point(34, 315);
            this.lblArtistName.Name = "lblArtistName";
            this.lblArtistName.Size = new System.Drawing.Size(82, 38);
            this.lblArtistName.TabIndex = 14;
            this.lblArtistName.Text = "Artist";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(34, 83);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(70, 38);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title";
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1204, 737);
            this.Controls.Add(this.lblOrders);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Orders";
            this.Text = "Orders";
            this.Load += new System.EventHandler(this.Orders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblOrders;
        private Button btnBack;
        private Button btnDelete;
        private Panel panel1;
        private Label lblYearD;
        private Label lblArtTypeD;
        private Label lblPriceD;
        private Label lblPaymentD;
        private Label lblArtistD;
        private PictureBox pictureBox1;
        private Label lblYear;
        private Label lblArtType;
        private Label lblPrice;
        private Label lblPayment;
        private Label lblArtistName;
        private Label lblTitle;
        private Label lblOrderD;
        private Label lblOrder;
        private Label lblOrderStatusD;
        private Label lblOrderStatus;
        private ComboBox cmbOrderID;
        private Label lblO_ID;
        private Label lblTitleD;
    }
}