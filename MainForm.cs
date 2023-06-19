using System;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.Show();
            this.Hide();
        }
        private void bunifuThinButton23_Click_1(object sender, EventArgs e)
        {
            // khách hàng
            ViewMembers viewMembers = new ViewMembers();
            viewMembers.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // hiện tên
            AdminFileManager adminFileManager = new AdminFileManager();
            AdminInfo loadedAdminInfo = adminFileManager.LoadAdminInfo("admin.txt");
            label1.Text = "Xin chào " + loadedAdminInfo.name;

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            // admin
            Admin admin = new Admin();
            admin.Show();
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            // dịch vụ
            Service service = new Service();
            service.Show();
            this.Hide();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            // thoát
            Application.Exit();
        }
    }
}
