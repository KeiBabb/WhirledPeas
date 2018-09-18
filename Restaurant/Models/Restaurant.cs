using System;

namespace Restaurant.Models {
    public class Restaurant {
        int RestaurantID {set; get;}
        bool Breakfast {set; get;}
        bool Lunch {set; get;}
        bool Dinner {set; get;}
        decimal PriceRange {set; get;}
        float OverallRating {set; get;}
        float VerifiedRating {set; get;}
        float MaleRating {set; get;}
        float FemaleRating {set; get;}
        float AgeRating {set; get;}
        float OnEthnicityRating {set; get;}
        float OffEthnicityRating {set; get;}       
    }
}