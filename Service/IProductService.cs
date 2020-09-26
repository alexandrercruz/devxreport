using System.Collections.Generic;
using xReport.Data;

namespace xReport.Service
{
    public interface IProductService
    {
        List<Product> GetProductsByOrder(int id);
    }
}