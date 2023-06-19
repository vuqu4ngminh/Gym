using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GymManagementSystem
{
    public partial class UpdateDelete : Form
    {
        public UpdateDelete()
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
        private void UpdateDelete_Load(object sender, EventArgs e)
        {
            this.tbl_userTableAdapter.Fill(this.gYMDataSet.tbl_user);
        }

        int key;
        private void MemberSDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            DataGridViewRow selectedRow = MemberSDGV.CurrentRow;

            key = Convert.ToInt32(selectedRow.Cells[0].Value);

            NameTb.Text = selectedRow.Cells[1].Value.ToString();
            PhoneTb.Text = selectedRow.Cells[2].Value.ToString();
            GenderCb.Text = selectedRow.Cells[3].Value.ToString();
            AgeTb.Text = selectedRow.Cells[4].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // reset
            NameTb.Text = "";
            AgeTb.Text = "";
            PhoneTb.Text = "";
            GenderCb.Text = "";
        }
        private void FillByPhone()
        {
            Con.Open();
            string query = "select * from tbl_user where phone='" + bunifuMaterialTextbox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            MemberSDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewMembers viewMembers = new ViewMembers();
            viewMembers.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Mã khách hàng bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from tbl_user where id=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    populate();

                } catch ( Exception Ex )
                {
                    MessageBox.Show(Ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (key == 0 || NameTb.Text == "" || PhoneTb.Text == "" || AgeTb.Text == "" || GenderCb.Text == "" )
            {
                MessageBox.Show("Thông tin bị trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = $"update tbl_user set name=N'{NameTb.Text}', phone='{PhoneTb.Text}', gender=N'{GenderCb.Text}', age={AgeTb.Text} where id={key};";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cập nhật thành công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Con.Close();
                    populate();

                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FillByPhone();
        }
    }
}
