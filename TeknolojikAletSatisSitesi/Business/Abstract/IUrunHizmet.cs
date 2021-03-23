using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUrunHizmet
    {
        Urunler GetById(int id);

        List<Urunler> GetAll(); // bütün ürünleri getirecek bir metot

        void Create(Urunler entity);

        void Update(Urunler entity);

        void Delete(Urunler entity); 
        
    }
}
