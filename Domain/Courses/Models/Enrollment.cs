using System.Text.Json.Serialization;

namespace FourTierArchitectureExample.Domain.Courses.Models;

public class Enrollment
{
    [JsonPropertyName("user")]
    public string User { get; set; }

    [JsonPropertyName("sessionId")]
    public string SessionId { get; set; }

    [JsonPropertyName("enrollment_date")]
    public string EnrollmentDate { get; set; }
}