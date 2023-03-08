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

namespace Project_Database.Customers
{
    public partial class modifyCustomers : Form
    {
        ConnectionString cs = new ConnectionString();
        public modifyCustomers()
        {
            InitializeComponent();
            LoadC_ID();
        }

        private void LoadC_ID()
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

                cmbCustomerID.ValueMember = "C_ID";
                cmbCustomerID.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ModifyCustomers_Load(object sender, EventArgs e)
        {

        }

        private void cmbCustomerID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs.DBConnectionString);

                SqlCommand myCommand = default(SqlCommand);
                myCommand = new SqlCommand("Select distinct G_ID from Customer where C_ID = @C_ID", myConnection);
                SqlParameter uC_ID = new SqlParameter("@C_ID", SqlDbType.Int);
                uC_ID.Value = cmbCustomerID.Text;
                myCommand.Parameters.Add(uC_ID);
                myCommand.Connection.Open();
                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader.Read() == true)
                {
                    txtGalleryID.Text = myReader.GetValue("G_ID").ToString();
                }
                myConnection.Close();

                SqlCommand myCommand1 = default(SqlCommand);
                myCommand1 = new SqlCommand("Select Name from Customer where C_ID = @C_ID", myConnection);
                SqlParameter uC_ID1 = new SqlParameter("@C_ID", SqlDbType.Int);
                uC_ID1.Value = cmbCustomerID.Text;
                myCommand1.Parameters.Add(uC_ID1);
                myCommand1.Connection.Open();
                SqlDataReader myReader1 = myCommand1.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader1.Read() == true)
                {
                    txtName.Text = myReader1.GetValue("Name").ToString();
                }
                myConnection.Close();

                SqlCommand myCommand2 = default(SqlCommand);
                myCommand2 = new SqlCommand("Select Email from Customer where C_ID = @C_ID", myConnection);
                SqlParameter uC_ID2 = new SqlParameter("@C_ID", SqlDbType.VarChar);
                uC_ID2.Value = cmbCustomerID.Text;
                myCommand2.Parameters.Add(uC_ID2);
                myCommand2.Connection.Open();
                SqlDataReader myReader2 = myCommand2.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader2.Read() == true)
                {
                    txtEmail.Text = myReader2.GetValue("Email").ToString();
                }
                myConnection.Close();


                SqlCommand myCommand5 = default(SqlCommand);
                SqlParameter uC_ID5 = new SqlParameter("@C_ID", SqlDbType.VarChar);
                uC_ID5.Value = cmbCustomerID.Text;
                myCommand5 = new SqlCommand("Select Address from Customer where C_ID = @C_ID", myConnection);
                myCommand5.Parameters.Add(uC_ID5);
                myCommand5.Connection.Open();
                SqlDataReader myReader5 = myCommand5.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader5.Read() == true)
                {
                    txtAddress.Text = myReader5.GetValue("Address").ToString();
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
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs.DBConnectionString);

                SqlCommand myCommand = default(SqlCommand);

                /*myCommand = new SqlCommand("Update Artwork SET Title = @Title, G_ID = @G_ID, O_ID = @O_ID, Artist_ID = @Artist_ID, Price = @Price, Art_Type = @Art_Type, Year = @Year", myConnection);*/
                myCommand = new SqlCommand("Update Customer SET G_ID = @G_ID, Name = @Name, Email = @Email, Address = @Address Where C_ID = @C_ID", myConnection);
                SqlParameter uC_ID = new SqlParameter("@C_ID", SqlDbType.Int);
                SqlParameter uG_ID = new SqlParameter("@G_ID", SqlDbType.Int);
                SqlParameter uName = new SqlParameter("@Name", SqlDbType.VarChar);
                SqlParameter uEmail = new SqlParameter("@Email", SqlDbType.VarChar);
                SqlParameter uAddress = new SqlParameter("@Address", SqlDbType.VarChar);

                uC_ID.Value = cmbCustomerID.Text;
                uG_ID.Value = txtGalleryID.Text;
                uName.Value = txtName.Text;
                uEmail.Value = txtEmail.Text;
                uAddress.Value = txtAddress.Text;

                myCommand.Parameters.Add(uC_ID);
                myCommand.Parameters.Add(uG_ID);
                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uEmail);
                myCommand.Parameters.Add(uAddress);

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

        private void cmbGalleryID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void modifyCustomers_Load_1(object sender, EventArgs e)
        {

        }
    }
}
