using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Resturant_Reservation.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string FoodItems { get; set; }
        public  DateTime BookTimeStart { get; set; }
        public DateTime BookTimeEnd { get; set; }
        public string TableNumber { get; set; }
        public float TotalPrice { get; set; }
    }
}
