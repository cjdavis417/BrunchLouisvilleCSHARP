using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrunchLouisvilleCS.Models
{

    public class Restaurant
    {
        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public List<Review> Reviews { get; set; }
        public string LogoPath { get; set; }


        public Restaurant(string name, string type, List<Review> reviews, string logoPath)
        {
            Name = name;
            Type = type;
            Reviews = reviews;
            LogoPath = logoPath;
        }

        
    }
}