using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using customerlogin;
using Project_Database.Customers;
namespace Project_Database
{
    public partial class adHome : Form
    {
        public adHome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            adArtwork adartworks = new adArtwork();
            adartworks.Show();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            this.Hide();
            adOrders adorders = new adOrders();
            adorders.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            adCustomers adcustomers = new adCustomers();
            adcustomers.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void btnArtists_Click(object sender, EventArgs e)
        {
            this.Hide();
            Artist form = new Artist();
            form.Show();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Employee form = new Employee();
            form.Show();
        }
    }
}
