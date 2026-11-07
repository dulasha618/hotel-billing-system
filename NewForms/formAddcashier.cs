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
using Hotel_Billing_System.Froms;

namespace Hotel_Billing_System.NewForms
{
    public partial class formAddcashier : Form
    {

        private readonly AddCashier _parent;
        public string id, cashiername, teleno, username, password;


        public formAddcashier(AddCashier parent)
        {
            InitializeComponent();
            _parent = parent;
        }


        public void UpdateInfo()
        {
            lblname.Text = "Update Cashier Details";
            btnSave.Text = "Update";
            txtCashiername.Text = cashiername;
            txtTelno.Text = teleno;
            txtUsername.Text = username;
            txtPassword.Text = password;
        }

        public void Clear()
        {
            txtCashiername.Text = txtTelno.Text = txtUsername.Text = txtPassword.Text = string.Empty;

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
           
        }

        private void picProduct_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCashiername.Text.Trim().Length < 3)
            {
                MessageBox.Show("Product Name is Empty ( >3 ).");
                return;
            }
            if (txtTelno.Text.Trim().Length < 1)
            {
                MessageBox.Show("Product Price is Empty ( >1 ).");
                return;
            }
            if (txtUsername.Text.Trim().Length < 3)
            {
                MessageBox.Show("Product Category is Empty ( >3 ).");
                return;
            }
            if (txtPassword.Text.Trim().Length < 3)
            {
                MessageBox.Show("Product Category is Empty ( >3 ).");
                return;
            }
            if (btnSave.Text == "Save")
            {
                Cashier cash = new Cashier(txtCashiername.Text.Trim(), txtTelno.Text.Trim(), txtUsername.Text.Trim(), txtPassword.Text.Trim());
                DBCashier.AddCashierInfo(cash);
                Clear();
            }

            if (btnSave.Text == "Update")
            {
                Cashier cash = new Cashier(txtCashiername.Text.Trim(), txtTelno.Text.Trim(), txtUsername.Text.Trim(), txtPassword.Text.Trim());
                DBCashier.UpdateCashierInfo(cash, id);
            }
            _parent.Display();
        }

        private void lblname_Click(object sender, EventArgs e)
        {

        }

        private void txtCashiername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelno_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
