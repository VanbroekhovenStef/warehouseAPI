using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.DAL.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int AddressId { get; set; }
        public int RoleId { get; set; }


        [ForeignKey("AddressId")]
        public Address Address { get; set; }
        [ForeignKey("RoleId")]
        public Role Role { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Stock> Stocks { get; set; }
        public ICollection<Product> Products { get; set; }
        [NotMapped]
        public string Token { get; set; }
    }
}
