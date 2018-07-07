using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrunchLouisvilleCS.Models
{
    public class Restaurants
    {
        public List<Restaurant> restaurants { get; set; }


        public Restaurants(List<Restaurant> eateries)
        {
            restaurants = eateries;

        }
    }
  
}