using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Abstraction;
using Application.Repositories.Products;
using Domain.Entitites;
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
        public async Task Get()
        {
            _productReadRepository.GetAll();
           
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
            return Ok(product);
        }

        [HttpPost]
        public async Task Add() 
        {
            await _productWriteRepository.AddAsync(new() {Name = "New Product test", Price = 15.00f, Stock = 10});
            await _productWriteRepository.SaveAsync();
        }
    }
}
