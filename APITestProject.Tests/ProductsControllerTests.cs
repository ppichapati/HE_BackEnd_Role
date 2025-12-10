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
            // Arrange
            _repository.Reset();
            
            // Act
            var result = _controller.GetProducts();
            
            // Assert
            var actionResult = Assert.IsType<ActionResult<IEnumerable<Product>>>(result);
            var products = Assert.IsAssignableFrom<IEnumerable<Product>>(actionResult.Value);
            Assert.Empty(products);
        }

        // Ensure that the GetProduct method returns a NotFoundResult when the product does not exist.
        [Fact]
        public void GetProduct_ReturnsNotFoundResult()
        {
            // Arrange
            _repository.Reset();
            
            // Act
            var result = _controller.GetProduct(999);
            
            // Assert
            Assert.IsType<NotFoundResult>(result.Result);
        }

        // Ensure that the GetProduct method returns the correct product when it exists.
        [Fact]
        public void GetProduct_ReturnsProduct()
        {
            // Arrange
            _repository.Reset();
            var product = new Product { Name = "Test Product", Price = 10.0M };
            _controller.PostProduct(product);
            
            // Act
            var result = _controller.GetProduct(product.Id);
            
            // Assert
            Assert.NotNull(result.Value);
            Assert.Equal(product.Id, result.Value.Id);
            Assert.Equal(product.Name, result.Value.Name);
            Assert.Equal(product.Price, result.Value.Price);
        }

        // Ensure that the PostProduct method returns a CreatedAtActionResult when a product is successfully created.
        [Fact]
        public void PostProduct_ReturnsCreatedAtActionResult()
        {
            // Arrange
            _repository.Reset();
            var product = new Product { Name = "New Product", Price = 25.0M };
            
            // Act
            var result = _controller.PostProduct(product);
            
            // Assert
            var createdResult = Assert.IsType<CreatedAtActionResult>(result.Result);
            var returnedProduct = Assert.IsType<Product>(createdResult.Value);
            Assert.Equal(product.Name, returnedProduct.Name);
            Assert.Equal(product.Price, returnedProduct.Price);
        }

        // Ensure that the PutProduct method returns a NoContentResult when a product is successfully updated.
        [Fact]
        public void PutProduct_ReturnsNoContentResult()
        {
            // Arrange
            _repository.Reset();
            var product = new Product { Name = "Original Product", Price = 15.0M };
            _controller.PostProduct(product);
            
            product.Name = "Updated Product";
            product.Price = 20.0M;
            
            // Act
            var result = _controller.PutProduct(product.Id, product);
            
            // Assert
            Assert.IsType<NoContentResult>(result);
        }

        // Ensure that the PutProduct method returns a NotFoundResult when the product to be updated does not exist.
        [Fact]
        public void PutProduct_ReturnsNotFoundResult()
        {
            // Arrange
            _repository.Reset();
            var product = new Product { Id = 999, Name = "Non-existent Product", Price = 30.0M };
            
            // Act
            var result = _controller.PutProduct(product.Id, product);
            
            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        // Ensure that the DeleteProduct method returns a NoContentResult when a product is successfully deleted.
        [Fact]
        public void DeleteProduct_ReturnsNoContentResult()
        {
            // Arrange
            _repository.Reset();
            var product = new Product { Name = "Product to Delete", Price = 12.0M };
            _controller.PostProduct(product);
            
            // Act
            var result = _controller.DeleteProduct(product.Id);
            
            // Assert
            Assert.IsType<NoContentResult>(result);
        }

        // Ensure that the DeleteProduct method returns a NotFoundResult when the product to be deleted does not exist.
        [Fact]
        public void DeleteProduct_ReturnsNotFoundResult()
        {
            // Arrange
            _repository.Reset();
            
            // Act
            var result = _controller.DeleteProduct(999);
            
            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        // Deliberate compile-time error
        [Fact]
        public void DeliberateCompileTimeError()
        {
            _repository.Reset();
            var product = new Product { Name = "Test Product", Price = 10.0M };
            _controller.PostProduct(product);

            var result = _controller.GetProduct(product.Id);
            Assert.NotNull(result.Value);
            Assert.IsType<Product>(result.Value);
        }
    }
}