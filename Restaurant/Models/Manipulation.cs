using System;

namespace Restaurant.Models {
    public class Manipulation {
        int ManipulationID {set; get;}
        int TimeOfRequest {set; get;} //immediately or later
        bool FeedbackGiven {set; get;} //yes or no
    }
}