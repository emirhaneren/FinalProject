using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreate
{
    public class ProductManager : IProductService
    {
        //Injection
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
       
        public List<Product> GetAll()
        {
            //İş Kodları
            //Koşullar
            return _productDal.GetAll();
        }
    }
}
