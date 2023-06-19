using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DEVICE;Initial Catalog=GYM;Integrated Security=True");
        private void Service_Load(object sender, EventArgs e)
        {
            Con.Open();
            string query = "SELECT * FROM tbl_offer";

            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            DataTable table = new DataTable();
            adapter.Fill(table);

            List<int> prices = new List<int>();

            foreach (DataRow row in table.Rows)
            {
                int columnValue = row.Field<int>("price");
                prices.Add(columnValue);
            }
            int[] arr = prices.ToArray();
            textBox1.Text = arr[0].ToString();
            textBox2.Text = arr[1].ToString();
            textBox3.Text = arr[2].ToString();
            textBox4.Text = arr[3].ToString();

            Con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Thông tin bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                int price;
                if(int.TryParse(textBox1.Text, out price))
                {
                    Con.Open();
                    string query = $"update tbl_offer set price={price} where id=1;";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Thông tin không đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Thông tin bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int price;
                if (int.TryParse(textBox2.Text, out price))
                {
                    Con.Open();
                    string query = $"update tbl_offer set price={price} where id=3;";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Thông tin không đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Thông tin bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int price;
                if (int.TryParse(textBox3.Text, out price))
                {
                    Con.Open();
                    string query = $"update tbl_offer set price={price} where id=6;";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Thông tin không đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Thông tin bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int price;
                if (int.TryParse(textBox4.Text, out price))
                {
                    Con.Open();
                    string query = $"update tbl_offer set price={price} where id=12;";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Thông tin không đúng định dạng", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainForm mainfrom = new MainForm();
            mainfrom.Show();
            this.Hide();
        }
    }
}
