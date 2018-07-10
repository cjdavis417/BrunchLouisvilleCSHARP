using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BrunchLouisvilleCS.Models
{
    public class BrunchLouisvilleContext : DbContext
    {
        public DbSet<Restaurant> restaurants { get; set; }


        //public Restaurants(List<Restaurant> eateries)
        //{
        //   restaurants = eateries;

        //}
    }
  
}