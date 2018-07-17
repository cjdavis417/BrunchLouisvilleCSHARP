using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrunchLouisvilleCS.Models
{

    public class Restaurant
    {
        internal int restID;

        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string LogoPath { get; set; }

        public ICollection<Review> Reviews { get; set; }

        public Restaurant()
        {
            Reviews = new List<Review>();
        }

        //public Restaurant(int restaurantId, string name, string type, List<Review> reviews, string logoPath)
        //{
        //    RestaurantId = restaurantId;
        //    Name = name;
        //    Type = type;
        //    Reviews = reviews;
        //    LogoPath = logoPath;
        //}


    }
}