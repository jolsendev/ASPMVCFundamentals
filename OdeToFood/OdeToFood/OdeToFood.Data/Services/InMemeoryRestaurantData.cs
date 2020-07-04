using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemeoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemeoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant  { Id = 1, Name = "Jamie Restaurant", Cuisine = CuisineType.French },
                new Restaurant  { Id = 2, Name = "Data Restaurant",  Cuisine = CuisineType.Indian },
                new Restaurant  { Id = 3, Name = "Dave Restaurant", Cuisine =  CuisineType.Indian },
                new Restaurant  { Id = 4, Name = "Jon Restaurant",  Cuisine = CuisineType.None }
            };
        }

        public void Add(Restaurant restaurant)
        {
            this.restaurants.Add(restaurant);
            restaurant.Id = restaurants.Max(r => r.Id) + 1;
        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(q => q.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }

        public void Update(Restaurant resturant)
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
