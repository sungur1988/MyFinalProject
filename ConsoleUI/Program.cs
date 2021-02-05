using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            //productManager.Add(new Product { CategoryId=2,ProductName="Cihan",UnitPrice=1000,UnitsInStock=1 });
            
            productManager.Delete(new Product {ProductId=78, CategoryId = 2, ProductName = "Cihan", UnitPrice = 1000, UnitsInStock = 1 });
            foreach (var item in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(item.ProductId);
            }

            Console.WriteLine("Hello World!");
        }
    }
}
