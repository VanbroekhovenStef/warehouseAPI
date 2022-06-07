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
        public int TotalWeight { get; set; }
        public int OrderId { get; set; }
        public int StockId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }
        [ForeignKey("StockId")]
        public Stock Stock { get; set; }
    }
}
