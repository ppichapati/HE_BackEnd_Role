using Microsoft.AspNetCore.Mvc;
using APITestProject.Models;
using APITestProject.Repositories;
using System.Collections.Generic;

namespace APITestProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductRepository _repository;

        public ProductsController(ProductRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return _repository.GetAll();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = _repository.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return product;
        }

        // POST: api/Products
        [HttpPost]
        public ActionResult<Product> PostProduct(Product product)
        {
            _repository.Add(product);
            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public IActionResult PutProduct(int id, Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            var existingProduct = _repository.GetById(id);
            if (existingProduct == null)
            {
                return NotFound();
            }

            _repository.Update(product);
            return NoContent();
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var product = _repository.GetById(id);
            if (product == null)
            {
                return NotFound();
            }

            _repository.Delete(id);
            return NoContent();
        }
    }
}
//using Microsoft.AspNetCore.Mvc;
//using APITestProject.Models;
//using APITestProject.Repositories;
//using System.Collections.Generic;

//namespace APITestProject.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProductsController : ControllerBase
//    {
//        private readonly ProductRepository _repository;

//        public ProductsController()
//        {
//            _repository = new ProductRepository();
//        }

//        // GET: api/Products
//        [HttpGet]
//        public ActionResult<IEnumerable<Product>> GetProducts()
//        {
//            return _repository.GetAll();
//        }

//        // GET: api/Products/5
//        [HttpGet("{id}")]
//        public ActionResult<Product> GetProduct(int id)
//        {
//            var product = _repository.GetById(id);
//            if (product == null)
//            {
//                return NotFound();
//            }
//            return product;
//        }

//        // POST: api/Products
//        [HttpPost]
//        public ActionResult<Product> PostProduct(Product product)
//        {
//            _repository.Add(product);
//            return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
//        }

//        // PUT: api/Products/5
//        [HttpPut("{id}")]
//        public IActionResult PutProduct(int id, Product product)
//        {
//            if (id != product.Id)
//            {
//                return BadRequest();
//            }

//            var existingProduct = _repository.GetById(id);
//            if (existingProduct == null)
//            {
//                return NotFound();
//            }

//            _repository.Update(product);
//            return NoContent();
//        }

//        // DELETE: api/Products/5
//        [HttpDelete("{id}")]
//        public IActionResult DeleteProduct(int id)
//        {
//            var product = _repository.GetById(id);
//            if (product == null)
//            {
//                return NotFound();
//            }

//            _repository.Delete(id);
//            return NoContent();
//        }
//    }
//}