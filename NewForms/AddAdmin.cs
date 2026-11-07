using Hotel_Billing_System.Froms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Billing_System.NewForms
{
    public partial class AddAdmin : Form
    {

        private readonly FormSetting _parent;
        public string id, adminname,user_name, password;


        public AddAdmin(FormSetting parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfo()
        {
            lblname.Text = "Update Admin Details";
            btnSave.Text = "Update";
            txtAdminname.Text = adminname;
            txtUsername.Text = user_name;
            txtPassword.Text = password;
        }

        public void Clear()
        {
            txtAdminname.Text = txtUsername.Text = txtPassword.Text = string.Empty;

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
             if (txtAdminname.Text.Trim().Length < 3)
            {
                MessageBox.Show("Admin Name is Empty ( >3 ).");
                return;
            }
           
            if (txtUsername.Text.Trim().Length < 3)
            {
                MessageBox.Show("Admin User Name is Empty ( >3 ).");
                return;
            }
            if (txtPassword.Text.Trim().Length < 3)
            {
                MessageBox.Show("Admin Password is Empty ( >3 ).");
                return;
            }
            if (btnSave.Text == "Save")
            {
                Setting adm = new Setting(txtAdminname.Text.Trim(),txtUsername.Text.Trim(), txtPassword.Text.Trim());
                DBSetting.AddAdminInfo(adm);
                Clear();
            }

            if (btnSave.Text == "Update")
            {
                Setting adm = new Setting(txtAdminname.Text.Trim(), txtUsername.Text.Trim(), txtPassword.Text.Trim());
                DBSetting.UpdateAdminInfo(adm, id);
            }
            _parent.Display();
        }
        }
    }

