using APITestProject.Controllers;
using APITestProject.Models;
using APITestProject.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Xunit;

namespace APITestProject.Tests
{
    public class ProductsControllerTests
    {
        private readonly ProductsController _controller;
        private readonly ProductRepository _repository;

        public ProductsControllerTests()
        {
            _repository = new ProductRepository();
            _controller = new ProductsController(_repository);
        }

        [Fact]
        public void GetProducts_ReturnsOkResult()
        {
            _repository.Reset();
            var result = _controller.GetProducts();
            Assert.IsType<ActionResult<IEnumerable<Product>>>(result);
        }

        // Ensure that the GetProducts method returns an empty list when there are no products.
        [Fact]
        public void GetProducts_WhenEmpty_ReturnsEmptyList()
        {
            // Implement this test case
        }

        // Ensure that the GetProduct method returns a NotFoundResult when the product does not exist.
        [Fact]
        public void GetProduct_ReturnsNotFoundResult()
        {
            // Implement this test case
        }

        // Ensure that the GetProduct method returns the correct product when it exists.
        [Fact]
        public void GetProduct_ReturnsProduct()
        {
            // Implement this test case
        }

        // Ensure that the PostProduct method returns a CreatedAtActionResult when a product is successfully created.
        [Fact]
        public void PostProduct_ReturnsCreatedAtActionResult()
        {
            // Implement this test case
        }

        // Ensure that the PutProduct method returns a NoContentResult when a product is successfully updated.
        [Fact]
        public void PutProduct_ReturnsNoContentResult()
        {
            // Implement this test case
        }

        // Ensure that the PutProduct method returns a NotFoundResult when the product to be updated does not exist.
        [Fact]
        public void PutProduct_ReturnsNotFoundResult()
        {
            // Implement this test case
        }

        // Ensure that the DeleteProduct method returns a NoContentResult when a product is successfully deleted.
        [Fact]
        public void DeleteProduct_ReturnsNoContentResult()
        {
            // Implement this test case
        }

        // Ensure that the DeleteProduct method returns a NotFoundResult when the product to be deleted does not exist.
        [Fact]
        public void DeleteProduct_ReturnsNotFoundResult()
        {
            // Implement this test case
        }

        // Deliberate compile-time error
        [Fact]
        public void DeliberateCompileTimeError()
        {
            var product = new Product { Id = 1, Name = "Test Product", Price = 10.0M };
            _controller.PostProduct(product);

            var result = _controller.GetProduct(1);
            Assert.IsType<Product>(result.Value);
        }
    }
}