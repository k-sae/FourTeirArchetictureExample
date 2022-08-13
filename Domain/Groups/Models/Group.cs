using System.Text.Json.Serialization;
using FourTierArchitectureExample.Domain.Helpers.Models;

namespace FourTierArchitectureExample.Domain.Groups.Models;

public enum GroupState
{
    [JsonPropertyName("auto_created_with_course")]
    AutoCreatedWithCourse,
    
    [JsonPropertyName("course_private_active")]
    CoursePrivateActive,
    
    [JsonPropertyName("course_private_inactive")]
    CoursePrivateInactive,
    
    [JsonPropertyName("user_public_active")]
    CoursePublicActive,
    
    [JsonPropertyName("user_public_inactive")]
    CoursePublicInactive,
    
    [JsonPropertyName("user_private_active")]
    UserPrivateActive,
    
    [JsonPropertyName("user_private_inactive")]
    UserPrivateInactive,
    
}
public class Group
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("image")]
    public Image Image { get; set; }

    [JsonPropertyName("adminUser")]
    public string AdminUser { get; set; }
}
