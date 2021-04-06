using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TeknolojikAletSatisSitesi.DataAccess.Abstract;
using TeknolojikAletSatisSitesi.Entities;

namespace TeknolojikAletSatisSitesi.DataAccess.Concrete.EfCore
{
    public class EfCoreProductDal : EfCoreGenericRepository<Product, ShopContext>, IProductDal
    {
        public IEnumerable<Product> GetPopularProducts()
        {
            throw new NotImplementedException();
        }
    }
}
