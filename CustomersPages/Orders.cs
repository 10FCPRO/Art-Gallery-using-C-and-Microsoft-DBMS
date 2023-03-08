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
using System.Diagnostics;

namespace Project_Database.CustomersPages
{
    public partial class Orders : Form
    {
        ConnectionString cs = new ConnectionString();
        int C_ID;
        public Orders(int c_ID)
        {
            InitializeComponent();
            C_ID = c_ID;
            LoadOrders();
        }

        private void LoadOrders()
        {
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs.DBConnectionString);

                SqlCommand myCommand = default(SqlCommand);

                myCommand = new SqlCommand("Select O_ID from Orderr where C_ID = @C_ID", myConnection);

                SqlParameter uC_ID = new SqlParameter("@C_ID", SqlDbType.Int);
                uC_ID.Value = C_ID;
                myCommand.Parameters.Add(uC_ID);
                myCommand.Connection.Open();
                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
                DataTable dt = new DataTable();

                dt.Columns.Add("O_ID", typeof(string));
                dt.Load(myReader);

                cmbOrderID.ValueMember = "O_ID";
                cmbOrderID.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Orders_Load(object sender, EventArgs e)
        {

        }

        private void lblArtworks_Click(object sender, EventArgs e)
        {

        }

        private void cmbOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs.DBConnectionString);
                //title cost date
                SqlCommand myCommand0 = default(SqlCommand);
                myCommand0 = new SqlCommand("Select Title from Orderr where O_ID = @O_ID", myConnection);
                SqlParameter uO_ID = new SqlParameter("@O_ID", SqlDbType.Int);
                uO_ID.Value = cmbOrderID.Text;
                myCommand0.Parameters.Add(uO_ID);
                myCommand0.Connection.Open();
                SqlDataReader myReader0 = myCommand0.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader0.Read() == true)
                {
                    lblTitleD.Text = myReader0.GetValue("Title").ToString();
                }
                myConnection.Close();

                SqlCommand myCommand = default(SqlCommand);
                myCommand = new SqlCommand("Select Art_Type from Artwork where Title = @Title", myConnection);
                SqlParameter uTitle = new SqlParameter("@Title", SqlDbType.VarChar);
                uTitle.Value = lblTitleD.Text;
                myCommand.Parameters.Add(uTitle);
                myCommand.Connection.Open();
                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader.Read() == true)
                {
                    lblArtTypeD.Text = myReader.GetValue("Art_Type").ToString();
                }
                myConnection.Close();

                SqlCommand myCommand2 = default(SqlCommand);
                myCommand2 = new SqlCommand("Select Cost from Orderr where O_ID = @O_ID", myConnection);
                SqlParameter uO_ID4 = new SqlParameter("@O_ID", SqlDbType.Int);
                uO_ID4.Value = cmbOrderID.Text;
                myCommand2.Parameters.Add(uO_ID4);
                myCommand2.Connection.Open();
                SqlDataReader myReader2 = myCommand2.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader2.Read() == true)
                {
                    lblPriceD.Text = myReader2.GetValue("Cost").ToString();
                }
                myConnection.Close();

                SqlCommand myCommand3 = default(SqlCommand);
                myCommand3 = new SqlCommand("Select Year from Artwork where Title = @Title", myConnection);
                SqlParameter uTitle3 = new SqlParameter("@Title", SqlDbType.VarChar);
                uTitle3.Value = lblTitleD.Text;
                myCommand3.Parameters.Add(uTitle3);
                myCommand3.Connection.Open();
                SqlDataReader myReader3 = myCommand3.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader3.Read() == true)
                {
                    lblYearD.Text = myReader3.GetValue("Year").ToString();
                }
                myConnection.Close();

                SqlCommand myCommand4 = default(SqlCommand);
                myCommand4 = new SqlCommand("select Name from Artist where Artist_ID = (select Artist_ID from Artwork where Title = @Title)", myConnection);
                SqlParameter uTitle4 = new SqlParameter("@Title", SqlDbType.VarChar);
                uTitle4.Value = lblTitleD.Text;
                myCommand4.Parameters.Add(uTitle4);
                myCommand4.Connection.Open();
                SqlDataReader myReader4 = myCommand4.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader4.Read() == true)
                {
                    lblArtistD.Text = myReader4.GetValue("Name").ToString();
                }
                myConnection.Close();

                SqlCommand myCommand5 = default(SqlCommand);
                myCommand5 = new SqlCommand("Select Payment_Method from Orderr where O_ID = @O_ID", myConnection);
                SqlParameter uO_ID1 = new SqlParameter("@O_ID", SqlDbType.Int);
                uO_ID1.Value = cmbOrderID.Text;
                myCommand5.Parameters.Add(uO_ID1);
                myCommand5.Connection.Open();
                SqlDataReader myReader5 = myCommand5.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader5.Read() == true)
                {
                    lblPaymentD.Text = myReader5.GetValue("Payment_Method").ToString();
                }
                myConnection.Close();

                SqlCommand myCommand6 = default(SqlCommand);
                myCommand6 = new SqlCommand("Select Date from Orderr where O_ID = @O_ID", myConnection);
                SqlParameter uO_ID2 = new SqlParameter("@O_ID", SqlDbType.Int);
                uO_ID2.Value = cmbOrderID.Text;
                myCommand6.Parameters.Add(uO_ID2);
                myCommand6.Connection.Open();
                SqlDataReader myReader6 = myCommand6.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader6.Read() == true)
                {
                    lblOrderD.Text = myReader6.GetValue("Date").ToString();
                }
                myConnection.Close();

                SqlCommand myCommand7 = default(SqlCommand);
                SqlParameter uTitle7 = new SqlParameter("@Title", SqlDbType.VarChar);
                uTitle7.Value = lblTitleD.Text;
                myCommand7 = new SqlCommand("Select Image from Artwork where Title = @Title", myConnection);
                myCommand7.Parameters.Add(uTitle7);
                myCommand7.Connection.Open();
                SqlDataReader myReader7 = myCommand7.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader7.Read() == true)
                {
                    byte[] img = (byte[])(myReader7.GetValue("Image"));
                    if (img == null)
                    {
                        pictureBox1.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(img);
                        pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                myConnection.Close();

                SqlCommand myCommand8 = default(SqlCommand);
                myCommand8 = new SqlCommand("Select Status from Orderr where O_ID = @O_ID", myConnection);
                SqlParameter uO_ID3 = new SqlParameter("@O_ID", SqlDbType.Int);
                uO_ID3.Value = cmbOrderID.Text;
                myCommand8.Parameters.Add(uO_ID3);
                myCommand8.Connection.Open();
                SqlDataReader myReader8 = myCommand8.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader8.Read() == true)
                {
                    lblOrderStatusD.Text = myReader8.GetValue("Status").ToString();
                }
                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs.DBConnectionString);

                SqlCommand myCommand = default(SqlCommand);
                myCommand = new SqlCommand("Select Status from Orderr where O_ID = @O_ID", myConnection);
                SqlParameter uO_ID = new SqlParameter("@O_ID", SqlDbType.Int);
                uO_ID.Value = cmbOrderID.Text;
                myCommand.Parameters.Add(uO_ID);
                myCommand.Connection.Open();
                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader.Read() == true)
                {
                    if (myReader.GetValue("Status").ToString() == "Delivered")
                    {
                        MessageBox.Show("Sorry, order delivered already", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        myConnection.Close();
                        myCommand = new SqlCommand("Delete from Orderr where O_ID = @O_ID", myConnection);
                        SqlParameter uO_ID1 = new SqlParameter("@O_ID", SqlDbType.Int);
                        uO_ID1.Value = cmbOrderID.Text;
                        myCommand.Parameters.Add(uO_ID1);
                        myCommand.Connection.Open();
                        if (myCommand.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Order Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadOrders();
                        }
                        myConnection.Close();
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage form = new Homepage(C_ID);
            form.Show();
        }
    }
}
