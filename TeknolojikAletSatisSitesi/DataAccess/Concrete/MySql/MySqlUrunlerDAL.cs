using DataAccess.Abstract;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.MySql
{
    public class MySqlUrunlerDAL : IUrunlerDAL
    {
        public void Create(Urunler entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Urunler entity)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Urunler> GetAll(Expression<Func<Urunler, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Urunler GetbyId(int id)
        {
            throw new NotImplementedException();
        }

        public Urunler GetOne(Expression<Func<Urunler, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Urunler> GetPopulerUrunler()
        {
            throw new NotImplementedException();
        }

        public void Update(Urunler entity)
        {
            throw new NotImplementedException();
        }
    }
}
