using System.Data;
using System.Data.SqlClient;

namespace Project_Database.Employees
{
    public partial class deleteEmployees : Form
    {
        ConnectionString cs = new ConnectionString();
        public deleteEmployees()
        {
            InitializeComponent();
            loadEmployees();
        }

        private void loadEmployees()
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

                dt.Columns.Add("E_ID", typeof(string));
                dt.Load(myReader);

                cmbEmployee.ValueMember = "E_ID";
                cmbEmployee.DataSource = dt;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs.DBConnectionString);

                SqlCommand myCommand = default(SqlCommand);

                myCommand = new SqlCommand("Delete from Employee where E_ID = @E_ID", myConnection);

                SqlParameter uE_ID = new SqlParameter("@E_ID", SqlDbType.Int);

                uE_ID.Value = cmbEmployee.Text;

                myCommand.Parameters.Add(uE_ID);

                myCommand.Connection.Open();
                if (myCommand.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Artwork Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadEmployees();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                    txtG_ID.Text = myReader.GetValue("G_ID").ToString();
                    txtName.Text = myReader.GetValue("Name").ToString();
                    dateTime.Text = myReader.GetValue("DOB").ToString();
                    txtAddress.Text = myReader.GetValue("Address").ToString();
                    txtTitle.Text = myReader.GetValue("Title").ToString();
                    txtSalary.Text = myReader.GetValue("Salary").ToString();
                    txtEmail.Text = myReader.GetValue("Email").ToString();
                    txtPassword.Text = myReader.GetValue("Password").ToString();
                    txtShift.Text = myReader.GetValue("Shift").ToString();
                }
                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
