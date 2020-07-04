using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemeoryRestaurantData : IRestaurantData
    {
        List<Resturant> restaurants;
        public InMemeoryRestaurantData()
        {
            restaurants = new List<Resturant>()
            {
                new Resturant  { Id = 1, Name = "Jamie Restaurant", Cuisine = CuisineType.French },
                new Resturant  { Id = 2, Name = "Data Restaurant",  Cuisine = CuisineType.Indian },
                new Resturant  { Id = 3, Name = "Dave Restaurant", Cuisine =  CuisineType.Indian },
                new Resturant  { Id = 4, Name = "Jon Restaurant",  Cuisine = CuisineType.None }
            };
        }

        public void Add(Resturant restaurant)
        {
            this.restaurants.Add(restaurant);
            restaurant.Id = restaurants.Max(r => r.Id) + 1;
        }

        public Resturant Get(int id)
        {
            return restaurants.FirstOrDefault(q => q.Id == id);
        }

        public IEnumerable<Resturant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }

        public void Update(Resturant resturant)
        {
            var existing = Get(resturant.Id);
            if (existing != null)
            {
                existing.Name = resturant.Name;
                existing.Cuisine = resturant.Cuisine;
                
            }
        }
    }
}
