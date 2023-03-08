namespace Project_Database.Orders
{
    partial class deleteOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(deleteOrders));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.cmbC_ID = new System.Windows.Forms.ComboBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.cmbOrder = new System.Windows.Forms.ComboBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblC_ID = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Location = new System.Drawing.Point(437, 525);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 34);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(244, 525);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.cmbPayment);
            this.panel1.Controls.Add(this.cmbC_ID);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.txtStatus);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.cmbOrder);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblPayment);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.txtCost);
            this.panel1.Controls.Add(this.lblCost);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblC_ID);
            this.panel1.Controls.Add(this.lblOrderID);
            this.panel1.Location = new System.Drawing.Point(29, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 457);
            this.panel1.TabIndex = 16;
            // 
            // cmbPayment
            // 
            this.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Items.AddRange(new object[] {
            "Cash",
            "Online"});
            this.cmbPayment.Location = new System.Drawing.Point(270, 322);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(163, 33);
            this.cmbPayment.TabIndex = 36;
            // 
            // cmbC_ID
            // 
            this.cmbC_ID.FormattingEnabled = true;
            this.cmbC_ID.Location = new System.Drawing.Point(270, 86);
            this.cmbC_ID.Name = "cmbC_ID";
            this.cmbC_ID.Size = new System.Drawing.Size(163, 33);
            this.cmbC_ID.TabIndex = 35;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(270, 150);
            this.txtTitle.MaximumSize = new System.Drawing.Size(0, 35);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(379, 31);
            this.txtTitle.TabIndex = 34;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(270, 383);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(379, 31);
            this.txtStatus.TabIndex = 30;
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Location = new System.Drawing.Point(270, 265);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(196, 31);
            this.date.TabIndex = 23;
            // 
            // cmbOrder
            // 
            this.cmbOrder.FormattingEnabled = true;
            this.cmbOrder.Location = new System.Drawing.Point(270, 28);
            this.cmbOrder.Name = "cmbOrder";
            this.cmbOrder.Size = new System.Drawing.Size(163, 33);
            this.cmbOrder.TabIndex = 22;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(35, 375);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(91, 38);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPayment.Location = new System.Drawing.Point(35, 317);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(229, 38);
            this.lblPayment.TabIndex = 4;
            this.lblPayment.Text = "Payment Method";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(35, 259);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(75, 38);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(270, 208);
            this.txtCost.MaximumSize = new System.Drawing.Size(0, 35);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(196, 31);
            this.txtCost.TabIndex = 9;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCost.Location = new System.Drawing.Point(35, 201);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(71, 38);
            this.lblCost.TabIndex = 8;
            this.lblCost.Text = "Cost";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(35, 143);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(70, 38);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Title";
            // 
            // lblC_ID
            // 
            this.lblC_ID.AutoSize = true;
            this.lblC_ID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblC_ID.Location = new System.Drawing.Point(35, 78);
            this.lblC_ID.Name = "lblC_ID";
            this.lblC_ID.Size = new System.Drawing.Size(171, 38);
            this.lblC_ID.TabIndex = 14;
            this.lblC_ID.Text = "Customer ID";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrderID.Location = new System.Drawing.Point(35, 20);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(124, 38);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "Order ID";
            // 
            // deleteOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(821, 603);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "deleteOrders";
            this.Text = "Delete Orders";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnExit;
        private Button btnAdd;
        private Panel panel1;
        private ComboBox cmbPayment;
        private ComboBox cmbC_ID;
        private TextBox txtTitle;
        private TextBox txtStatus;
        private DateTimePicker date;
        private ComboBox cmbOrder;
        private Label lblStatus;
        private Label lblPayment;
        private Label lblDate;
        private TextBox txtCost;
        private Label lblCost;
        private Label lblTitle;
        private Label lblC_ID;
        private Label lblOrderID;
    }
}