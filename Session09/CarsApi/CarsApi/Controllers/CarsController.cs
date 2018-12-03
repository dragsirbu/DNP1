using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarsApi.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarsApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly CarContext _context;

        public CarsController(CarContext context)
        {
            _context = context;
        }
        [HttpGet]
        [Produces("application/json")]
        public ActionResult<List<Car>> GetAll()
        {
            return _context.Cars.ToList();
        }

        [HttpGet("{id:int}", Name = "GetCar")]
        public ActionResult<Car> GetById(int id)
        {
            var car = _context.Cars.Find(id);

            if (car == null)
                return NotFound();

            return car;
        }

        [HttpPost]
        public IActionResult Create([FromBody] Car car)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _context.Cars.Add(car);
            _context.SaveChanges();

            return CreatedAtRoute("GetCar", new { id = car.Id }, car);
        }

        [HttpPut("{id:int}")]
        public IActionResult Update(int id, [FromBody]Car updatedCar)
        {
            var car = _context.Cars.Find(id);

            if (car == null)
                return NotFound();

            car.Manufacturer = updatedCar.Manufacturer;
            car.Model = updatedCar.Model;
            car.Color = updatedCar.Color;

            _context.Cars.Update(car);
            _context.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            var car = _context.Cars.Find(id);

            if (car == null)
                return NotFound();

            _context.Cars.Remove(car);
            _context.SaveChanges();

            return NoContent();
        }
    }

    
}