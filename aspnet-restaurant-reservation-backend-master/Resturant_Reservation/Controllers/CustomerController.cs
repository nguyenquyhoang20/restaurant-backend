using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Resturant_Reservation.Data;
using Resturant_Reservation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resturant_Reservation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly RestaurantContext _context;
        public CustomerController(RestaurantContext context)
        {
            _context = context;
        }
        [HttpGet]
        //route: /api/customer
        public ActionResult<List<Customer>> Get()
        {
            try
            {
                return _context.Customers.ToList();
            }
            catch
            {
                return BadRequest("Cannot fetch data");
            }
        }
        [HttpGet("{id}")]
        //route: /api/customer/id
        public ActionResult<Customer>Get(int id)
        {
            try
            {
                return _context.Customers.FirstOrDefault(x => x.Id == id);
            }
            catch
            {
                return BadRequest("Cannot fetch data");
            }
        }
        [HttpPost]
        public IActionResult Post(Customer customer)
        {
            try
            {
                _context.Customers.Add(customer);
                _context.SaveChanges();
                return Ok("Data saved");
            }
            catch
            {
                return BadRequest("Could not insert data");
            }
        }
        [HttpPut]
        public IActionResult Put(Customer customer)
        {
            try
            {
                _context.Customers.Update(customer);
                _context.SaveChanges();
                return Ok();
            }
            catch
            {
                return BadRequest("Invalid data, could not perform action");
            }
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                _context.Customers.Remove(_context.Customers.FirstOrDefault(x => x.Id == id));
                _context.SaveChanges();
                return Ok("Deleted Successfully");
            }
            catch
            {
                return BadRequest("Could not delete");
            }
        }
    }
}
