using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Billing_System
{
    public partial class LoadingPage : Form
    {
        public LoadingPage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2CircleProgressBar1.Value == 100)
            {
                timer1.Stop();
                Login ulogin = new Login();
                ulogin.Show();
                this.Hide();
            }
            else
            {
                guna2CircleProgressBar1.Value += 1;
                lblpre.Text = (Convert.ToInt32(lblpre.Text) + 1).ToString();
            }
        }

        private void LoadingPage_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            timer1.Start();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblpre_Click(object sender, EventArgs e)
        {

        }
    }
}
