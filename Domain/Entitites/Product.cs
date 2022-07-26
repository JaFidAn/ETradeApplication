using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entitites.Common;

namespace Domain.Entitites
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public int Stock { get; set; }

        public float Price { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
