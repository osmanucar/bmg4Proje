﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TeknolojikAletSatisSitesi.Business.Abstract;
using TeknolojikAletSatisSitesi.DataAccess.Abstract;
using TeknolojikAletSatisSitesi.Entities;

namespace TeknolojikAletSatisSitesi.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public bool Create(Product entity)
        {
            if (Validate(entity))
            {
                _productDal.Create(entity); //kayıt oluşturur
                return true;
            }
            return false;
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity); //kayıt siler
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll(); //tablodan bütün productları çeker
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id); // tablodan bir kayıt çeker
        }

        public Product GetByIdWithCategories(int id)
        {
            return _productDal.GetByIdWithCategories(id);
        }

        public int GetCountByCategory(string category)
        {
            return _productDal.GetCountByCategory(category);
        }

        public Product GetProductDetails(int id)
        {
            return _productDal.GetProductDetails(id);
        }

        public List<Product> GetProductsByCategory(string category, int page, int pageSize)
        {
            return _productDal.GetProductsByCategory(category, page, pageSize);
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity); //kaydı günceller
        }

        public void Update(Product entity, int[] categoryIds)
        {
            _productDal.Update(entity, categoryIds);
        }

        public string ErrorMessage { get; set; }
        public bool Validate(Product entity)
        {
            var isValid = true;

            if (string.IsNullOrEmpty(entity.Name))
            {
                ErrorMessage += "Ürün ismi girmelisiniz";
                isValid = false;
            }
            return isValid;

        }
    }
}
