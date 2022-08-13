using System.Text.Json.Serialization;
using FourTierArchitectureExample.Domain.Users.Models;

namespace FourTierArchitectureExample.Domain.Notifications.Models;

public class Notification
{
    [JsonPropertyName("id")]
    public string Id { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }
    
    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }
    
    [JsonPropertyName("type")]
    public string Type { get; set; } 
    
    [JsonPropertyName("notifiable_type")]
    public string NotifiableType { get; set; } 
    
    [JsonPropertyName("notifiable_id")]
    public string NotifiableId { get; set; }
    
    [JsonPropertyName("is_seen")]
    public bool IsSeen { get; set; }
    
    [JsonPropertyName("user")]
    public User User { get; set; } 
}