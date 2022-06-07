using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.DAL.Models
{
    public class Packaging
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Weight { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
