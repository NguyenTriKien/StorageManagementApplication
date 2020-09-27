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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }

        private void login_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=2ndmainlaptop;Initial Catalog=electroshop;Integrated Security=True");
            string query = "select * from LOGIN_USER where Username='" + txtUsername.Text.Trim() + "' and UserPassword='" + txtPassword.Text.Trim() + "' ";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtb1 = new DataTable();
            try
            {
                sda.Fill(dtb1);
                if (dtb1.Rows.Count == 1)
                {
                    this.Hide();
                    Menu formshow = new Menu();
                    formshow.Show();
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại việc tên tài khoản và mật khẩu");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Kiểm tra lại việc tên tài khoản và mật khẩu");
            }
        }
        

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
