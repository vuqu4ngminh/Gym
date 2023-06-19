using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;

namespace GymManagementSystem
{
    public class AdminInfo
    {
        public string name { get; set; }
        public int id { get; set; }
    }

    public class AdminFileManager
    {
        public void SaveAdminInfo(string fileName, AdminInfo adminInfo)
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(adminInfo.name);
                writer.WriteLine(adminInfo.id);
            }
        }

        public AdminInfo LoadAdminInfo(string fileName)
        {
            AdminInfo adminInfo = new AdminInfo();

            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    adminInfo.name = reader.ReadLine();
                    int.TryParse(reader.ReadLine(), out int id);
                    adminInfo.id = id;
                }
            }

            return adminInfo;
        }
    }
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
                    AdminInfo adminInfo = new AdminInfo()
                    {
                        name = (string)row["name"],
                        id = (int)row["id"]
                    };
                    AdminFileManager adminFileManager = new AdminFileManager();
                    adminFileManager.SaveAdminInfo("admin.txt", adminInfo);
                    Con.Close();
                    return true;
                }

            }
            Con.Close();
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
