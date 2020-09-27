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

namespace Windowslogin
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            
        }

        private void CUSTOMER_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerInformation cus = new CustomerInformation();
            cus.Show();
            

        }

        private void PRODUCT_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductInfomation pro = new ProductInfomation();
            pro.Show();
        }

        private void ORDER_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm order = new OrderForm();
            order.Show();
        }

        private void STAFF_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Information staff = new Staff_Information();
            staff.Show();
        }

        private void SUPPLIER_Click(object sender, EventArgs e)
        {
            this.Hide();
            Supplier sup = new Supplier();
            sup.Show();
        }

        private void CATALOGUE_Click(object sender, EventArgs e)
        {
            this.Hide();
            Catalogue cal = new Catalogue();
            cal.Show();
        }

        private void RETURN_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }

   
    
}
