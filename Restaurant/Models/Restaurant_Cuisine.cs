using System;
using System.Collections.Generic;

namespace Restaurant.Models {
    public class Restaurant_Cuisine {
        int CuisineID {set; get;}
        List<Cuisine> Cuisines {set; get;}
        int RestaurantID {set; get;}
        List<Restaurant> Restaurants {set; get;}
    }
}
        

