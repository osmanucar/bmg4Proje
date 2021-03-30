using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.Memory
{
    public class MemoryUrunDAL : IUrunDAL
    {
        public void Create(Urun entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Urun entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Urun> GetAll(Expression<Func<Urun, bool>> filter = null)
        {
            var urunler = new List<Urun>()
            {
                new Urun() { Id=1, Ad="Samsung S6", ResimUrl="1.jpg", Fiyat=1000},
                new Urun() { Id=2, Ad="Samsung S7", ResimUrl="2.jpg", Fiyat=2000},
                new Urun() { Id=3, Ad="Samsung S8", ResimUrl="3.jpg", Fiyat=3000}
            };
            return urunler;
        }

        public Urun GetbyId(int id)
        {
            throw new NotImplementedException();
        }

        public Urun GetOne(Expression<Func<Urun, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Urun> GetPopularUrunler()
        {
            throw new NotImplementedException();
        }

        public void Update(Urun entity)
        {
            throw new NotImplementedException();
        }
    }
}
