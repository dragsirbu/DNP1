using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarsApi.Model
{
    public class Car
    {
        public int Id { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        [MinLength(3)]
        public string Color { get; set; }

        public override string ToString()
        {
            return $"Manufacturer: {Manufacturer}, Model: {Model}, Color: {Color}";
        }
    }
}
