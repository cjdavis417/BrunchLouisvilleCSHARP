using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BrunchLouisvilleCS.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int RestaurantId { get; }
        public string Title { get; set; }
        public int Rating { get; set; }
        public string WriteUp { get; set; }
        public string Date { get; set; }


        public Review(int reviewId, int restaurantId, string title, int rating, string writeUp, string date)
        {
            ReviewId = reviewId;
            RestaurantId = restaurantId;
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