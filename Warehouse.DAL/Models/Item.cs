using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.DAL.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<OrderLine> OrderLines { get; set; }
    }
}
