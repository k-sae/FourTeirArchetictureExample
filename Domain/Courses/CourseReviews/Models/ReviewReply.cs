using System.Text.Json.Serialization;

namespace FourTierArchitectureExample.Domain.Courses.CourseReviews.Models;

public enum ReviewReplyState
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
public class ReviewReply
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("reply")]
    public string Reply { get; set; }

    [JsonPropertyName("published_at")]
    public object PublishedAt { get; set; }

    [JsonPropertyName("user")]
    public string User { get; set; }
}