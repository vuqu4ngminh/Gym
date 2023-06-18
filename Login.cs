using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace GymManagementSystem
{
    public class MD5Hashing
    {
        public static string GetMD5Hash(string input)
        {
            // Tạo một đối tượng MD5
            using (MD5 md5 = MD5.Create())
            {
                // Chuyển đổi chuỗi đầu vào sang mảng byte
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);

                // Mã hóa mảng byte
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Chuyển đổi mảng byte thành chuỗi hexa
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("x2"));
                }

                // Trả về chuỗi đã mã hóa
                return sb.ToString();
            }
        }
    }

    public partial class Login : Form
    {
        private const string connectionString = "Data Source=DEVICE;Initial Catalog=GYM;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }

        private bool checkAdmin(string _username, string _password)
        {
            string query = "SELECT * FROM tbl_admin";

            SqlDataAdapter adapter = new SqlDataAdapter(query, connectionString);
            DataTable table = new DataTable();
            adapter.Fill(table);

            foreach (DataRow row in table.Rows)
            {
                // Truy cập các cột và kiểm tra giá trị
                string username = (string)row["username"];
                string password = (string)row["password"];
                if (_username == username && _password == password)
                {
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
                MessageBox.Show("Thông tin bị trống");
            }
            else if (checkAdmin(UidTb.Text, currentPwd))
            {

                MainForm mainform = new MainForm();
                mainform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
            }
        }

    }
}
