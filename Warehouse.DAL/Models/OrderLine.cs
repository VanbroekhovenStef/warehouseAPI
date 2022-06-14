using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.DAL.Models
{
    public class OrderLine
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int PackagingId { get; set; }

        public Order Order { get; set; }
        public Item Item { get; set; }
        public Packaging Packaging { get; set; }
    }
}
