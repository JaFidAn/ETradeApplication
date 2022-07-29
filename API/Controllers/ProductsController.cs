using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Abstraction;
using Application.Features.Commands.Product.CreateProduct;
using Application.Features.Queries.Product.GetAllProducts;
using Application.Features.Queries.Product.GetByIdProduct;
using Application.Repositories.Products;
using Application.RequestParameters;
using Application.ViewModels.Products;
using Domain.Entitites;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductReadRepository _productReadRepository;
        private readonly IProductWriteRepository _productWriteRepository;
        private readonly IMediator _mediator;
        public ProductsController(IProductReadRepository productReadRepository, IProductWriteRepository productWriteRepository, IMediator mediator = null)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]GetAllProductQueryRequest getAllProductQueryRequest)
        {
            GetAllProductQueryResponse response = await _mediator.Send(getAllProductQueryRequest);
            return Ok(response);              
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute]GetByIdProductQueryRequest getByIdProductQueryRequest)
        {
            GetByIdProductQueryResponse response = await _mediator.Send(getByIdProductQueryRequest);
            return Ok(response);  
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductCommandRequest createProductCommandRequest) 
        {
            await _mediator.Send(createProductCommandRequest);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(VM_UpdateProduct model) 
        {
            Product product = await _productReadRepository.GetByIdAsync(model.Id);
            product.Name = model.Name;
            product.Stock = model.Stock;
            product.Price = model.Price;
            await _productWriteRepository.SaveAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            await _productWriteRepository.RemoveAsync(id);
            await _productWriteRepository.SaveAsync();
            return Ok();
        }
    }
}