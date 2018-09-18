using System;

namespace Restaurant.Models {
    public class Prediction {
        int PredictionID { set; get;}
        string ScoredLabel { set; get;}
        float ScoredProbability { set; get;}
        int GroupID { set; get;}
        int RestaurantID { set; get;}
        int OccassionID {set; get;}
        DateTime PredictionDate { set; get;}

    }
}