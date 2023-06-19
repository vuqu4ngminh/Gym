using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace GymManagementSystem
{
    public class MD5Hashing
    {
        public static string GetMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }
                return sb.ToString();
            }
        }
    }
    
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }
        private string name;
        SqlConnection Con = new SqlConnection(@"Data Source=DEVICE;Initial Catalog=GYM;Integrated Security=True");
        private bool checkAdmin(string _username, string _password)
        {
            Con.Open();
            string query = "SELECT * FROM tbl_admin";

            SqlDataAdapter adapter = new SqlDataAdapter(query, Con);
            DataTable table = new DataTable();
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                // Truy cập các cột và kiểm tra giá trị
                string username = (string)row["username"];
                string password = (string)row["password"];
                if (_username == username && _password == password)
                {
                    name = (string)row["name"];
                    Con.Close();
                    return true;
                }

            }
            return false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentPwd = MD5Hashing.GetMD5Hash(PassTb.Text);

            if (UidTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Thông tin bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (checkAdmin(UidTb.Text, currentPwd))
            {
                File.WriteAllText("admin.txt", name);
                MainForm mainform = new MainForm();
                mainform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
