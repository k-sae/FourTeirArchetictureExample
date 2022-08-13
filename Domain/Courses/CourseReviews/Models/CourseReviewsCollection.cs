using System.Text.Json.Serialization;

namespace FourTierArchitectureExample.Domain.Courses.CourseReviews.Models;

public class CourseReviewsCollection
{
    [JsonPropertyName("courseReviews")]
    public List<CourseReview> CourseReviews { get; set; }

    [JsonPropertyName("next")]
    public string Next { get; set; }

    [JsonPropertyName("prev")]
    public string Prev { get; set; }
}