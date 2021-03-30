using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUrunHizmet
    {
        Urun GetById(int id);
        List<Urun> GetAll(); // bütün ürünleri getirecek bir metot
        void Create(Urun entity);
        void Update(Urun entity);
        void Delete(Urun entity);
    }
}
