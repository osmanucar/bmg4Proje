using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IKategoriHizmet
    {
        List<Kategori> GetAll();
        void Create(Kategori entity);
        void Update(Kategori entity);
        void Delete(Kategori entity);
    }
}
