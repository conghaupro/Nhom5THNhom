using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaoCaoTestCase
{
    public partial class QLBanHang : Form
    {
        static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["BaoCao"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        SqlCommand cmd;
        public QLBanHang()
        {
            InitializeComponent();
        }

        public void display_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Thongtinban";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void QLBanHang_Load(object sender, EventArgs e)
        {
            display_data();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa thành công !");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thêm thành công !");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            ThanhToancs tt = new ThanhToancs();
            tt.Show();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            DialogResult tb = MessageBox.Show("Bạn có chắc chắn thoát hay không ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (tb == DialogResult.OK)
                this.Close();
        }
    }
}
