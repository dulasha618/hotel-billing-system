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
    public partial class FormCategory : Form
    {
        NewForms.AddCategory cat;
       

        public FormCategory()
        {
            InitializeComponent();
            LoadTheme();
            cat = new NewForms.AddCategory(this);
        }

        MySqlConnection con;
        MySqlDataAdapter da;

        

        public void Display()
        {
            DBCategory.DisplayAndSearch("SELECT * FROM category", dgvCategory);
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

        
        

        private void FormCategory_Load(object sender, EventArgs e)
        {
            
            txtSearch.BorderColor = ThemeColor.SecondaryColor;
            btnAdd.FillColor = ThemeColor.PrimaryColor;
            dgvCategory.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
          
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            cat.Clear();
            cat.ShowDialog();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                String cs = "server=localhost;user id=root;database=cafeshopmanagemantsystem";
                con = new MySqlConnection(cs);
                con.Open();

                string sql = "select * from category ";
                da = new MySqlDataAdapter(sql, con);

                DataSet ds = new DataSet();
                da.Fill(ds, "Category Details");

                dgvCategory.DataSource = ds.Tables["Category Details"];


                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DBCategory.DisplayAndSearch("SELECT * FROM category where category_name LIKE '%" + txtSearch.Text + "%'", dgvCategory);
        }

        private void FormCategory_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void dgvCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Edit
            if (e.ColumnIndex == 0)
            {
                cat.Clear();
                cat.id = dgvCategory.Rows[e.RowIndex].Cells[2].Value.ToString();
                cat.category = dgvCategory.Rows[e.RowIndex].Cells[3].Value.ToString();
                cat.UpdateInfo();
                cat.ShowDialog();
                return;
            }
            //Delete
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you want to Delete Category Details ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBCategory.DeleteCategory(dgvCategory.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

    }
}
