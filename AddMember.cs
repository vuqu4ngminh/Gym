using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GymManagementSystem
{
    public partial class AddMember : Form
    {
        public AddMember()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=DEVICE;Initial Catalog=GYM;Integrated Security=True");
        private void button2_Click(object sender, EventArgs e)
        {
            if (NameTb.Text == "" || PhoneTb.Text == "" || AgeTb.Text == "")
            {
                MessageBox.Show("Thông tin bị trống", "Lỗi",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();
                    Random random = new Random();
                    int id = random.Next(1000000, 10000000);
                    string payment = "Null";
                    string query = "insert into tbl_user (id,name,phone,gender,age,payment) values('" + id + "',N'" + NameTb.Text + "', '" + PhoneTb.Text + "', N'" + GenderCb.SelectedItem.ToString() + "', '" + AgeTb.Text + "','" + payment + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member Successfully Added", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    AgeTb.Text = "";
                    NameTb.Text = "";
                    PhoneTb.Text = "";
                    GenderCb.Text = "";
                } catch (Exception Ex) 
                {
                    MessageBox.Show(Ex.Message,"Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // reset
            AgeTb.Text = "";
            NameTb.Text = "";
            PhoneTb.Text = "";
            GenderCb.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewMembers viewMembers = new ViewMembers();
            viewMembers.Show();
            this.Hide();
        }
    }
}
