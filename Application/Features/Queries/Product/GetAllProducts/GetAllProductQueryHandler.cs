using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repositories.Products;
using MediatR;

namespace Application.Features.Queries.Product.GetAllProducts
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQueryRequest, GetAllProductQueryResponse>
    {
        readonly IProductReadRepository _productReadRepository;
        public GetAllProductQueryHandler(IProductReadRepository productReadRepository)
        {
            _productReadRepository = productReadRepository;
        }

        public async Task<GetAllProductQueryResponse> Handle(GetAllProductQueryRequest request, CancellationToken cancellationToken)
        {
            var totalCount = _productReadRepository.GetAll(false).Count();

            var products = _productReadRepository.GetAll(false).Select(p => new 
            {
                p.Id,
                p.Name,
                p.Stock,
                p.Price,
                p.CreatedDate,
                p.UpdatedDate
            }).Skip(request.Page * request.Size).Take(request.Size).ToList();

            return new() 
            {
                Products = products,
                TotalCount = totalCount
            };
        }
    }
}