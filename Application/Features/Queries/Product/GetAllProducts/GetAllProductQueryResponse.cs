using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.Features.Queries.Product.GetAllProducts
{
    public class GetAllProductQueryResponse
    {
        public int TotalCount { get; set; }  
        public object Products { get; set; } 
    }
}