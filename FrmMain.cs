using DevExpress.XtraReports.UI;
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
using xReport.Report;
using xReport.Service;

namespace xReport
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;

            await Task.Run(() =>
            {
                //Get data
                IProductService service = new ProductService();
                var products = service.GetProductsByOrder(10248);

                //Create report
                rptOrderDetails report = new rptOrderDetails();
                report.Load(products);

                //Show form report
                FrmReportDefault frmReport = new FrmReportDefault(report);
                frmReport.ShowDialog();
            });

            button1.Enabled = true;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;

            await Task.Run(() =>
            {
                //Get data
                ICustomerService service = new CustomerService();
                var customer = service.GetCustomerById("ANATR");

                var customers = new List<Customer>();

                customers.Add(customer);

                //Create report
                rptCustomer report = new rptCustomer();
                report.Load(service.GetCustomers());

                //Show form report
                FrmReportDefault frmReport = new FrmReportDefault(report);
                frmReport.ShowDialog();
            });

            button2.Enabled = true;
        }
    }
}