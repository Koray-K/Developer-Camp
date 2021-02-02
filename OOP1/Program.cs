using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Mobilya";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;


            Product product2 = new Product {Id = 1, CategoryId = 5, ProductName = "Kalem", UnitsInStock = 10, UnitPrice = 35 };

            //PascalCase   //camelCase
            //CaSe SeNSiTiVe
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);


        }
    }
}
