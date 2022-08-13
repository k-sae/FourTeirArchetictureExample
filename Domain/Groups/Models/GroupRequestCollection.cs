using System.Text.Json.Serialization;

namespace FourTierArchitectureExample.Domain.Groups.Models;

public class GroupRequestCollection
{
    [JsonPropertyName("groupRequests")]
    public List<GroupRequest> GroupRequests { get; set; }

    [JsonPropertyName("next")]
    public string Next { get; set; }

    [JsonPropertyName("prev")]
    public string Prev { get; set; }
}
