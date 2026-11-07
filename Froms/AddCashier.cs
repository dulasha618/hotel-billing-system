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
    public partial class AddCashier : Form
    {
        NewForms.formAddcashier ca;

        public AddCashier()
        {
            InitializeComponent();
            LoadTheme();
            ca = new NewForms.formAddcashier(this);
        }

        

        public void Display()
        {
            DBCashier.DisplayAndSearch("SELECT * FROM cashierinfo", dgvCashier);
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

        private void AddCashier_Load(object sender, EventArgs e)
        {
            txtSearch.BorderColor = ThemeColor.SecondaryColor;
            btnAdd.FillColor = ThemeColor.PrimaryColor;
            dgvCashier.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ca.Clear();
            ca.ShowDialog();
        }

        private void dgvCashier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DBProducts.DisplayAndSearch("SELECT * FROM cashierinfo where cashier_name LIKE '%" + txtSearch.Text + "%'", dgvCashier);
        }

        private void AddCashier_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void dgvCashier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void dgvCashier_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Edit
            if (e.ColumnIndex == 0)
            {
                ca.Clear();
                ca.id = dgvCashier.Rows[e.RowIndex].Cells[2].Value.ToString();
                ca.cashiername = dgvCashier.Rows[e.RowIndex].Cells[3].Value.ToString();
                ca.teleno = dgvCashier.Rows[e.RowIndex].Cells[4].Value.ToString();
                ca.username = dgvCashier.Rows[e.RowIndex].Cells[5].Value.ToString();
                ca.password = dgvCashier.Rows[e.RowIndex].Cells[6].Value.ToString();
                ca.UpdateInfo();
                ca.ShowDialog();
                return;
            }
            //Delete
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you want to Delete Product Details ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBCashier.DeleteCashier(dgvCashier.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

    }
}
