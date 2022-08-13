using System.Text.Json.Serialization;

namespace FourTierArchitectureExample.Domain.Courses.Models;

public class Lesson
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; }

    [JsonPropertyName("startDate")]
    public DateTime StartDate { get; set; }

    [JsonPropertyName("endDate")]
    public DateTime EndDate { get; set; }

    [JsonPropertyName("price")]
    public int Price { get; set; }

    [JsonPropertyName("roomCode")]
    public object RoomCode { get; set; }

    [JsonPropertyName("startLesson")]
    public bool StartLesson { get; set; }

    [JsonPropertyName("roomLinkAdmin")]
    public string RoomLinkAdmin { get; set; }

    [JsonPropertyName("roomLinkAttendee")]
    public string RoomLinkAttendee { get; set; }

    [JsonPropertyName("public")]
    public bool Public { get; set; }

    [JsonPropertyName("description")]
    public string Description { get; set; }

    [JsonPropertyName("demo_url")]
    public string DemoUrl { get; set; }

    [JsonPropertyName("image")]
    public object Image { get; set; }

    [JsonPropertyName("prerequisites")]
    public string Prerequisites { get; set; }

    [JsonPropertyName("goals")]
    public string Goals { get; set; }

    [JsonPropertyName("outcome")]
    public string Outcome { get; set; }

    [JsonPropertyName("assesment")]
    public object Assesment { get; set; }

    [JsonPropertyName("is_paid")]
    public object IsPaid { get; set; }

    [JsonPropertyName("lessonReviews")]
    public string LessonReviews { get; set; }
}
