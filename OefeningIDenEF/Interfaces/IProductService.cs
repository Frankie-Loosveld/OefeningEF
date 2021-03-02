using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OefeningIDenEF.Models;

namespace OefeningIDenEF.Interfaces
{
    public interface IProductService
    {
        //getproduct
        //getproduct
        //addproduct
        //deleteproduct
        //updateproduct

        Product GetProduct(string productName);

        List<Product> GetProducts();

        void AddProduct(Product product);

        void DeleteProductById(int productId);

        Product UpdateProductById(int productId, Product productToEdit);

    }
}
