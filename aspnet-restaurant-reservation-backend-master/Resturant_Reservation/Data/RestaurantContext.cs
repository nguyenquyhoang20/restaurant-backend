using Microsoft.EntityFrameworkCore;
using Resturant_Reservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resturant_Reservation.Data
{
    public class RestaurantContext:DbContext
    {
        public RestaurantContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Table>Tables { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
