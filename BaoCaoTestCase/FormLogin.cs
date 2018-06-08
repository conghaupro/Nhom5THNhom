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
using System.Configuration;

namespace BaoCaoTestCase
{
    public partial class FormLogin : Form
    {
        
        static string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["BaoCao"].ConnectionString;
        SqlConnection con = new SqlConnection(connectionString);
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtTK.Text == "" || txtMK.Text == "")
                MessageBox.Show("Username or password are not empty. Please retype !", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                SqlConnection cn = new SqlConnection(connectionString);
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from Login where TaiKhoan = '" + txtMK.Text + "' and MatKhau = '" + txtTK.Text + "'", cn);
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                int count = 0;
                while (dr.Read())
                {
                    count += 1;
                }
                if (count == 1)
                {
                    MessageBox.Show("Login Successful !", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1 fm1 = new Form1();
                    fm1.Show();
                    this.Hide();
                }

                else if (count >= 0)
                {
                    MessageBox.Show("Username or password are not correct ! Please try again !", "Notifications", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                txtTK.Clear();
                txtMK.Clear();
            }
        }
    }
}
