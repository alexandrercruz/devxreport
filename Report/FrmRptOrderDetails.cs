using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xReport.Data;

namespace xReport.Report
{
    public partial class FrmRptOrderDetails : Form
    {
        public FrmRptOrderDetails(List<Product> products)
        {
            rptOrderDetails report = new rptOrderDetails();
            report.Load(products);
            InitializeComponent();
            documentViewer1.DocumentSource = report;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}