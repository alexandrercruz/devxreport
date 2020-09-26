using System.Collections.Generic;
using System.Linq;
using xReport.Data;

namespace xReport.Service
{
    public class CustomerService : ICustomerService
    {
        public Customer GetCustomerById(string id)
        {
            NorthwindEntities nw = new NorthwindEntities();

            return nw.Customers
                .Where(c => c.CustomerID == id)
                .FirstOrDefault();
        }

        public List<Customer> GetCustomers()
        {
            NorthwindEntities nw = new NorthwindEntities();

            return nw.Customers.ToList();
        }
    }
}