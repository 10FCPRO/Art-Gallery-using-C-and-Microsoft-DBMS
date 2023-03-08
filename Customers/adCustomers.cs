using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Project_Database.Customers;

namespace Project_Database
{
    public partial class adCustomers : Form
    {
        ConnectionString cs = new ConnectionString();
        public adCustomers()
        {
            InitializeComponent();
            GVCustomers.DataSource = getCustomerList();
        }
        private DataTable getCustomerList()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs.DBConnectionString);

                SqlCommand myCommand = default(SqlCommand);

                myCommand = new SqlCommand("Select * from Customer", myConnection);

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
        private void btnModify_Click(object sender, EventArgs e)
        {
            modifyCustomers form = new modifyCustomers();
            form.Show();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteCustomer form = new deleteCustomer();
            form.Show();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            adHome home = new adHome();
            home.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GVCustomers.DataSource = getCustomerList();
        }
    }
}
