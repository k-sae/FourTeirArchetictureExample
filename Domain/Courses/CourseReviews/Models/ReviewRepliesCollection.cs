using System.Text.Json.Serialization;

namespace FourTierArchitectureExample.Domain.Courses.CourseReviews.Models;

public class ReviewRepliesCollection
{
    [JsonPropertyName("reviewReplies")]
    public List<ReviewReply> ReviewReplies { get; set; }

    [JsonPropertyName("nextReviewReplies")]
    public string NextReviewReplies { get; set; }

    [JsonPropertyName("prevReviewReplies")]
    public string PrevReviewReplies { get; set; }
}