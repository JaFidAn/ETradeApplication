using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Abstraction;
using Application.Repositories.Products;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;
        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async void Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new() { Id = Guid.NewGuid(), Name = "Product 1", Price = 100, CreatedDate = DateTime.Now, Stock = 10},
                new() { Id = Guid.NewGuid(), Name = "Product 2", Price = 200, CreatedDate = DateTime.Now, Stock = 20},
                new() { Id = Guid.NewGuid(), Name = "Product 3", Price = 300, CreatedDate = DateTime.Now, Stock = 30},
                new() { Id = Guid.NewGuid(), Name = "Product 4", Price = 400, CreatedDate = DateTime.Now, Stock = 40},
                new() { Id = Guid.NewGuid(), Name = "Product 5", Price = 500, CreatedDate = DateTime.Now, Stock = 50}
            });
            var count = await _productWriteRepository.SaveAsync();
        }
    }
}
