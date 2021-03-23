using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IKategoriHizmet
    {
        List<Kategoriler> GetAll();

        void Create(Kategoriler entity);

        void Update(Kategoriler entity);

        void Delete(Kategoriler entity);
    }
}
