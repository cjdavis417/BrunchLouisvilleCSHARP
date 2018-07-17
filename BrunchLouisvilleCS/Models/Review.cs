using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BrunchLouisvilleCS.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public Restaurant Restaurant { get; set; }
        //public int RestaurantId { get; }
        [Required, StringLength(50)]
        public string Title { get; set; }
        public int Rating { get; set; }
        [Required, StringLength(2000)]
        public string WriteUp { get; set; }
        public DateTime Date { get; set; }


        //public Review(int reviewId, int restaurantId, string title, int rating, string writeUp, string date)
        //{
        //    ReviewId = reviewId;
        //    RestaurantId = restaurantId;
        //    Title = title;
        //    Rating = rating;
        //    WriteUp = writeUp;
        //    Date = date;
        //}

        //public DateTime StringToDate(string date)
        //{
        //    var dt = DateTime.Parse(date);
        //    return dt;
        //}

    }
}