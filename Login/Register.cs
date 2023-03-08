using Project_Database;
using System.Data;
using System.Data.SqlClient;
namespace customerlogin
{
    public partial class Register : Form
    {
        ConnectionString cs = new ConnectionString();
        public Register()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.Show();
        }

        private void combousertype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtcustemail.Text == "")
            {
                MessageBox.Show("Please enter Email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtcustpassword.Text == "")
            {
                MessageBox.Show("Please enter Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtAddress.Text == "")
            {
                MessageBox.Show("Please enter Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter Name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                SqlConnection myConnection = default(SqlConnection);
                myConnection = new SqlConnection(cs.DBConnectionString);

                SqlCommand myCommand = default(SqlCommand);
                myCommand = new SqlCommand("Insert Into Customer (G_ID,Name,Email,Password,Address) values(1,@Name,@Email,@Password,@Address)", myConnection);
                SqlParameter uName = new SqlParameter("@Name", SqlDbType.VarChar);
                SqlParameter uEmail = new SqlParameter("@Email", SqlDbType.VarChar);
                SqlParameter uPassword = new SqlParameter("@Password", SqlDbType.VarChar);
                SqlParameter uAddress = new SqlParameter("@Address", SqlDbType.VarChar);


                uName.Value = txtName.Text;
                uEmail.Value = txtcustemail.Text;
                uPassword.Value = txtcustpassword.Text;
                uAddress.Value = txtAddress.Text;

                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uEmail);
                myCommand.Parameters.Add(uPassword);
                myCommand.Parameters.Add(uAddress);

                myCommand.Connection.Open();
                ;
                if (myCommand.ExecuteNonQuery() > 0)
                {
                    this.Hide();
                    Login login = new Login();
                    login.Show();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void userpassword_Click(object sender, EventArgs e)
        {

        }
    }
}
