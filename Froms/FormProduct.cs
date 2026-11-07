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
    public partial class FormProduct : Form
    {
        NewForms.ProductDetails pro;

        public FormProduct()
        {
            InitializeComponent();
            LoadTheme();
            pro = new NewForms.ProductDetails(this);
        }


        public void Display()
        {
            DBProducts.DisplayAndSearch("SELECT * FROM product", dgvProduct);
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

        private void FormProduct_Load(object sender, EventArgs e)
        {


            txtSearch.BorderColor = ThemeColor.SecondaryColor;
            btnAdd.FillColor = ThemeColor.PrimaryColor;
            dgvProduct.ColumnHeadersDefaultCellStyle.BackColor= ThemeColor.PrimaryColor;
            
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pro.Clear();
            pro.ShowDialog();
            
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
           

                DBProducts.DisplayAndSearch( "SELECT * FROM product where product_name LIKE '%" + txtSearch.Text + "%'",dgvProduct);
              
        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FormProduct_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void dgvProduct_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProduct_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //Edit
            if (e.ColumnIndex == 0)
            {
                pro.Clear();
                pro.id = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                pro.productname = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                pro.price = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                pro.category = dgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                pro.UpdateInfo();
                pro.ShowDialog();
                return;
            }
            //Delete
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you want to Delete Product Details ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBProducts.DeleteProduct(dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

        
    }
}
