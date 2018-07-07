using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrunchLouisvilleCS.Models
{
    public class Review
    {
        private string Title { get; set; }
        private int Rating { get; set; }
        private string Description { get; set; }


        public Review(string title, int rating, string description)
        {
            Title = title;
            Rating = rating;
            Description = description;

        }

    }
}