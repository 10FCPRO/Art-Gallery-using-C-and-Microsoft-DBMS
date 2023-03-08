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
using Project_Database.Orders;

namespace Project_Database
{
    public partial class adOrders : Form
    {
        ConnectionString cs = new ConnectionString();
        public adOrders()
        {
            InitializeComponent();
            GVOrders.DataSource = getOrderList();
        }

        private DataTable getOrderList()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs.DBConnectionString);

                SqlCommand myCommand = default(SqlCommand);

                myCommand = new SqlCommand("Select * from Orderr", myConnection);

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
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            adHome form = new adHome();
            form.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GVOrders.DataSource = getOrderList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addOrders form = new addOrders();
            form.Show();
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteOrders form = new deleteOrders();
            form.Show();
        }
    }
}
