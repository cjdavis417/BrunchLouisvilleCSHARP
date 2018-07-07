using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrunchLouisvilleCS.Models
{
    public class Review
    {
        public string Title { get; set; }
        public int Rating { get; set; }
        public string WriteUp { get; set; }


        public Review(string title, int rating, string writeUp)
        {
            Title = title;
            Rating = rating;
            WriteUp = writeUp;

        }

    }
}