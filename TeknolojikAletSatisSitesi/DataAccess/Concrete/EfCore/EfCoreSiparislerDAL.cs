using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EfCore
{
    public class EfCoreSiparislerDAL:EfCoreGenericRepository<Siparisler,Context>,ISiparislerDAL
    {

    }
}
