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
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }

        MySqlConnection con;
        MySqlDataAdapter da;

        private void btnBack_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            log.Show();
            this.Hide();
        }

        private void btnAdminlogin_Click(object sender, EventArgs e)
        {
            try
            {
                String cs = "server=localhost;user id=root;database=cafeshopmanagemantsystem";
                con = new MySqlConnection(cs);
                con.Open();

                string sql = "select password from adminlogin where password = '" + txtAPassword.Text + "'";
                da = new MySqlDataAdapter(sql, con);

                DataTable dt = new DataTable();

                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    Form1 adpanel = new Form1();
                    adpanel.Show();
                    this.Hide();
                }

                else
                {
                    MessageBox.Show("Login Failed!");
                    txtAPassword.Text = "";
                }


                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
