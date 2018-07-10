using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrunchLouisvilleCS.Models
{
    public class Review
    {
        public string RestaurantId { get; }
        public string Title { get; set; }
        public int Rating { get; set; }
        public string WriteUp { get; set; }
        public string Date { get; set; }


        public Review(string title, int rating, string writeUp, string date)
        {
            Title = title;
            Rating = rating;
            WriteUp = writeUp;
            Date = date;
        }

        public DateTime StringToDate(string date)
        {
            var dt = DateTime.Parse(date);
            return dt;
        }

    }
}