using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Project_Database.CustomersPages
{
    public partial class Shop : Form
    {
        ConnectionString cs = new ConnectionString();
        private int C_ID;
        int Artist_ID = 0;
        public Shop(int c_ID)
        {
            InitializeComponent();
            C_ID = c_ID;
            LoadArtworks();
        }
        private void LoadArtworks()
        {
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs.DBConnectionString);

                SqlCommand myCommand = default(SqlCommand);

                myCommand = new SqlCommand("Select Title from Artwork", myConnection);
                /*SqlParameter uC_ID = new SqlParameter("@C_ID", SqlDbType.Int);
                uC_ID.Value = C_ID;
                myCommand.Parameters.Add(uC_ID);*/
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
        private void cmbTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs.DBConnectionString);

                SqlCommand myCommand2 = default(SqlCommand);
                myCommand2 = new SqlCommand("Select Artist_ID from Artwork where Title = @Title", myConnection);
                SqlParameter uTitle2 = new SqlParameter("@Title", SqlDbType.VarChar);
                uTitle2.Value = cmbTitle.Text;
                myCommand2.Parameters.Add(uTitle2);
                myCommand2.Connection.Open();
                SqlDataReader myReader2 = myCommand2.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader2.Read() == true)
                {
                    Artist_ID = int.Parse(myReader2.GetValue("Artist_ID").ToString());
                    lblArtistD.Text = Artist_ID.ToString();
                }
                myConnection.Close();

                SqlCommand myCommand = default(SqlCommand);
                myCommand = new SqlCommand("Select Name from Artist where Artist_ID = @Artist_ID", myConnection);
                SqlParameter uArtistID = new SqlParameter("@Artist_ID", SqlDbType.Int);
                uArtistID.Value = Artist_ID;
                myCommand.Parameters.Add(uArtistID);
                myCommand.Connection.Open();
                SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader.Read() == true)
                {
                    lblArtistD.Text = myReader.GetValue("Name").ToString();
                }
                myConnection.Close();

                SqlCommand myCommand1 = default(SqlCommand);
                myCommand1 = new SqlCommand("Select Nationality from Artist where Artist_ID = @Artist_ID", myConnection);
                SqlParameter uArtistID1 = new SqlParameter("@Artist_ID", SqlDbType.Int);
                uArtistID1.Value = Artist_ID;
                myCommand1.Parameters.Add(uArtistID1);
                myCommand1.Connection.Open();
                SqlDataReader myReader1 = myCommand1.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader1.Read() == true)
                {
                    lblNationalityD.Text = myReader1.GetValue("Nationality").ToString();
                }
                myConnection.Close();

                SqlCommand myCommand7 = default(SqlCommand);
                myCommand7 = new SqlCommand("Select Art_Style from Artist where Artist_ID = @Artist_ID", myConnection);
                SqlParameter uArtistID2 = new SqlParameter("@Artist_ID", SqlDbType.Int);
                uArtistID2.Value = Artist_ID;
                myCommand7.Parameters.Add(uArtistID2);
                myCommand7.Connection.Open();
                SqlDataReader myReader7 = myCommand7.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader7.Read() == true)
                {
                    lblArtStyleD.Text = myReader7.GetValue("Art_Style").ToString();
                }
                myConnection.Close();

                SqlCommand myCommand3 = default(SqlCommand);
                myCommand3 = new SqlCommand("Select Price from Artwork where Title = @Title", myConnection);
                SqlParameter uTitle3 = new SqlParameter("@Title", SqlDbType.VarChar);
                uTitle3.Value = cmbTitle.Text;
                myCommand3.Parameters.Add(uTitle3);
                myCommand3.Connection.Open();
                SqlDataReader myReader3 = myCommand3.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader3.Read() == true)
                {
                    lblPriceD.Text = myReader3.GetValue("Price").ToString();
                }
                myConnection.Close();

                SqlCommand myCommand4 = default(SqlCommand);
                myCommand4 = new SqlCommand("Select Year from Artwork where Title = @Title", myConnection);
                SqlParameter uTitle4 = new SqlParameter("@Title", SqlDbType.VarChar);
                uTitle4.Value = cmbTitle.Text;
                myCommand4.Parameters.Add(uTitle4);
                myCommand4.Connection.Open();
                SqlDataReader myReader4 = myCommand4.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader4.Read() == true)
                {
                    lblYearD.Text = myReader4.GetValue("Year").ToString();
                }
                myConnection.Close();

                SqlCommand myCommand5 = default(SqlCommand);
                SqlParameter uTitle5 = new SqlParameter("@Title", SqlDbType.VarChar);
                uTitle5.Value = cmbTitle.Text;
                myCommand5 = new SqlCommand("Select Art_Type from Artwork where Title = @Title", myConnection);
                myCommand5.Parameters.Add(uTitle5);
                myCommand5.Connection.Open();
                SqlDataReader myReader5 = myCommand5.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader5.Read() == true)
                {
                    lblArtTypeD.Text = myReader5.GetValue("Art_Type").ToString();
                }
                myConnection.Close();

                SqlCommand myCommand6 = default(SqlCommand);
                SqlParameter uTitle6 = new SqlParameter("@Title", SqlDbType.VarChar);
                uTitle6.Value = cmbTitle.Text;
                myCommand6 = new SqlCommand("Select Image from Artwork where Title = @Title", myConnection);
                myCommand6.Parameters.Add(uTitle6);
                myCommand6.Connection.Open();
                SqlDataReader myReader6 = myCommand6.ExecuteReader(CommandBehavior.CloseConnection);
                if (myReader6.Read() == true)
                {
                    byte[] img = (byte[])(myReader6.GetValue("Image"));
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Homepage form = new Homepage(C_ID);
            form.Show();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            Debug.WriteLine(today.ToString());
            if (cmbPayment.Text == "")
            {
                MessageBox.Show("Pleas choose payment method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection myConnection = default(SqlConnection);
                    myConnection = new SqlConnection(cs.DBConnectionString);

                    SqlCommand myCommand = default(SqlCommand);

                    myCommand = new SqlCommand("Insert into Orderr (C_ID,Title,Cost,Date,Payment_Method,Status) values (@C_ID,@Title,@Cost,@Date,@Payment_Method,'Not Delivered')", myConnection);
                    SqlParameter uC_ID = new SqlParameter("@C_ID", SqlDbType.Int);
                    SqlParameter uTitle = new SqlParameter("@Title", SqlDbType.VarChar);
                    SqlParameter uCost = new SqlParameter("@Cost", SqlDbType.Float);
                    SqlParameter uDate = new SqlParameter("@Date", SqlDbType.DateTime);
                    SqlParameter uPayment_Method = new SqlParameter("@Payment_Method", SqlDbType.VarChar);

                    uC_ID.Value = C_ID;
                    uCost.Value = lblPriceD.Text;
                    uDate.Value = today;
                    uPayment_Method.Value = cmbPayment.Text;
                    uTitle.Value = cmbTitle.Text;

                    myCommand.Parameters.Add(uC_ID);
                    myCommand.Parameters.Add(uTitle);
                    myCommand.Parameters.Add(uCost);
                    myCommand.Parameters.Add(uDate);
                    myCommand.Parameters.Add(uPayment_Method);

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblArtworks_Click(object sender, EventArgs e)
        {

        }

        private void cmbPayment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Shop_Load(object sender, EventArgs e)
        {

        }
    }
}
