using System.Text.Json.Serialization;

namespace FourTierArchitectureExample.Domain.Groups.Models;

public class GroupRequest
{
    [JsonPropertyName("status")]
    public string Status { get; set; }

    [JsonPropertyName("user")]
    public string User { get; set; }
}
