using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.DAL.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxWeight { get; set; }

        public ICollection<Address> Addresses { get; set; }
    }
}
