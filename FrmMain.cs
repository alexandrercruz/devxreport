using System;
using System.Collections.Generic;
using System.Threading;
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
                FrmReportDefault frmReport = new FrmReportDefault(report, "Order Details Report");
                frmReport.ShowDialog();
            });

            button1.Enabled = true;
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;

            await StartSTATask<dynamic>(() =>
            {
                //Get data
                ICustomerService service = new CustomerService();
                var customers = service.GetCustomers();

                //Create report
                rptCustomer report = new rptCustomer();
                report.Load(customers);

                //Show form report
                FrmReportDefault frmReport = new FrmReportDefault(report, "Customer Details Report");
                frmReport.ShowDialog();

                return null;
            });

            button2.Enabled = true;
        }

        private static Task<T> StartSTATask<T>(Func<T> func)
        {
            var tcs = new TaskCompletionSource<T>();
            Thread thread = new Thread(() =>
            {
                try
                {
                    tcs.SetResult(func());
                }
                catch (Exception e)
                {
                    tcs.SetException(e);
                }
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            return tcs.Task;
        }
    }
}