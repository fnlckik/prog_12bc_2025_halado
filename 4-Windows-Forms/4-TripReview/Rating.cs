using System;

namespace TripReview
{
    internal class Rating
    {
        public Rating(int iD, string tripName, int travellerId, DateTime reviewDate, int activitiesRating, int locationRating, string comment)
        {
            ID = iD;
            TripName = tripName;
            TravellerId = travellerId;
            ReviewDate = reviewDate;
            ActivitiesRating = activitiesRating;
            LocationRating = locationRating;
            Comment = comment;
        }

        public int ID { get; }
        public string TripName { get; }
        public int TravellerId { get; }
        public DateTime ReviewDate { get; }
        public int ActivitiesRating { get; }
        public int LocationRating { get; }
        public string Comment { get; }

        public override string ToString() => TripName;
    }
}
