using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.DAL.Models
{
    public class Product
    {
        public int Id { get; set; } 
        public int AmountInStock { get; set; }
        public int ItemId { get; set; }
        public int UserId { get; set; }
        public int PackagingId { get; set; }


        public Item Item { get; set; }
        public User User { get; set; }
        public Packaging Packaging { get; set; }
        public ICollection<OrderLine> OrderLines { get; set; }
    }
}
