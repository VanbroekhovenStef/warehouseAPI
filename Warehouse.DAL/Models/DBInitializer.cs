using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse.DAL.Data;

namespace Warehouse.DAL.Models
{
    public class DBInitializer
    {
        public static void Initialize(WarehouseContext context)
        {
            context.Database.EnsureCreated();

            /*context.AddRange(
                new Country { Name = "Belgium", MaxWeight = 44000 },
                new Country { Name = "France", MaxWeight = 40000 },
                new Country { Name = "Germany", MaxWeight = 44000 }
                );

            Address address1 = new Address()
            {
                City = "Beringen",
                Street = "Industrieweg 158",
                CountryId = 1
            };

            Address address2 = new Address()
            {
                City = "Mol",
                Street = "Sluis 5",
                CountryId = 1
            };

            Address address3 = new Address()
            {
                City = "Neunkirchen",
                Street = "Bierstrasse 5",
                CountryId = 3
            };

            context.Add(address1);
            context.Add(address2);
            context.Add(address3);

            context.AddRange(
                new User { UserName = "Stef Vanbroekhoven", Email = "stef.vanbroekhoven@admin.com", Password = "Test", AddressId = 1 },
                new User { UserName = "Borealis", Email = "borealis@customer.com", Password = "Test", AddressId = 2 },
                new User { UserName = "Luc", Email = "luc@warehouse.com", Password = "Test", AddressId = 3 }
                );

            context.AddRange(
                new Item { Name = "FORMOLENE" },
                new Item { Name = "BORMED" }
                );

            Packaging packaging = new Packaging()
            {
                Type = "PL1375/25",
                Weight = 1375
            };
            Packaging packaging2 = new Packaging()
            {
                Type = "BB1000",
                Weight = 1000
            };

            context.Add(packaging);
            context.Add(packaging2);

            context.AddRange(
                new Product { ItemId = 1, UserId = 2, PackagingId = 1, AmountInStock = 25 },
                new Product { ItemId = 2, UserId = 2, PackagingId = 2, AmountInStock = 30 }
                );

            context.AddRange(
                new Order { UserId = 2, AddressId = 3, Confirm = false, InOut = false, OrderPlaced = DateTime.Now }
                );

            context.AddRange(
                new OrderLine { OrderId = 1, ProductId = 2, Amount = 20 }
                );
*/
            context.SaveChanges();
        }
    }
}
