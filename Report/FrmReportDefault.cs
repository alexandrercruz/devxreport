using DevExpress.XtraReports.UI;
using System;
using System.Windows.Forms;

namespace xReport.Report
{
    public partial class FrmReportDefault : Form
    {
        public FrmReportDefault(XtraReport report, string title = "Report")
        {
            Text = title;
            InitializeComponent();
            documentViewer1.DocumentSource = report;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}