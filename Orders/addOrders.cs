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

namespace Project_Database.Orders
{
    public partial class addOrders : Form
    {
        ConnectionString cs = new ConnectionString();
        DateTime now = DateTime.Now;
        public addOrders()
        {
            InitializeComponent();
            LoadCustomers();
            LoadTitles();
        }
        private void LoadTitles()
        {
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs.DBConnectionString);

                SqlCommand myCommand = default(SqlCommand);

                myCommand = new SqlCommand("Select Title from Artwork", myConnection);

                myCommand.Connection.Open();
                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                DataTable dt = new DataTable();

                dt.Columns.Add("Title", typeof(string));
                dt.Load(myReader);

                cmbTitle.ValueMember = "Title";
                cmbTitle.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadCustomers()
        {
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs.DBConnectionString);

                SqlCommand myCommand = default(SqlCommand);

                myCommand = new SqlCommand("Select C_ID from Customer", myConnection);

                myCommand.Connection.Open();
                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);

                DataTable dt = new DataTable();

                dt.Columns.Add("C_ID", typeof(int));
                dt.Load(myReader);

                cmbC_ID.ValueMember = "C_ID";
                cmbC_ID.DataSource = dt;
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
            if (cmbC_ID.Text == "")
            {
                msg += "Customer ID ";
            }
            if (cmbTitle.Text == "")
            {
                msg += "Title ";
            }
            if (txtCost.Text == "")
            {
                msg += "Cost ";
            }
            if (cmbPayment.Text == "")
            {
                msg += "Payment Method ";
            }
            if (txtStatus.Text == "")
            {
                msg += "Status ";
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

                    myCommand = new SqlCommand("Insert into Orderr(C_ID,Title,Cost,Date,Payment_Method,Status) values (@C_ID,@Title,@Cost,@Date,@Payment_Method,@Status)", myConnection);
                    SqlParameter uC_ID = new SqlParameter("@C_ID", SqlDbType.Int);
                    SqlParameter uTitle = new SqlParameter("@Title", SqlDbType.VarChar);
                    SqlParameter uCost = new SqlParameter("@Cost", SqlDbType.Float);
                    SqlParameter uDate = new SqlParameter("@Date", SqlDbType.DateTime);
                    SqlParameter uPayment_Method = new SqlParameter("@Payment_Method", SqlDbType.VarChar);
                    SqlParameter uStatus = new SqlParameter("@Status", SqlDbType.VarChar);

                    uC_ID.Value = cmbC_ID.Text;
                    uTitle.Value = cmbTitle.Text;
                    uCost.Value = txtCost.Text;
                    uDate.Value = now;
                    uPayment_Method.Value = cmbPayment.Text;
                    uStatus.Value = txtStatus.Text;

                    myCommand.Parameters.Add(uC_ID);
                    myCommand.Parameters.Add(uTitle);
                    myCommand.Parameters.Add(uCost);
                    myCommand.Parameters.Add(uDate);
                    myCommand.Parameters.Add(uPayment_Method);
                    myCommand.Parameters.Add(uStatus);


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

        private void addOrders_Load(object sender, EventArgs e)
        {
            date.Text = now.ToString();
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbC_ID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
