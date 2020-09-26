using System.Collections.Generic;
using xReport.Data;

namespace xReport.Service
{
    public interface ICustomerService
    {
        Customer GetCustomerById(string id);

        List<Customer> GetCustomers();
    }
}