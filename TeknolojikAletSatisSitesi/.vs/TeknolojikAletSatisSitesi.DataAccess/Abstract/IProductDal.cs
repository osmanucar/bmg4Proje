using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TeknolojikAletSatisSitesi.Entities;

namespace TeknolojikAletSatisSitesi.DataAccess.Abstract
{
    public interface IProductDal : IRepository<Product>
    { 
        IEnumerable<Product> GetPopularProducts();
    }
}
