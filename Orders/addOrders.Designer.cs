namespace Project_Database.Orders
{
    partial class addOrders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addOrders));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbTitle = new System.Windows.Forms.ComboBox();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.cmbC_ID = new System.Windows.Forms.ComboBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtCost = new System.Windows.Forms.TextBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblC_ID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Location = new System.Drawing.Point(436, 490);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 34);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdd.Location = new System.Drawing.Point(243, 490);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 34);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.cmbTitle);
            this.panel1.Controls.Add(this.cmbPayment);
            this.panel1.Controls.Add(this.cmbC_ID);
            this.panel1.Controls.Add(this.txtStatus);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblPayment);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.txtCost);
            this.panel1.Controls.Add(this.lblCost);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.lblC_ID);
            this.panel1.Location = new System.Drawing.Point(28, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(762, 411);
            this.panel1.TabIndex = 13;
            // 
            // cmbTitle
            // 
            this.cmbTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTitle.FormattingEnabled = true;
            this.cmbTitle.Location = new System.Drawing.Point(270, 102);
            this.cmbTitle.Name = "cmbTitle";
            this.cmbTitle.Size = new System.Drawing.Size(379, 33);
            this.cmbTitle.TabIndex = 37;
            // 
            // cmbPayment
            // 
            this.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Items.AddRange(new object[] {
            "Cash",
            "Online"});
            this.cmbPayment.Location = new System.Drawing.Point(270, 273);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(163, 33);
            this.cmbPayment.TabIndex = 36;
            // 
            // cmbC_ID
            // 
            this.cmbC_ID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbC_ID.FormattingEnabled = true;
            this.cmbC_ID.Location = new System.Drawing.Point(270, 37);
            this.cmbC_ID.Name = "cmbC_ID";
            this.cmbC_ID.Size = new System.Drawing.Size(163, 33);
            this.cmbC_ID.TabIndex = 35;
            this.cmbC_ID.SelectedIndexChanged += new System.EventHandler(this.cmbC_ID_SelectedIndexChanged);
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(270, 334);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(379, 31);
            this.txtStatus.TabIndex = 30;
            // 
            // date
            // 
            this.date.Enabled = false;
            this.date.Location = new System.Drawing.Point(270, 216);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(196, 31);
            this.date.TabIndex = 23;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblStatus.Location = new System.Drawing.Point(35, 326);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(91, 38);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPayment.Location = new System.Drawing.Point(35, 268);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(229, 38);
            this.lblPayment.TabIndex = 4;
            this.lblPayment.Text = "Payment Method";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(35, 210);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(75, 38);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "Date";
            // 
            // txtCost
            // 
            this.txtCost.Location = new System.Drawing.Point(270, 159);
            this.txtCost.MaximumSize = new System.Drawing.Size(0, 35);
            this.txtCost.Name = "txtCost";
            this.txtCost.Size = new System.Drawing.Size(196, 31);
            this.txtCost.TabIndex = 9;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCost.Location = new System.Drawing.Point(35, 152);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(71, 38);
            this.lblCost.TabIndex = 8;
            this.lblCost.Text = "Cost";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(35, 94);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(70, 38);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Title";
            // 
            // lblC_ID
            // 
            this.lblC_ID.AutoSize = true;
            this.lblC_ID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblC_ID.Location = new System.Drawing.Point(35, 29);
            this.lblC_ID.Name = "lblC_ID";
            this.lblC_ID.Size = new System.Drawing.Size(171, 38);
            this.lblC_ID.TabIndex = 14;
            this.lblC_ID.Text = "Customer ID";
            // 
            // addOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(811, 560);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addOrders";
            this.Text = "addOrders";
            this.Load += new System.EventHandler(this.addOrders_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnExit;
        private Button btnAdd;
        private Panel panel1;
        private TextBox txtStatus;
        private DateTimePicker date;
        private Label lblStatus;
        private Label lblPayment;
        private Label lblDate;
        private TextBox txtCost;
        private Label lblCost;
        private Label lblTitle;
        private Label lblC_ID;
        private ComboBox cmbC_ID;
        private ComboBox cmbPayment;
        private ComboBox cmbTitle;
    }
}