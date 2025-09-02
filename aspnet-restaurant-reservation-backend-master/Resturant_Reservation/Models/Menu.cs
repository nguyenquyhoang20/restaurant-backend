using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Resturant_Reservation.Models
{
    public class Menu
    {
      [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }

    }
}
