using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EfCore
{
    public class EfCoreKategoriDAL : EfCoreGenericRepository<Kategori, Context>, IKategoriDAL
    {

    }
}
