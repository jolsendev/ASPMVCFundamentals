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
                new Resturant  { Id = 1, Name = "Jamie Restaurant", Cuisine = CuisineType.French },
                new Resturant  { Id = 2, Name = "Data Restaurant",  Cuisine = CuisineType.Indian },
                new Resturant  { Id = 3, Name = "Dave Restaurant", Cuisine =  CuisineType.Indian },
                new Resturant  { Id = 4, Name = "Jon Restaurant",  Cuisine = CuisineType.None }
            };
        }

        public Resturant Get(int id)
        {
            return resturants.FirstOrDefault(q => q.Id == id);
        }

        public IEnumerable<Resturant> GetAll()
        {
            return resturants.OrderBy(r => r.Name);
        }
    }
}
