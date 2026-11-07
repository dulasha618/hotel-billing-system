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
    public partial class AddCategory : Form
    {

        private readonly FormCategory _parent;
        public string id, category;

        public AddCategory(FormCategory parent)
        {
            InitializeComponent();
            _parent = parent;
        }


        public void UpdateInfo()
        {
            lblname.Text = "Update Category";
            btnSave.Text = "Update";
            txtCategory.Text = category;
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Clear()
        {
            txtCategory.Text = string.Empty;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        
private void categoryBindingSource_CurrentChanged(object sender, EventArgs e)
{

}

private void AddCategory_Load(object sender, EventArgs e)
{

}

private void btnSave_Click(object sender, EventArgs e)
{
    
    if (txtCategory.Text.Trim().Length < 3)
    {
        MessageBox.Show("Product Category is Empty ( >3 ).");
        return;
    }

    if (btnSave.Text == "Save")
    {
        Categorys cat = new Categorys (txtCategory.Text.Trim());
        DBCategory.AddCategory(cat);
        Clear();
    }
    if (btnSave.Text == "Update")
    {
        Categorys cat = new Categorys(txtCategory.Text.Trim());
        DBCategory.UpdateCategory(cat, id);
    }
    _parent.Display();
   
}
    }
}
