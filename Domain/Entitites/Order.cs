using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entitites.Common;

namespace Domain.Entitites
{
    public class Order : BaseEntity
    {
        public string Description { get; set; }

        public string Address { get; set; }

        public ICollection<Product> Products { get; set; }

        public Customer Customer { get; set; }
    }
}
