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
    public class MenuController : ControllerBase
    {
        private readonly RestaurantContext _context;
        public MenuController(RestaurantContext context)
        {
            _context = context;
        }
        [HttpGet]
        public ActionResult<List<Menu>> Get()
        {
            try
            {
                return _context.Menus.ToList();
            }
            catch
            {
                return NotFound();
            }
        }
        [HttpGet("{id}")]
        public ActionResult<Menu>Get(int id)
        {
            try
            {
                var result = _context.Menus.FirstOrDefault(x => x.Id == id);
                if (result == null)
                    return NotFound("Data not found");
                else return result;
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpPost]
        public IActionResult Post(Menu menuItem)
        {
            try
            {
                _context.Menus.Add(menuItem);
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
                _context.Menus.Remove(_context.Menus.FirstOrDefault(x => x.Id == id));
                _context.SaveChanges();
                return Ok();
            }
            catch
            {
                return BadRequest("Invalid data, could not perform action");
            }
        }
        [HttpPut]
        public IActionResult Update(Menu menuItem)
        {
            try
            {
                _context.Menus.Update(menuItem);
                _context.SaveChanges();
                return Ok();
            }
            catch
            {
                return BadRequest("Invalid data, could not perform action");
            }
        }
    }
}
