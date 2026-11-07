using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Billing_System
{
    class DBProducts
    {
        public static MySqlConnection GetConnection()
        {
            string cs = "server=localhost;user id=root;database=cafeshopmanagemantsystem";
            MySqlConnection con = new MySqlConnection(cs);

            try
            {
                con.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("MySql Connection! \n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return con;
        }

        public static void AddProduct(Products prod)
        {
            string sql = "INSERT INTO product VALUES (NULL,@ProductName,@Price,@Category)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ProductName", MySqlDbType.VarChar).Value = prod.product_name;
            cmd.Parameters.Add("@Price", MySqlDbType.VarChar).Value = prod.price;
            cmd.Parameters.Add("@Category", MySqlDbType.VarChar).Value = prod.category;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Product Not Insert \n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateProduct(Products prod, string id)
        {
            string sql = "UPDATE product SET product_name = @ProductName, price = @Price, category = @Category WHERE prid = @ProductID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ProductID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@ProductName", MySqlDbType.VarChar).Value = prod.product_name;
            cmd.Parameters.Add("@Price", MySqlDbType.VarChar).Value = prod.price;
            cmd.Parameters.Add("@Category", MySqlDbType.VarChar).Value = prod.category;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Product Not Update \n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void DeleteProduct(string id)
        {
            string sql = "DELETE FROM product WHERE prid = @ProductID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ProductID", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Product Not Delete \n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DisplayAndSearch(string qry, DataGridView dgv)
        {
            string sql = qry;
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter adp = new MySqlDataAdapter(cmd);
            DataTable tbl = new DataTable();
            adp.Fill(tbl);
            dgv.DataSource = tbl;
            con.Close();
        }



        internal static void DeleteCashier(string p)
        {
            throw new NotImplementedException();
        }
    }

}
