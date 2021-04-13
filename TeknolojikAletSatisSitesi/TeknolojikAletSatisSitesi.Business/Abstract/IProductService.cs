﻿using System;
using System.Collections.Generic;
using System.Text;
using TeknolojikAletSatisSitesi.Entities;

namespace TeknolojikAletSatisSitesi.Business.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);
        Product GetProductDetails(int id);
        List<Product> GetAll(); //Tüm productları çeker.
        List<Product> GetProductsByCategory(string category, int page, int pageSize);
        void Create(Product entity);
        void Update(Product entity);
        void Delete(Product entity);
        int GetCountByCategory(string category);
    }
}
