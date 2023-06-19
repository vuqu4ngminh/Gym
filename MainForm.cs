using System;
using System.Windows.Forms;
using System.IO;

namespace GymManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public string adminName;

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Payment pay = new Payment();
            pay.Show();
            this.Hide();
        }
        private void bunifuThinButton23_Click_1(object sender, EventArgs e)
        {
            ViewMembers viewMembers = new ViewMembers();
            viewMembers.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string filePath = "admin.txt";
            if (File.Exists(filePath))
            {
                adminName = File.ReadAllText(filePath);
                label1.Text = "Xin chào " + adminName;
            }
            
        }
    }
}
