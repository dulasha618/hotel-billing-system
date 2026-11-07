using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Billing_System.Froms
{
    public partial class FormSetting : Form
    {
        NewForms.AddAdmin ad;

        public FormSetting()
        {
            InitializeComponent();
            LoadTheme();
            ad = new NewForms.AddAdmin(this);
        }

        public void Display()
        {
            DBCashier.DisplayAndSearch("SELECT * FROM adminlogin", dgvAdmin);
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            txtSearch.BorderColor = ThemeColor.SecondaryColor;
            btnAdd.FillColor = ThemeColor.PrimaryColor;
            dgvAdmin.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ad.Clear();
            ad.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DBProducts.DisplayAndSearch("SELECT * FROM adminlogin where admin_name LIKE '%" + txtSearch.Text + "%'", dgvAdmin);
        }

        private void FormSetting_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void dgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Edit
            if (e.ColumnIndex == 0)
            {
                ad.Clear();
                ad.id = dgvAdmin.Rows[e.RowIndex].Cells[2].Value.ToString();
                ad.adminname = dgvAdmin.Rows[e.RowIndex].Cells[3].Value.ToString();
                ad.user_name = dgvAdmin.Rows[e.RowIndex].Cells[4].Value.ToString();
                ad.password = dgvAdmin.Rows[e.RowIndex].Cells[5].Value.ToString();
                ad.UpdateInfo();
                ad.ShowDialog();
                return;
            }
            //Delete
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Are you want to Delete Admin Details ?", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DBSetting.DeleteAdmin(dgvAdmin.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }
                return;
            }
        }

    }
}
