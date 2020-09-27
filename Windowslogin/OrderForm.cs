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
    public partial class OrderForm : Form
    {
        public OrderForm()
        {
            InitializeComponent();
        }

        private void ketnoicsdl()
        {
            con.Open();
            string sql = "select * from ORDERFORM";  // lay het du lieu trong bang customer
            SqlCommand com = new SqlCommand(sql, con); //bat dau truy van
            com.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(com); //chuyen du lieu ve
            DataTable dt = new DataTable(); //tạo một kho ảo để lưu trữ dữ liệu
            da.Fill(dt);  // đổ dữ liệu vào kho
            con.Close();  // đóng kết nối
            dataGridView1.DataSource = dt; //đổ dữ liệu vào datagridview
        }



        SqlConnection con = new SqlConnection(@"Data Source=2ndMainlaptop;Initial Catalog=electroshop;Integrated Security=True");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "UPDATE ORDERFORM SET OrderDate = '" +OrderDateBox7.Text + "',DeliveryDate = '" + DeliveryDateBox3.Text + "' ,CustomerID = '" + CustomerIDtextBox1.Text + "',StaffID = '" + StaffIDBox4.Text + "' WHERE OrderFormID = '" + OrderIDBox1.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
           
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Information updated successfully");

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            String query = "INSERT INTO ORDERFORM (OrderFormID, CustomerID, StaffID, OrderDate, DeliveryDate) VALUES('"+OrderIDBox1.Text+ "','" + CustomerIDtextBox1.Text + "','" + StaffIDBox4.Text + "','" + OrderDateBox7.Text + "','" + DeliveryDateBox3.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Information saved successfully");

        }
        

        private void CustomerIDcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {
            ketnoicsdl();
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderIDBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            CustomerIDtextBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            StaffIDBox4.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            OrderDateBox7.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            DeliveryDateBox3.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void Viewbutton2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "SELECT * FROM ORDERFORM ";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            SDA.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "DELETE FROM ORDERFORM where OrderFormID ='"+ OrderIDBox1.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(query, con);
            SDA.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Information deleted successfully");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomerInformation cus = new CustomerInformation();
            cus.Show();

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrderFormDetail OFD = new OrderFormDetail();
            OFD.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Information staff = new Staff_Information();
            staff.Show();
        }
    }
}
