using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EfCore
{
    public class EfCoreUrunlerDAL : EfCoreGenericRepository<Urunler, Context>, IUrunlerDAL
    {
        public IEnumerable<Urunler> GetPopulerUrunler()
        {
            throw new NotImplementedException();
        }
    }
}
