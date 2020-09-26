using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using xReport.Data;

namespace xReport.Report
{
    public partial class rptOrderDetails : DevExpress.XtraReports.UI.XtraReport
    {
        public rptOrderDetails()
        {
            InitializeComponent();
        }

        public void Load(List<Product> products)
        {
            DataSource = products;
        }
    }
}