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

namespace Hotel_Billing_System.Froms
{
    public partial class FormCustomers : Form
    {
        public FormCustomers()
        {
            InitializeComponent();
            LoadTheme();
        }

         MySqlConnection con;
        MySqlCommand cm;
        MySqlDataReader dr;
        MySqlDataAdapter da;

        private void CustomerDataView()
        {
            try
            {
                String cs = "server=localhost;user id=root;database=cafeshopmanagemantsystem";
                con = new MySqlConnection(cs);
                con.Open();

                string sql = "select * from customer ";
                da = new MySqlDataAdapter(sql, con);

                DataSet ds = new DataSet();
                da.Fill(ds, "Customer Details");

                dgvCustomer.DataSource = ds.Tables["Customer Details"];


                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                    
                }
            }
            
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void FormCustomers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cafeshopmanagemantsystemDataSet.customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.cafeshopmanagemantsystemDataSet.customer);
            txtSearch.BorderColor = ThemeColor.SecondaryColor;
          
            dgvCustomer.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            CustomerDataView();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String cs = "server=localhost;user id=root;database=cafeshopmanagemantsystem";
                con = new MySqlConnection(cs);
                con.Open();

                string sql = "select * from customer where cusid like '%" + txtSearch.Text + "%'";
                da = new MySqlDataAdapter(sql, con);

                DataSet ds = new DataSet();
                da.Fill(ds, "Customer Details");

                dgvCustomer.DataSource = ds.Tables["Customer Details"];


                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
