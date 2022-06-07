using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.DAL.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int TotalWeight { get; set; }
        public bool Confirm { get; set; }
        public bool InOut { get; set; }
        public int AddressId { get; set; }
        public int UserId { get; set; }
        public DateTime OrderPlaced { get; set; }
        public DateTime? OrderFulfilled { get; set; }


        [ForeignKey("AddressId")]
        public Address Address { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }
        public ICollection<OrderLine> OrderLines { get; set; }
    }
}
