using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Resturant_Reservation.Models
{
    public class Table
    {
        [Key]
        public int Id { get; set; }
        public string TableNumber { get; set; }
        public string Type { get; set; }
    }
}
