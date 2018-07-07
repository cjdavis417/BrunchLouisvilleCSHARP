using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrunchLouisvilleCS.Models
{

    public class Restaurant
    {
        public string Name { get; }
        public string Type { get; }
        public List<Review> Reviews { get; set; }
        public string Img { get; }


        public Restaurant(string name, string type, List<Review> reviews, string img)
        {
            Name = name;
            Type = type;
            Reviews = reviews;
            Img = img;
        }

        
    }
}