using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework.Repository;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            //DTO = Data Transformation Object
            // Ara yüzün içine kod yazılmaması gerekiyor
            ProductTest();
            //IoC
            //CategoryTest();
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
            var result = productManager.GetProductDetails();
            if (result.Success == true)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine($"{product.ProductName}/{product.CategoryName}");
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
    }
}
