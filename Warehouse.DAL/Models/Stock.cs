using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.DAL.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int PackagingId { get; set; }


        [ForeignKey("ProductId")]
        public Product Product { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        [ForeignKey("PackagingId")]
        public Packaging Packaging { get; set; }
        public ICollection<OrderLine> OrderLines { get; set; }
    }
}
