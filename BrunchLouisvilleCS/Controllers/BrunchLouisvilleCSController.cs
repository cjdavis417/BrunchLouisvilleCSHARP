using BrunchLouisvilleCS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections.Generic;

namespace BrunchLouisvilleCS.Controllers
{
    public class BrunchLouisvilleCSController : Controller
    {

        List<Restaurant> eateries = new List<Restaurant>();
        // GET: BrunchLouisvilleCS
        public ActionResult Index()
        {
            preBuiltRestaurants();

            Restaurants restaurants = new Restaurants(eateries);

            return View(restaurants);
        }


        public void preBuiltRestaurants()
        {
            Restaurant ramsis = new Restaurant("Ramsi's Cafe on the World", "Buffet", ramsisReviews());
            Restaurant bristol = new Restaurant("Bristol's Cafe", "Buffet", new List<Review>());

            eateries.Add(ramsis);
            eateries.Add(bristol);

        }

        public List<Review> ramsisReviews()
        {
            List<Review> reviews = new List<Review>();
            Review review1 = new Review("Wonderful!", 5, "When we ate here the food was so good.  I recommend to everyone!");
            Review review2 = new Review("Pukie", 1, "Vomit.  Pure vomit!");
            Review review3 = new Review("A must have!", 4, "nothing bad to say.");
            reviews.Add(review1);
            reviews.Add(review2);
            reviews.Add(review3);

            return reviews;

        }


    }
}