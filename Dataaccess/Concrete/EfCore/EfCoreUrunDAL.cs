using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EfCore
{
    public class EfCoreUrunDAL : EfCoreGenericRepository<Urun, Context>, IUrunDAL
    {
        public IEnumerable<Urun> GetPopularUrunler()
        {
            throw new NotImplementedException();
        }
    }
}
