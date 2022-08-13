using System.Text.Json.Serialization;

namespace FourTierArchitectureExample.Domain.Courses.CourseReviews.Models;

public enum CourseReviewState
{
    [JsonPropertyName("created")]
    Created,
    [JsonPropertyName("edited")]
    Edited,
    [JsonPropertyName("suspended")]
    Suspended,
    [JsonPropertyName("deleted")]
    Deleted
}
public class CourseReview
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("ratingPoints")]
    public int RatingPoints { get; set; }

    [JsonPropertyName("review")]
    public string Review { get; set; }

    [JsonPropertyName("contentRate")]
    public int ContentRate { get; set; }

    [JsonPropertyName("knowledgeRate")]
    public int KnowledgeRate { get; set; }

    [JsonPropertyName("activitiesRate")]
    public int ActivitiesRate { get; set; }

    [JsonPropertyName("recommendRate")]
    public int RecommendRate { get; set; }

    [JsonPropertyName("user_id")]
    public string UserId { get; set; }

    [JsonPropertyName("review_replies_collection_id")]
    public string ReviewRepliesCollectionId { get; set; }
}