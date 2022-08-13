using System.Text.Json.Serialization;

namespace FourTierArchitectureExample.Domain.Courses.Models;

public enum SessionState
{
    [JsonPropertyName("created")]
    Created,
    [JsonPropertyName("started")]
    Started,
    [JsonPropertyName("ended")]
    Ended
}
public class Session
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("startTime")]
    public DateTime StartTime { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("endTime")]
    public DateTime EndTime { get; set; }

    [JsonPropertyName("instructions")]
    public string Instructions { get; set; }

    [JsonPropertyName("sessionDay")]
    public string SessionDay { get; set; }

    [JsonPropertyName("numberOfSeats")]
    public int NumberOfSeats { get; set; }

    [JsonPropertyName("numberOfStudent")]
    public int NumberOfStudent { get; set; }

    [JsonPropertyName("sessionUrl")]
    public string SessionUrl { get; set; }

    [JsonPropertyName("recordUrl")]
    public string RecordUrl { get; set; }

    [JsonPropertyName("isSessionStarted")]
    public bool IsSessionStarted { get; set; }

    [JsonPropertyName("startedTime")]
    public DateTime StartedTime { get; set; }

    [JsonPropertyName("finishedTime")]
    public DateTime FinishedTime { get; set; }

    [JsonPropertyName("isCanceled")]
    public bool IsCanceled { get; set; }


    [JsonPropertyName("session_state")]
    public SessionState SessionState { get; set; }
}
