using System.Collections.Generic;
using System.Linq;
using xReport.Data;

namespace xReport.Service
{
    public class ProductService : IProductService
    {
        public List<Product> GetProductsByOrder(int id)
        {
            NorthwindEntities nw = new NorthwindEntities();

            var q = from p in nw.Products
                    join o in nw.Order_Details on p.ProductID equals o.ProductID
                    where o.OrderID == id
                    select p;

            return q.ToList();
        }
    }
}