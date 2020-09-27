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
    public partial class CustomerInformation : Form
    {
        
        public CustomerInformation()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source = 2NDMAINLAPTOP; Initial Catalog = electroshop; Integrated Security = True;");
        private void ketnoicsdl()
        {
            con.Open();
            string sql = "select * from CUSTOMER";  // lay het du lieu trong bang customer
            SqlCommand com = new SqlCommand(sql, con); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            con.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }
        


        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();


        }

        private void CustomerInformation_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT INTO CUSTOMER (CustomerID, CustomerName, CustomerAddress, CustomerEmail, CustomerDateOfBirth) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','"+textBox5.Text+"')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Information saved successfully");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM CUSTOMER";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE CUSTOMERINFORMATION SET CustomerName = '" + textBox2.Text + "', CustomerAddress= '" + textBox3.Text + "' ,CustomerEmail = '" + textBox4.Text + "', CustomerDateOfBirth = '" + textBox4.Text + "' WHERE CustomerID = '" + textBox1.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Information updated successfully");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM CUSTOMER where CustomerID ='" + textBox1.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Information deleted successfully");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderForm order = new OrderForm();
            order.Show();
        }
    }

}   
