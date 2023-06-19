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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Bunifu.Framework.UI;

namespace GymManagementSystem
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }
        private int price;
        public string GenerateRandomString()
        {
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            Random random = new Random();
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < 10; i++)
            {
                int index = random.Next(0, characters.Length);
                sb.Append(characters[index]);
            }

            return sb.ToString();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DEVICE;Initial Catalog=GYM;Integrated Security=True");

        private void populate()
        {
            Con.Open();
            string query = "select * from tbl_payment";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            var ds = new DataSet();
            sda.Fill(ds);
            PaymentDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // đặt lại
            textBox1.Text = "";
            comboBox1.Text = "";
        }
        private void savePaymentId(string paymentId,int userId)
        {
            Con.Open();
            string update = $"UPDATE tbl_user SET payment = '{paymentId}' WHERE id = {userId}";
            SqlCommand cmd = new SqlCommand(update, Con);
            cmd.ExecuteNonQuery();
            Con.Close();
        }
        private void insertPayment(string paymentId,int month,string offer)
        {
            Con.Open();
            string query = $"SELECT * FROM tbl_offer WHERE id = {month}";
            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                price = (int)row["price"];
            }
            string insert = $"INSERT INTO tbl_payment (id,price,offer,startAt,endAt) VALUES ('{paymentId}','{price}',N'{offer}',CONVERT(DATE, GETDATE()),CONVERT(DATE, DATEADD(MONTH, {month}, GETDATE())))";
            SqlCommand cmd = new SqlCommand(insert, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Con.Close();
            savePaymentId(paymentId, int.Parse(textBox1.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Thông tin bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // id
                string id = GenerateRandomString();
                
                switch (comboBox1.Text)
                {
                    case "1 tháng":
                        insertPayment(id, 1, comboBox1.Text);
                        break;
                    case "3 tháng":
                        insertPayment(id, 3, comboBox1.Text);
                        break;
                    case "6 tháng":
                        insertPayment(id, 6, comboBox1.Text);
                        break;
                    case "12 tháng":
                        insertPayment(id, 12, comboBox1.Text);
                        break;
                }
                populate();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // quay lại
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }
    }
}
