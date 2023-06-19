using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GymManagementSystem
{
    public partial class ViewMembers : Form
    {
        public ViewMembers()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DEVICE;Initial Catalog=GYM;Integrated Security=True");
        private void populate()
        {
            Con.Open();
            string query = "select * from tbl_user";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MemberSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void ViewMembers_Load(object sender, EventArgs e)
        {
            this.tbl_userTableAdapter.Fill(this.gYMDataSet.tbl_user);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainForm mainfrom = new MainForm();
            mainfrom.Show();
            this.Hide();
        }

        private void FillByPhone()
        {
            Con.Open();
            string query = "select * from tbl_user where phone='" + SearchMember.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MemberSDGV.DataSource = ds.Tables[0];
            Con.Close() ;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            // search
            FillByPhone();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // refresh
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddMember addmember = new AddMember();
            addmember.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateDelete update = new UpdateDelete();
            update.Show();
            this.Hide();
        }
    }
}
