using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Billing_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        MySqlConnection con;
        MySqlDataAdapter da;

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                String cs = "server=localhost;user id=root;database=cafeshopmanagemantsystem";
                con = new MySqlConnection(cs);
                con.Open();

                string sql = "select user_name,password from cashierinfo  where user_name = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'";
                da = new MySqlDataAdapter(sql, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    UserPanel upanel = new UserPanel();
                    upanel.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Login Failed!");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                }

                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAdpanel_Click(object sender, EventArgs e)
        {
            adminLogin adlogin = new adminLogin();
            adlogin.Show();
            this.Hide();
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaControlBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
