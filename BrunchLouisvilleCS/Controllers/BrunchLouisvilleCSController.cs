using BrunchLouisvilleCS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections.Generic;
using System.Data.Entity;

namespace BrunchLouisvilleCS.Controllers
{
    public class BrunchLouisvilleCSController : Controller
    {


        List<Restaurant> eateries = new List<Restaurant>();

        // GET: BrunchLouisvilleCS
        public ActionResult Index()
        {
            IEnumerable<Restaurant> restaurants;
            using (var context = new BrunchLouisvilleContext())
            {

                //restaurants = from e in db.Restaurants
                //              select new Restaurant
                //              {
                //                  restID = e.RestaurantId,
                //                  //restName = e.Name,
                //                  //restType= e.Type,
                //                  //restReviews = e.Reviews,
                //                  //restLogo = e.LogoPath
                //              };

                //Restaurant ramsis = new Restaurant(1, "Ramsi's Cafe on the World", "Buffet", ramsisReviews(), "img/logo-ramsis.png");
                //Restaurant bristol = new Restaurant(2, "Bristol's Cafe", "Buffet", bristolReviews(), "img/logo-bristol.png");
                
                //context.Restaurants.Add(ramsis);
                //context.Restaurants.Add(bristol);
                context.SaveChanges();
                

                

            }

            return View();
        }


        public void preBuiltRestaurants()
        {
            Restaurant ramsis = new Restaurant(1, "Ramsi's Cafe on the World", "Buffet", ramsisReviews(), "img/logo-ramsis.png");
            Restaurant bristol = new Restaurant(2, "Bristol's Cafe", "Buffet", bristolReviews(), "img/logo-bristol.png");

            eateries.Add(ramsis);
            eateries.Add(bristol);

        }


        public List<Review> ramsisReviews()
        {
            List<Review> reviews = new List<Review>();
            Review review1 = new Review(1, 1, "Wonderful!", 5, "When we ate here the food was so good.  I recommend to everyone!", "7/5/2018 6:02:00 PM");
            Review review2 = new Review(2, 1, "Pukie", 1, "Vomit.  Pure vomit!", "7/1/2018 11:52:00 AM");
            Review review3 = new Review(3, 1, "A must have!", 4, "nothing bad to say.", "6/28/2018 8:30:52 AM");
            reviews.Add(review1);
            reviews.Add(review2);
            reviews.Add(review3);

            return reviews;

        }

        public List<Review> bristolReviews()
        {
            List<Review> reviews = new List<Review>();
            Review review1 = new Review(4, 2, "Diamond in the Rough!", 5, "You can always count on it.", "6/28/2018 8:30:52 AM");
            
            reviews.Add(review1);
            
            return reviews;

        }


    }
}