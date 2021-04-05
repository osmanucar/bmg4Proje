using System;
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
        public void Create(Product entity)
        {
            _productDal.Create(entity); //kayıt oluşturur
        }

        public void Delete(Product entity)
        {
            _productDal.Delete(entity); //kayıt siler
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll().ToList(); //tablodan bütün productları çeker
        }

        public Product GetById(int id)
        {
            return _productDal.GetById(id); // tablodan bir kayıt çeker
        }

        public void Update(Product entity)
        {
            _productDal.Update(entity); //kaydı günceller
        }
    }
}
