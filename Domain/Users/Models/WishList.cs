using System.Text.Json.Serialization;

namespace FourTierArchitectureExample.Domain.Users.Models;

public enum WishType
{
    [JsonPropertyName("lesson")]
    Lesson,
    [JsonPropertyName("course")]
    Course,
}

public class WishList
{
    [JsonPropertyName("type")]
    public WishType Type { get; set; }

    [JsonPropertyName("wishlistableId")]
    public string WishlistableId { get; set; }
}
