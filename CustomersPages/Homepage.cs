using customerlogin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Database.CustomersPages
{
    public partial class Homepage : Form
    {
        int C_ID;
        public Homepage(int c_ID)
        {
            InitializeComponent();
            C_ID = c_ID;
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            this.Hide();
            Shop form = new Shop(C_ID);
            form.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            Orders form = new Orders(C_ID);
            form.Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login form = new Login();
            form.Show();
        }

        private void Homepage_Load(object sender, EventArgs e)
        {

        }
    }
}
