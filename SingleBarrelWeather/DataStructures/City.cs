using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataStructures
{
    public class City
    {
        public string CityName { get; set; }
        public int Id { get; set; }
        public Coordinate Coord { get; set; }
        public string Country { get; set; }
        public Sun Sun { get; set; }
    }
}
