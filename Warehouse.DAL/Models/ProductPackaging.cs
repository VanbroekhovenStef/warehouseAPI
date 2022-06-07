using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.DAL.Models
{
    public class ProductPackaging
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int PackagingId { get; set; }

        public Product Product { get; set; }
        public Packaging Packaging { get; set; }
    }
}
