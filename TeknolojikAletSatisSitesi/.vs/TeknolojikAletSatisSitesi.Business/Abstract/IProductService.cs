using System;
using System.Collections.Generic;
using System.Text;
using TeknolojikAletSatisSitesi.Entities;

namespace TeknolojikAletSatisSitesi.Business.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        List<Product> GetAll(); //Tüm productları çeker.

        List<Product> GetPopularProducts();
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
    }
}
