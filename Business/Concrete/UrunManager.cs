using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.EfCore;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class UrunManager : IUrunHizmet
    {
        private IUrunDAL _urunDAL;

        public UrunManager(IUrunDAL urunDAL)
        {
            _urunDAL = urunDAL;
        }

        public void Create(Urun entity)
        {
            _urunDAL.Create(entity);
        }

        public void Delete(Urun entity)
        {
            _urunDAL.Delete(entity);
        }

        public List<Urun> GetAll()
        {
            return _urunDAL.GetAll().ToList();
        }

        public Urun GetById(int id)
        {
            return _urunDAL.GetbyId(id);
        }

        public void Update(Urun entity)
        {
            _urunDAL.Update(entity);
        }
    }
}
