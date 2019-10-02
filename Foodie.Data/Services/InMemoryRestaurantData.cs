using System;
using System.Collections.Generic;
using System.Linq;
using Foodie.Data.Models;

namespace Foodie.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        private List<Restaurant> restaurants;

        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Scott's Pizza", Cuisine = CuisineType.Italian },
                new Restaurant { Id = 2, Name = "Some French Name", Cuisine = CuisineType.French },
                new Restaurant { Id = 3, Name = "Mango Grove", Cuisine = CuisineType.Indian}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }
}