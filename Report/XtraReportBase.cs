using DevExpress.XtraReports.UI;
using System.Collections.Generic;

namespace xReport.Report
{
    public class XtraReportBase : XtraReport
    {
        public void Load<T>(List<T> data)
        {
            DataSource = data;
        }
    }
}