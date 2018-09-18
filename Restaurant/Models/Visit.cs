using System;

namespace Restaurant.Models {
    public class Visit {
        int VisitID {set; get;}
        DateTime DateOfVisit {set; get;}
        int MemberID {set; get;}
        int RestaurantID {set; get;}
        int Rating {set; get;}
        string RatingNotes {set; get;}
        bool Verified {set; get;}
    }
}