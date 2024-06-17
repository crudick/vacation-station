namespace VacationStation.Domain.Entities;

public class ReviewsAndRatings
{
    public double AverageRating { get; set; }
    public int NumberOfReviews { get; set; }
    public List<Review> CustomerReviews { get; set; }
}