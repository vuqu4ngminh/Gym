using System;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace GymManagementSystem
{
    public partial class Admin : Form
    {
        private int id;
        private string pwd;
        SqlConnection Con = new SqlConnection(@"Data Source=DEVICE;Initial Catalog=GYM;Integrated Security=True");
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // update
            if(textBox1.Text == "")
            {
                MessageBox.Show("Thông tin bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(textBox2.Text == "" || textBox3.Text == "")
                {
                    Con.Open();
                    string query = $"update tbl_admin set name=N'{textBox1.Text}' where id={id};";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    AdminInfo adminInfo = new AdminInfo()
                    {
                        name = textBox1.Text,
                        id = id
                    };
                    AdminFileManager adminFileManager = new AdminFileManager();
                    adminFileManager.SaveAdminInfo("admin.txt", adminInfo);
                } else
                {
                    if (MD5Hashing.GetMD5Hash(textBox2.Text) != pwd)
                    {
                        MessageBox.Show("Mật khẩu cũ không chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Con.Open();
                        string query = $"update tbl_admin set name=N'{textBox1.Text}', password='{MD5Hashing.GetMD5Hash(textBox3.Text)}' where id={id};";

                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Con.Close();
                        AdminInfo adminInfo = new AdminInfo()
                        {
                            name = textBox1.Text,
                            id = id
                        };
                        AdminFileManager adminFileManager = new AdminFileManager();
                        adminFileManager.SaveAdminInfo("admin.txt", adminInfo);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // return
            MainForm mainform = new MainForm();
            mainform.Show();
            this.Hide();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            AdminFileManager adminFileManager = new AdminFileManager();
            AdminInfo loadedAdminInfo = adminFileManager.LoadAdminInfo("admin.txt");
            id = loadedAdminInfo.id;
            textBox1.Text = loadedAdminInfo.name;
            Con.Open();
            string query = $"SELECT * FROM tbl_admin WHERE id = {id}";

            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            DataTable table = new DataTable();
            adapter.Fill(table);
            foreach (DataRow row in table.Rows)
            {
                pwd = (string)row["password"];
            }
            Con.Close();
        }
    }
}
