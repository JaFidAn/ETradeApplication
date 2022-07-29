using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.RequestParameters;
using MediatR;

namespace Application.Features.Queries.Product.GetAllProducts
{
    public class GetAllProductQueryRequest :IRequest<GetAllProductQueryResponse>
    {
        //public Pagination Pagination { get; set; }
        public int Page { get; set; } = 0;
        public int Size { get; set; } = 5;
    }
}