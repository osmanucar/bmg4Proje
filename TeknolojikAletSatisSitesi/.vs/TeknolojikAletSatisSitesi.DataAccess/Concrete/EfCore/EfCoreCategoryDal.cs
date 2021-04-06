using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TeknolojikAletSatisSitesi.DataAccess.Abstract;
using TeknolojikAletSatisSitesi.Entities;

namespace TeknolojikAletSatisSitesi.DataAccess.Concrete.EfCore
{
    public class EfCoreCategoryDal : EfCoreGenericRepository<Category,ShopContext>, ICategoryDal
    {

    }
}
