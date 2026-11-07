using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Billing_System.Froms
{
    public partial class Order : Form
    {
        int order = 1;
        double total = 0;

        
        double A;
        double C;

        double P;
        double Q;
        double PQ;

        public Order()
        {
            InitializeComponent();
            LoadTheme();
        }

        MySqlConnection con;
        MySqlCommand cm;
        MySqlCommand cm2;
        MySqlDataAdapter da;
        DataSet ds;
        MySqlDataReader dr;
        MySqlDataReader dr2;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }
       
        private void Order_Load(object sender, EventArgs e)
        {
            
            this.productTableAdapter1.Fill(this.cafeshopmanagemantsystemDataSet4.product);
           
           
            receiptBindingSource.DataSource = new List<Receipt>();
            dgvDataProduct.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
            dgvOrRecipt.ColumnHeadersDefaultCellStyle.BackColor = ThemeColor.PrimaryColor;
         
           
            btnOrAdd.FillColor = ThemeColor.PrimaryColor;
            btnRemove.FillColor = ThemeColor.PrimaryColor;
            btnClr.FillColor = ThemeColor.PrimaryColor;
            btnOrpay.FillColor = ThemeColor.PrimaryColor;
            btnOrReceipt.FillColor = ThemeColor.PrimaryColor;

            String cs = "server=localhost;user id=root;database=cafeshopmanagemantsystem";
            con = new MySqlConnection(cs);
            con.Open();
            comboBoxType.Items.Clear();
            comboBoxPid.Items.Clear();

            string sql = "select category_name from category";
            cm = new MySqlCommand(sql,con);
            DataTable dt = new DataTable();
            da = new MySqlDataAdapter(cm);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows) {
                comboBoxType.Items.Add(dr["category_name"].ToString());   
            }


           

                        
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cs = "server=localhost;user id=root;database=cafeshopmanagemantsystem";
            con = new MySqlConnection(cs);
            con.Open();
            comboBoxPid.Items.Clear();
            

            string sql2 = "select prid from product where category like '" + comboBoxType.Text + "'";
            MySqlCommand cm2 = new MySqlCommand(sql2, con);
            DataTable dt2 = new DataTable();
            MySqlDataAdapter da2 = new MySqlDataAdapter(cm2);
            da2.Fill(dt2);

            foreach (DataRow dr2 in dt2.Rows)
            {
                comboBoxPid.Items.Add(dr2["prid"].ToString());
            }
            
        }

        private void comboBoxPid_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cs = "server=localhost;user id=root;database=cafeshopmanagemantsystem";
            con = new MySqlConnection(cs);
            con.Open();



            string sql2 = "select product_name,price from product where prid like '" + comboBoxPid.Text + "'";
            MySqlCommand cm2 = new MySqlCommand(sql2, con);
            DataTable dt2 = new DataTable();
            MySqlDataAdapter da2 = new MySqlDataAdapter(cm2);
            da2.Fill(dt2);

            foreach (DataRow dr2 in dt2.Rows)
            {
                lblProductname.Text = dr2["product_name"].ToString();
                lblPrice.Text = dr2["price"].ToString();
                
            }

            
        }

        private void lblProductname_Click(object sender, EventArgs e)
        {

        }
       
        private void btnClr_Click(object sender, EventArgs e)
        {
            comboBoxType.Text = string.Empty ;
            comboBoxPid.Text = string.Empty;
            comboBoxPid.Items.Clear();
            lblPrice.Text = "";
            lblProductname.Text = "";
            txtQty.Text = "";
        }

        private void btnOrsave_Click(object sender, EventArgs e)
        {

        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
         

           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnOrAdd_Click(object sender, EventArgs e)
        {
            P = Convert.ToDouble(lblPrice.Text);
            Q = Convert.ToDouble(txtQty.Text);
            PQ = Q * P;
            
            String cs = "server=localhost;user id=root;database=cafeshopmanagemantsystem";
            con = new MySqlConnection(cs);
            con.Open();

            string sql2 = "insert into orders (prid,product_name,category,quantity,price)values( '" + comboBoxPid.Text + "','" + lblProductname.Text + "','" + comboBoxType.Text + "','" + txtQty.Text + "','" + PQ + "')";
            cm2 = new MySqlCommand(sql2, con);

            dr2 = cm2.ExecuteReader();

            dr2.Close();
            con.Close();

            if (!string.IsNullOrEmpty(lblProductname.Text) && !string.IsNullOrEmpty(lblPrice.Text))
            {
                Receipt obj = new Receipt()
                {
                   ID=order++,ProductName=lblProductname.Text,Price=Convert.ToDouble(lblPrice.Text),Quantity=Convert.ToInt32(txtQty.Text)
                };
                total += obj.Price * obj.Quantity;
                receiptBindingSource.Add(obj);
                receiptBindingSource.MoveLast();
                lblProductname.Text = string.Empty;
                lblPrice.Text = string.Empty;
                txtQty.Text = "";
                comboBoxType.Text = string.Empty;
                comboBoxPid.Text = string.Empty;
                comboBoxPid.Items.Clear();
                lblorPrz.Text = string.Format("{0}.00",total);

            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Receipt obj = receiptBindingSource.Current as Receipt;
            if (obj != null) 
            {
                total -= obj.Price * obj.Quantity;
                lblorPrz.Text = string.Format("{0}", total);
            }
            receiptBindingSource.RemoveCurrent();
        }

        private void btnOrReceipt_Click(object sender, EventArgs e)
        {
            using (FrmPrint frm = new FrmPrint(receiptBindingSource.DataSource as List<Receipt>, string.Format("Rs:{0}.00", total), string.Format("Rs:{0}.00", txtOramt.Text), string.Format("Rs:{0}.00", lblorChg.Text), DateTime.Now.ToString("MM/dd/yyyy")))
            {
                frm.ShowDialog();
            }
        }

        private void btnOrpay_Click(object sender, EventArgs e)
        {
            
            A = Convert.ToDouble(txtOramt.Text);

            C = A - total;
            lblorChg.Text = string.Format("{0}.00",C);

            try
            {
                    String cs = "server=localhost;user id=root;database=cafeshopmanagemantsystem";
                    con = new MySqlConnection(cs);
                    con.Open();


                    string sql = "insert into customer (price,amount,changes)values( '" + lblorPrz.Text + "','" + txtOramt.Text + "','" + lblorChg.Text + "')";
                    cm = new MySqlCommand(sql, con);

                    dr = cm.ExecuteReader();
                    dr.Close();

                   
                    MessageBox.Show("Payment Done", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void receiptBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dgvDataProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
