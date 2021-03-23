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
        private IUrunlerDAL _urunlerDAL;

        public UrunManager(IUrunlerDAL urunlerDAL)
        {
            _urunlerDAL = urunlerDAL;
        }

        public void Create(Urunler entity)
        {
            _urunlerDAL.Create(entity);
        }

        public void Delete(Urunler entity)
        {
            _urunlerDAL.Delete(entity);
        }

        public List<Urunler> GetAll()
        {
            return _urunlerDAL.GetAll().ToList(); // Bütün ürünleri çeker
        }

        public Urunler GetById(int id)
        {
            return _urunlerDAL.GetbyId(id);
        }

        public void Update(Urunler entity)
        {
            _urunlerDAL.Update(entity);
        }
    }
}
