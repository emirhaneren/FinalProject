﻿using Business.Concreate;
using DataAccess.Concreate.EntityFramework;
using DataAccess.Concreate.InMemory;
using System;

namespace ConsoleUI
{
    //SOLİD
    //Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            // ProductTest();
            //CategoryTest();
            //ProductTest2();
        }

        private static void ProductTest2()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var product in productManager.GetByUnitPrice(50, 100))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
