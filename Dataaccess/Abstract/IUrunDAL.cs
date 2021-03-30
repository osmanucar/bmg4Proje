using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IUrunDAL : IRepository<Urun>
    {
        IEnumerable<Urun> GetPopularUrunler();
    }
}
