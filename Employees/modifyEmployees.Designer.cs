namespace Project_Database.Employees
{
    partial class modifyEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(modifyEmployees));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbEmployee = new System.Windows.Forms.ComboBox();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtShift = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblShift = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOptional = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.cmbGalleryID = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblGalleryID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Location = new System.Drawing.Point(590, 679);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 34);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnUpdate.Location = new System.Drawing.Point(397, 679);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(112, 34);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.cmbEmployee);
            this.panel1.Controls.Add(this.lblEmployee);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtShift);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblShift);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblOptional);
            this.panel1.Controls.Add(this.txtSalary);
            this.panel1.Controls.Add(this.dateTime);
            this.panel1.Controls.Add(this.cmbGalleryID);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblEmail);
            this.panel1.Controls.Add(this.lblSalary);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.lblDOB);
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblGalleryID);
            this.panel1.Location = new System.Drawing.Point(62, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 593);
            this.panel1.TabIndex = 13;
            // 
            // cmbEmployee
            // 
            this.cmbEmployee.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cmbEmployee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmployee.FormattingEnabled = true;
            this.cmbEmployee.Location = new System.Drawing.Point(270, 25);
            this.cmbEmployee.Name = "cmbEmployee";
            this.cmbEmployee.Size = new System.Drawing.Size(163, 33);
            this.cmbEmployee.TabIndex = 35;
            this.cmbEmployee.SelectedIndexChanged += new System.EventHandler(this.cmbEmployee_SelectedIndexChanged);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmployee.Location = new System.Drawing.Point(35, 17);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(173, 38);
            this.lblEmployee.TabIndex = 34;
            this.lblEmployee.Text = "Employee ID";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(270, 484);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(379, 31);
            this.txtPassword.TabIndex = 33;
            // 
            // txtShift
            // 
            this.txtShift.Location = new System.Drawing.Point(270, 535);
            this.txtShift.Name = "txtShift";
            this.txtShift.Size = new System.Drawing.Size(196, 31);
            this.txtShift.TabIndex = 32;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(270, 433);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(379, 31);
            this.txtEmail.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(124, 543);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "(Optional)";
            // 
            // lblShift
            // 
            this.lblShift.AutoSize = true;
            this.lblShift.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblShift.Location = new System.Drawing.Point(35, 527);
            this.lblShift.Name = "lblShift";
            this.lblShift.Size = new System.Drawing.Size(73, 38);
            this.lblShift.TabIndex = 28;
            this.lblShift.Text = "Shift";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(173, 492);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 19);
            this.label1.TabIndex = 27;
            this.label1.Text = "(Optional)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(35, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 38);
            this.label2.TabIndex = 26;
            this.label2.Text = "Password";
            // 
            // lblOptional
            // 
            this.lblOptional.AutoSize = true;
            this.lblOptional.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOptional.Location = new System.Drawing.Point(124, 441);
            this.lblOptional.Name = "lblOptional";
            this.lblOptional.Size = new System.Drawing.Size(70, 19);
            this.lblOptional.TabIndex = 25;
            this.lblOptional.Text = "(Optional)";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(270, 375);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(196, 31);
            this.txtSalary.TabIndex = 24;
            // 
            // dateTime
            // 
            this.dateTime.Location = new System.Drawing.Point(270, 193);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(196, 31);
            this.dateTime.TabIndex = 23;
            // 
            // cmbGalleryID
            // 
            this.cmbGalleryID.FormattingEnabled = true;
            this.cmbGalleryID.Location = new System.Drawing.Point(270, 78);
            this.cmbGalleryID.Name = "cmbGalleryID";
            this.cmbGalleryID.Size = new System.Drawing.Size(163, 33);
            this.cmbGalleryID.TabIndex = 22;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(270, 135);
            this.txtName.MaximumSize = new System.Drawing.Size(0, 35);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(379, 31);
            this.txtName.TabIndex = 19;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(35, 425);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(83, 38);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalary.Location = new System.Drawing.Point(35, 367);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(91, 38);
            this.lblSalary.TabIndex = 4;
            this.lblSalary.Text = "Salary";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(270, 316);
            this.txtTitle.MaximumSize = new System.Drawing.Size(0, 35);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(379, 31);
            this.txtTitle.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(35, 309);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(70, 38);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Title";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(270, 258);
            this.txtAddress.MaximumSize = new System.Drawing.Size(0, 35);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(196, 31);
            this.txtAddress.TabIndex = 9;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.Location = new System.Drawing.Point(35, 251);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(116, 38);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDOB.Location = new System.Drawing.Point(35, 193);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(179, 38);
            this.lblDOB.TabIndex = 10;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(35, 128);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(91, 38);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "Name";
            // 
            // lblGalleryID
            // 
            this.lblGalleryID.AutoSize = true;
            this.lblGalleryID.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGalleryID.Location = new System.Drawing.Point(35, 70);
            this.lblGalleryID.Name = "lblGalleryID";
            this.lblGalleryID.Size = new System.Drawing.Size(138, 38);
            this.lblGalleryID.TabIndex = 0;
            this.lblGalleryID.Text = "Gallery ID";
            // 
            // modifyEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1120, 740);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "modifyEmployees";
            this.Text = "modifyEmployees";
            this.Load += new System.EventHandler(this.modifyEmployees_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnExit;
        private Button btnUpdate;
        private Panel panel1;
        private TextBox txtPassword;
        private TextBox txtShift;
        private TextBox txtEmail;
        private Label label3;
        private Label lblShift;
        private Label label1;
        private Label label2;
        private Label lblOptional;
        private TextBox txtSalary;
        private DateTimePicker dateTime;
        private ComboBox cmbGalleryID;
        private TextBox txtName;
        private Label lblEmail;
        private Label lblSalary;
        private TextBox txtTitle;
        private Label lblTitle;
        private TextBox txtAddress;
        private Label lblAddress;
        private Label lblDOB;
        private Label lblName;
        private Label lblGalleryID;
        private ComboBox cmbEmployee;
        private Label lblEmployee;
    }
}