﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Warehouse.DAL.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public int CountryId { get; set; }

        [ForeignKey("CountryId")]
        public Country Country { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
