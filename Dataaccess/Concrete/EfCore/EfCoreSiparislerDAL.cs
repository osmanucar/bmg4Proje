using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EfCore
{
    public class EfCoreSiparisDAL : EfCoreGenericRepository<Siparis, Context>, ISiparisDAL
    {
    }
}
