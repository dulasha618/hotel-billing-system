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
    public partial class FrmPrint : Form
    {
        List<Receipt> _list;
        string _total, _cash, _change, _date;

        public FrmPrint(List<Receipt> dataSource, string total, string cash, string change, string date)
        {
            InitializeComponent();
            _list = dataSource;
            _total = total;
            _cash = cash;
            _change = change;
            _date = date;
        }

        private void FrmPrint_Load(object sender, EventArgs e)
        {
            ReceiptBindingSource.DataSource = _list;
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new  Microsoft.Reporting.WinForms.ReportParameter("PTotal",_total),
                new  Microsoft.Reporting.WinForms.ReportParameter("PCash",_cash),
                new  Microsoft.Reporting.WinForms.ReportParameter("PChange",_change),
                new  Microsoft.Reporting.WinForms.ReportParameter("PDate",_date)
            };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
