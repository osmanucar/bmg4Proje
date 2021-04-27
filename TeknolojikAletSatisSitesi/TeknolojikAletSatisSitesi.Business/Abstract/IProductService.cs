using System;
using System.Collections.Generic;
using System.Text;
using TeknolojikAletSatisSitesi.Entities;

namespace TeknolojikAletSatisSitesi.Business.Abstract
{
    public interface IProductService:IValidator<Product>
    {
        Product GetById(int id);
        Product GetProductDetails(int id);
        Product GetByIdWithCategories(int id);
        List<Product> GetAll(); //Tüm productları çeker.
        List<Product> GetProductsByCategory(string category, int page, int pageSize);
        int GetCountByCategory(string category);
        bool Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity); 
        void Update(Product entity, int[] categoryIds);
    }
}
