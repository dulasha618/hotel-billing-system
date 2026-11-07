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
    class DBSetting
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

        public static void AddAdminInfo(Setting adm)
        {
            string sql = "INSERT INTO adminlogin VALUES (NULL,@AdminName,@UserName,@Password)";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@AdminName", MySqlDbType.VarChar).Value = adm.admin_name;
            cmd.Parameters.Add("@UserName", MySqlDbType.VarChar).Value = adm.user_name;
            cmd.Parameters.Add("@Password", MySqlDbType.VarChar).Value = adm.password;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Admin Details Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Admin Details Not Insert \n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void UpdateAdminInfo(Setting adm, string id)
        {
            string sql = "UPDATE adminlogin SET admin_name = @AdminName, user_name = @UserName, password = @Password WHERE id = @AdminID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@AdminID", MySqlDbType.VarChar).Value = id;
            cmd.Parameters.Add("@AdminName", MySqlDbType.VarChar).Value = adm.admin_name;
            cmd.Parameters.Add("@UserName", MySqlDbType.VarChar).Value = adm.user_name;
            cmd.Parameters.Add("@Password", MySqlDbType.VarChar).Value = adm.password;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Admin Details Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Admin Details Not Update \n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
        }

        public static void DeleteAdmin(string id)
        {
            string sql = "DELETE FROM adminlogin WHERE id = @AdminID";
            MySqlConnection con = GetConnection();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@AdminID", MySqlDbType.VarChar).Value = id;

            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Admin Details Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Admin Details Not Delete \n " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
