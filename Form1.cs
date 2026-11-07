using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel_Billing_System
{
    public partial class Form1 : Form
    {
        //Fields
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;

        MySqlConnection con;
        MySqlCommand cm;
        MySqlDataAdapter da;


        //Constructor
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }


        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Froms.FormProduct(), sender);
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNotifications_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Froms.AddCashier(), sender);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Froms.FormSetting(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void bntMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblLogout_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Froms.FormCustomers(), sender);
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Froms.AddCashier(), sender);
        }

        private void btnOrders_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Froms.FormCategory(), sender);
        }

        private void btnsetting_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Froms.FormSetting(), sender);
        }

        private void btnadmlogin_Click(object sender, EventArgs e)
        {
            
            this.Close();
            adminLogin adlogin = new adminLogin();
            adlogin.Show();   
        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string cs = "server=localhost;user id=root;database=cafeshopmanagemantsystem";
                con = new MySqlConnection(cs);
                con.Open();

                string sql = "select count(*) from cashierinfo";
                da = new MySqlDataAdapter(sql, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                lblCashier.Text = dt.Rows[0][0].ToString();

                string sql2 = "select count(*) from customer";
                da = new MySqlDataAdapter(sql2, con);
                DataTable dt2 = new DataTable();
                da.Fill(dt2);
                lblCustomer.Text = dt2.Rows[0][0].ToString();

                string sql3 = "select sum(price)AS today_income from customer WHERE DATE(Date)=CURDATE();";
                da = new MySqlDataAdapter(sql3, con);
                DataTable dt3 = new DataTable();
                da.Fill(dt3);
                lblTIncome.Text = string.Format("Rs:{0}.00", dt3.Rows[0][0]);
               

                string sql4 = "select sum(price) from customer";
                da = new MySqlDataAdapter(sql4, con);
                DataTable dt4 = new DataTable();
                da.Fill(dt4);
                 lblTotalIncome.Text = string.Format("Rs:{0}.00", dt4.Rows[0][0]);
                

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK);
            }
        }

        private void panelTitleBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void lblTIncome_Click(object sender, EventArgs e)
        {

        }

        private void panelTIncome_Paint(object sender, PaintEventArgs e)
        {

        }

       

    }
}
