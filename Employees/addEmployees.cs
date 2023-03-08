using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Database.Employees
{
    public partial class addEmployees : Form
    {
        ConnectionString cs = new ConnectionString();
        public addEmployees()
        {
            InitializeComponent();
            LoadGallerys();
        }

        private void LoadGallerys()
        {
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs.DBConnectionString);

                SqlCommand myCommand = default(SqlCommand);

                myCommand = new SqlCommand("Select G_ID from Gallery", myConnection);

                myCommand.Connection.Open();
                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                DataTable dt = new DataTable();

                dt.Columns.Add("G_ID", typeof(int));
                dt.Load(myReader);

                cmbGalleryID.ValueMember = "G_ID";
                cmbGalleryID.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String msg = "Please Enter: ";
            if (txtName.Text == "")
            {
                msg += "Name ";
            }
            if (dateTime.Text == "")
            {
                msg += "Date Of Birth ";
            }
            if (txtAddress.Text == "")
            {
                msg += "Address ";
            }
            if (txtTitle.Text == "")
            {
                msg += "Title ";
            }
            if (txtSalary.Text == "")
            {
                msg += "Salary ";
            }
            if (!msg.Equals("Please Enter: "))
            {
                MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection myConnection = default(SqlConnection);
                    myConnection = new SqlConnection(cs.DBConnectionString);

                    SqlCommand myCommand = default(SqlCommand);

                    myCommand = new SqlCommand("Insert into Employee(G_ID,Name,DOB,Address,Title,Salary,Email,Password,Shift) values (@G_ID,@Name,@DOB,@Address,@Title,@Salary,@Email,@Password,@Shift)", myConnection);
                    SqlParameter uG_ID = new SqlParameter("@G_ID", SqlDbType.Int);
                    SqlParameter uName = new SqlParameter("@Name", SqlDbType.VarChar);
                    SqlParameter uDOB = new SqlParameter("@DOB", SqlDbType.Date);
                    SqlParameter uAddress = new SqlParameter("@Address", SqlDbType.VarChar);
                    SqlParameter uTitle = new SqlParameter("@Title", SqlDbType.VarChar);
                    SqlParameter uSalary = new SqlParameter("@Salary", SqlDbType.Float);
                    SqlParameter uEmail = new SqlParameter("@Email", SqlDbType.VarChar);
                    SqlParameter uPassword = new SqlParameter("@Password", SqlDbType.VarChar);
                    SqlParameter uShift = new SqlParameter("@Shift", SqlDbType.VarChar);

                    uG_ID.Value = cmbGalleryID.Text;
                    uName.Value = txtName.Text;
                    uDOB.Value = dateTime.Text;
                    uAddress.Value = txtAddress.Text;
                    uTitle.Value = txtTitle.Text;
                    uSalary.Value = txtSalary.Text;
                    uEmail.Value = txtEmail.Text;
                    uPassword.Value = txtPassword.Text;
                    uShift.Value = txtShift.Text;

                    myCommand.Parameters.Add(uG_ID);
                    myCommand.Parameters.Add(uName);
                    myCommand.Parameters.Add(uDOB);
                    myCommand.Parameters.Add(uAddress);
                    myCommand.Parameters.Add(uTitle);
                    myCommand.Parameters.Add(uSalary);
                    myCommand.Parameters.Add(uEmail);
                    myCommand.Parameters.Add(uPassword);
                    myCommand.Parameters.Add(uShift);

                    myCommand.Connection.Open();
                    if (myCommand.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbGalleryID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
