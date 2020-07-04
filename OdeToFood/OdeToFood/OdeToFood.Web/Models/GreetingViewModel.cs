using OdeToFood.Data.Models;
using OdeToFood.Web.API;
using System.Collections;
using System.Collections.Generic;

namespace OdeToFood.Web.Models
{
    public class GreetingViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string Message { get; set; }
        public string  Name { get; set; }

    }
}