using Project_Database;
using Project_Database.CustomersPages;
using System.Data;
using System.Data.SqlClient;
namespace customerlogin
{
    public partial class Login : Form
    {
        ConnectionString cs = new ConnectionString();
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void combousertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (combousertype.Text == "")
            {
                MessageBox.Show("Please enter user type","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtcustemail.Text == "")
            {
                MessageBox.Show("Please enter Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtcustpassword.Text == "")
            {
                MessageBox.Show("Please enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs.DBConnectionString);

                SqlCommand myCommand = default(SqlCommand);

                if(combousertype.Text == "Customer")
                {
                    myCommand = new SqlCommand("Select * from Customer where Email = @Email AND Password = @pass", myConnection);
                    SqlParameter cName = new SqlParameter("@Email", SqlDbType.VarChar);
                    SqlParameter cPassword = new SqlParameter("@Pass", SqlDbType.VarChar);

                    myCommand.Parameters.Add(cName);
                    myCommand.Parameters.Add(cPassword);

                    cName.Value = txtcustemail.Text;
                    cPassword.Value = txtcustpassword.Text;

                    myCommand.Connection.Open();
                    SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    if (myReader.Read() == true)
                    {
                        this.Hide();

                        int C_ID = int.Parse(myReader.GetValue("C_ID").ToString());
                        Homepage home = new Homepage(C_ID);

                        home.Show();
                    }
                    else
                    {
                        MessageBox.Show("Customer not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if(combousertype.Text == "Admin")
                {
                    myCommand = new SqlCommand("Select * from Employee inner join Gallery on E_ID = M_ID where Email = @Email AND Password = @pass", myConnection);
                    SqlParameter uName = new SqlParameter("@Email", SqlDbType.VarChar);
                    SqlParameter uPassword = new SqlParameter("@Pass", SqlDbType.VarChar);

                    myCommand.Parameters.Add(uName);
                    myCommand.Parameters.Add(uPassword);

                    uName.Value = txtcustemail.Text;
                    uPassword.Value = txtcustpassword.Text;

                    myCommand.Connection.Open();
                    SqlDataReader myReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection);
                    if (myReader.Read() == true)
                    {
                        this.Hide();


                        adHome home = new adHome();


                        home.Show();
                    }
                    else
                    {
                        MessageBox.Show("Admin not found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register regForm = new Register();
            regForm.Show();
        }
        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtcustpassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}