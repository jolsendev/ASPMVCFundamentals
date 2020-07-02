using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemeoryRestaurantData : IRestaurantData
    {
        List<Resturant> resturants;
        public InMemeoryRestaurantData()
        {
            resturants = new List<Resturant>()
            {
                new Resturant  { Id = 1, name = "Jamie Restaurant", Cuisine = CuisineType.French },
                new Resturant  { Id = 2, name = "Data Restaurant",  Cuisine = CuisineType.Indian },
                new Resturant  { Id = 3, name = "Dave Restaurant", Cuisine =  CuisineType.Indian },
                new Resturant  { Id = 4, name = "Jon Restaurant",  Cuisine = CuisineType.None }
            };
        }
        public IEnumerable<Resturant> GetAll()
        {
            return resturants.OrderBy(r => r.name);
        }
    }
}
