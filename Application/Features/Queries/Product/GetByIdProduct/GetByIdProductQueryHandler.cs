using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repositories.Products;
using MediatR;

namespace Application.Features.Queries.Product.GetByIdProduct
{
    public class GetByIdProductQueryHandler : IRequestHandler<GetByIdProductQueryRequest, GetByIdProductQueryResponse>
    {
        private readonly IProductReadRepository _productReadRepository;
        public GetByIdProductQueryHandler(IProductReadRepository productReadRepository)
        {
            _productReadRepository = productReadRepository;
        }

        public async Task<GetByIdProductQueryResponse> Handle(GetByIdProductQueryRequest request, CancellationToken cancellationToken)
        {
            var product =  await _productReadRepository.GetByIdAsync(request.Id, false);
            return new()
            {
                Name = product.Name,
                Stock = product.Stock,
                Price = product.Price
            };
        }
    }
}