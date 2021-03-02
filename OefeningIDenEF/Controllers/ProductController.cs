using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OefeningIDenEF.Interfaces;
using OefeningIDenEF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace OefeningIDenEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("many")]
        public ActionResult<List<Product>> GetProducts()
        {
            var products = _productService.GetProducts();
            return Ok(products);
        }

        [HttpGet("one")]
        public ActionResult<Product> GetProduct(string productName)
        {
            var product = _productService.GetProduct(productName);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpDelete]
        public ActionResult DeleteProductById(int productId)
        {
            _productService.DeleteProductById(productId);
            return Ok();
        }

        [HttpPost]
        public ActionResult AddProduct(Product product)
        {
            _productService.AddProduct(product);
            return Ok();
        }

        [HttpPut]
        public ActionResult<Product> UpdateProductById(int productId, Product productEditValues)
        {
            //var productToUpdate = _productService.UpdateProductById(productId);
            //productToUpdate.Name = productEditValues.Name;
            //productToUpdate.Price = productEditValues.Price;

            var updatedProduct = _productService.UpdateProductById(productId, productEditValues);
            return Ok(updatedProduct);
        }
    }
}
