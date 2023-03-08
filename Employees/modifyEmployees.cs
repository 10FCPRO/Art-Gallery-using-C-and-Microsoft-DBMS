using System.Data;
using System.Data.SqlClient;
namespace Project_Database.Employees
{
    public partial class modifyEmployees : Form
    {
        ConnectionString cs = new ConnectionString();
        public modifyEmployees()
        {
            InitializeComponent();
            LoadEmployees();
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
        private void LoadEmployees()
        {
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs.DBConnectionString);

                SqlCommand myCommand = default(SqlCommand);

                myCommand = new SqlCommand("Select E_ID from Employee", myConnection);

                myCommand.Connection.Open();
                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                DataTable dt = new DataTable();

                dt.Columns.Add("E_ID", typeof(int));
                dt.Load(myReader);

                cmbEmployee.ValueMember = "E_ID";
                cmbEmployee.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void modifyEmployees_Load(object sender, EventArgs e)
        {

        }

        private void cmbEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs.DBConnectionString);

                SqlCommand myCommand = default(SqlCommand);
                myCommand = new SqlCommand("Select * from Employee where E_ID = @E_ID", myConnection);
                SqlParameter uE_ID = new SqlParameter("@E_ID", SqlDbType.Int);
                uE_ID.Value = cmbEmployee.Text;
                myCommand.Parameters.Add(uE_ID);
                myCommand.Connection.Open();
                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader.Read() == true)
                {
                    txtName.Text = myReader.GetValue("Name").ToString();
                    cmbGalleryID.Text = myReader.GetValue("G_ID").ToString();
                    txtAddress.Text = myReader.GetValue("Address").ToString();
                    txtEmail.Text = myReader.GetValue("Email").ToString();
                    txtPassword.Text = myReader.GetValue("Password").ToString();
                    txtSalary.Text = myReader.GetValue("Salary").ToString();
                    txtShift.Text = myReader.GetValue("Shift").ToString();
                    txtTitle.Text = myReader.GetValue("Title").ToString();
                    dateTime.Text = myReader.GetValue("DOB").ToString();
                }
                myConnection.Close();
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

        private void btnUpdate_Click(object sender, EventArgs e)
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

                    myCommand = new SqlCommand("Update Employee SET G_ID = @G_ID, Name = @Name, DOB = @DOB, Address = @Address, Title = @Title, Salary = @Salary, Email = @Email, Password = @Password, Shift = @Shift where E_ID = @E_ID", myConnection);
                    SqlParameter uG_ID = new SqlParameter("@G_ID", SqlDbType.Int);
                    SqlParameter uName = new SqlParameter("@Name", SqlDbType.VarChar);
                    SqlParameter uDOB = new SqlParameter("@DOB", SqlDbType.Date);
                    SqlParameter uAddress = new SqlParameter("@Address", SqlDbType.VarChar);
                    SqlParameter uTitle = new SqlParameter("@Title", SqlDbType.VarChar);
                    SqlParameter uSalary = new SqlParameter("@Salary", SqlDbType.Float);
                    SqlParameter uEmail = new SqlParameter("@Email", SqlDbType.VarChar);
                    SqlParameter uPassword = new SqlParameter("@Password", SqlDbType.VarChar);
                    SqlParameter uShift = new SqlParameter("@Shift", SqlDbType.VarChar);
                    SqlParameter uE_ID = new SqlParameter("@E_ID", SqlDbType.Int);

                    uG_ID.Value = cmbGalleryID.Text;
                    uName.Value = txtName.Text;
                    uDOB.Value = dateTime.Text;
                    uAddress.Value = txtAddress.Text;
                    uTitle.Value = txtTitle.Text;
                    uSalary.Value = txtSalary.Text;
                    uEmail.Value = txtEmail.Text;
                    uPassword.Value = txtPassword.Text;
                    uShift.Value = txtShift.Text;
                    uE_ID.Value = cmbEmployee.Text;

                    myCommand.Parameters.Add(uG_ID);
                    myCommand.Parameters.Add(uName);
                    myCommand.Parameters.Add(uDOB);
                    myCommand.Parameters.Add(uAddress);
                    myCommand.Parameters.Add(uTitle);
                    myCommand.Parameters.Add(uSalary);
                    myCommand.Parameters.Add(uEmail);
                    myCommand.Parameters.Add(uPassword);
                    myCommand.Parameters.Add(uShift);
                    myCommand.Parameters.Add(uE_ID);

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

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
