using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace OdeToFood.Data.Models
{
    public class Resturant
    {
        public int Id { get; set; }
        public string name { get; set; }
        public CuisineType Cuisine { get; set; }

    }
}
