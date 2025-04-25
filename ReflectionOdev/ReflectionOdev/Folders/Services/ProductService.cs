using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionOdev.Services
{
    public class ProductService
    {
        public void AddProduct(string productName, string description, decimal price)
        {
            // Product ekleme işlemleri
            Console.WriteLine($"Product added: {productName}, Description: {description}, Price: {price}");
        }
    }
}
