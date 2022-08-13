using System.Text.Json.Serialization;

namespace FourTierArchitectureExample.Domain.Users.Models;

public enum FriendRequestStatus
{
    [JsonPropertyName("pending")] Pending,
    [JsonPropertyName("accepted")] Accepted,
    [JsonPropertyName("declined")] Declined,
    [JsonPropertyName("deleted")] Deleted
}

public class FriendRequest
{
    [JsonPropertyName("status")] public FriendRequestStatus Status { get; set; }

    [JsonPropertyName("user_Id")] public string UserId { get; set; }
}