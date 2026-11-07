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
    class DBCashier
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

        public static void AddCashierInfo(Cashier cash)
        {
            string sql = "INSERT INTO cashierinfo VALUES (NULL,@CashierName,@TelePhone,@UserName,@Password)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@CashierName", MySqlDbType.VarChar).Value = cash.cashier_name;
            cmd.Parameters.Add("@TelePhone", MySqlDbType.VarChar).Value = cash.telephone;
            cmd.Parameters.Add("@UserName", MySqlDbType.VarChar).Value = cash.user_name;
            cmd.Parameters.Add("@Password", MySqlDbType.VarChar).Value = cash.password;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cashier Details Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Cashier Details Not Insert \n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateCashierInfo(Cashier cash, string id)
        {
            string sql = "UPDATE cashierinfo SET cashier_name = @CashierName, telephone = @TelePhone, user_name = @UserName, password = @Password WHERE caid = @CashierID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@CashierID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@CashierName", MySqlDbType.VarChar).Value = cash.cashier_name;
            cmd.Parameters.Add("@TelePhone", MySqlDbType.VarChar).Value = cash.telephone;
            cmd.Parameters.Add("@UserName", MySqlDbType.VarChar).Value = cash.user_name;
            cmd.Parameters.Add("@Password", MySqlDbType.VarChar).Value = cash.password;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cashier Details Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Cashier Details Not Update \n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }
        public static void DeleteCashier(string id)
        {
            string sql = "DELETE FROM cashierinfo WHERE caid = @CashierID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@CashierID", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cashier Details Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Cashier Details Not Delete \n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
