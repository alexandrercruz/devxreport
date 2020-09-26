using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xReport.Data;

namespace xReport.Service
{
    public interface IProductService
    {
        List<Product> GetProductsByOrder(int id);
    }
}