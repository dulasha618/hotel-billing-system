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
    public partial class ProductDetails : Form
    {
        private readonly FormProduct _parent;
        public string id, productname, price, category;

        public ProductDetails(FormProduct parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfo()
        {
            lblname.Text = "Update Product";
            btnProsave.Text = "Update";
            txtProName.Text = productname;
            txtSalePrice.Text = price;
            cmbCategory.Text = category;
        }
        public ProductDetails()
        {
           
        }

        public void Clear()
        {
            txtProName.Text = txtSalePrice.Text = cmbCategory.Text = string.Empty;
        }

        MySqlConnection con;
        MySqlCommand cm;
        MySqlDataAdapter da;
        


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            
        }

        private void btnProsave_Click(object sender, EventArgs e)
        {
            if (txtProName.Text.Trim().Length < 3)
            {
                MessageBox.Show("Product Name is Empty ( >3 ).");
                return;
            }
            if (txtSalePrice.Text.Trim().Length < 1)
            {
                MessageBox.Show("Product Price is Empty ( >1 ).");
                return;
            }
            if (cmbCategory.Text.Trim().Length < 3)
            {
                MessageBox.Show("Product Category is Empty ( >3 ).");
                return;
            }

            if (btnProsave.Text == "Save")
            {
                Products prod = new Products(txtProName.Text.Trim(), txtSalePrice.Text.Trim(),cmbCategory.Text.Trim());
                DBProducts.AddProduct(prod);
                Clear();
            }

            if(btnProsave.Text == "Update")
            {
                Products prod = new Products(txtProName.Text.Trim(), txtSalePrice.Text.Trim(), cmbCategory.Text.Trim());
                DBProducts.UpdateProduct(prod,id);
            }
            _parent.Display();
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            if (btnProsave.Text == "Save")
            {

                String cs = "server=localhost;user id=root;database=cafeshopmanagemantsystem";
                con = new MySqlConnection(cs);
                con.Open();
                cmbCategory.Items.Clear();


                string sql = "select category_name from category";
                cm = new MySqlCommand(sql, con);
                DataTable dt = new DataTable();
                da = new MySqlDataAdapter(cm);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    cmbCategory.Items.Add(dr["category_name"].ToString());
                }
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
