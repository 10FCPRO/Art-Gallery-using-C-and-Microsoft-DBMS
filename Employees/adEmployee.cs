using Project_Database.Employees;
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

namespace Project_Database
{
    public partial class Employee : Form
    {
        ConnectionString cs = new ConnectionString();
        public Employee()
        {
            InitializeComponent();
            GVEmployees.DataSource = getEmployeesList();
        }

        private DataTable getEmployeesList()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs.DBConnectionString);

                SqlCommand myCommand = default(SqlCommand);

                myCommand = new SqlCommand("Select * from Employee", myConnection);

                myCommand.Connection.Open();
                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                dt.Load(myReader);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }
        private void adEmployee_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            adHome form = new adHome();
            form.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GVEmployees.DataSource = getEmployeesList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addEmployees form = new addEmployees();
            form.Show();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {   
            modifyEmployees form = new modifyEmployees();
            form.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteEmployees form = new deleteEmployees();
            form.Show();
        }
    }
}
