using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.DAL.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
        public ICollection<ProductPackaging> ProductPackagings { get; set; }
        public ICollection<Stock> Stocks { get; set; }
    }
}
