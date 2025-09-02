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
    public class TablesController : ControllerBase
    {
        private readonly RestaurantContext _context;
        public TablesController(RestaurantContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Route("/api/Tables")]
        public ActionResult<List<Table>> Get()
        {
            return _context.Tables.ToList();
        }

        [HttpGet]
        [Route("/api/Tables/{id}")]
        public ActionResult<Table>Get(int id)
        {
            return _context.Tables.FirstOrDefault(x => x.Id == id);
        }
        [HttpPost]
        [Route("/api/Tables")]
        public IActionResult Post(Table table)
        {
            try
            {
                _context.Tables.Add(table);
                _context.SaveChanges();
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpDelete]
        [Route("/api/Tables")]
        public ActionResult Delete(int id)
        {
            try
            {
                _context.Remove(_context.Tables.FirstOrDefault(x => x.Id == id));
                _context.SaveChanges();
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

    }
}
