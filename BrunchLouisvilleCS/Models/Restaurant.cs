using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrunchLouisvilleCS.Models
{

    public class Restaurant
    {
        public string Name { get; set; }
        public string Type { get; }
        public List<Review> Reviews { get; set; }


        public Restaurant(string name, string type, List<Review> reviews)
        {
            Name = name;
            Type = type;
            Reviews = reviews;

        }

        
    }
}