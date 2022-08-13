using System.Text.Json.Serialization;
using Couchbase.Management.Users;
using FourTierArchitectureExample.Domain.Helpers.Models;
using FourTierArchitectureExample.Domain.Users.Instructors.Models;

namespace FourTierArchitectureExample.Domain.Courses.Models;
// Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);

public enum CourseState
{
    [JsonPropertyName("drafted")]
    Drafted,
    [JsonPropertyName("published")]
    Published,
    [JsonPropertyName("canceled")]
    Canceled,
    [JsonPropertyName("in_progress_sessions_started")]
    InProgressSessionsStarted,
    [JsonPropertyName("in_progress_sessions_ended")]
    InProgressSessionsEnded,
    [JsonPropertyName("archived")]
    Archived,
    [JsonPropertyName("soft_deleted")]
    SoftDeleted
}

public class Course
{
    [JsonPropertyName("id")] public string Id { get; set; }

    [JsonPropertyName("created_at")] public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")] public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("name")] public string Name { get; set; }

    [JsonPropertyName("startDate")] public DateTime StartDate { get; set; }

    [JsonPropertyName("endDate")] public object EndDate { get; set; }

    [JsonPropertyName("price")] public int Price { get; set; }

    [JsonPropertyName("discountFixed")] public int DiscountFixed { get; set; }

    [JsonPropertyName("lessonDurationHours")]
    public int LessonDurationHours { get; set; }

    [JsonPropertyName("courseDurationWeeks")]
    public int CourseDurationWeeks { get; set; }

    [JsonPropertyName("payFor")] public string PayFor { get; set; }

    [JsonPropertyName("numberOfSeatsPerSession")]
    public int NumberOfSeatsPerSession { get; set; }

    [JsonPropertyName("description")] public string Description { get; set; }

    [JsonPropertyName("demo_url")] public string DemoUrl { get; set; }

    [JsonPropertyName("image")] public Image Image { get; set; }

    [JsonPropertyName("instructorId")] public string InstructorId { get; set; }
   
    [JsonPropertyName("instructor")] public Instructor Instructor { get; set; }

    [JsonPropertyName("educationalLevel")] public string EducationalLevel { get; set; }

    [JsonPropertyName("educationalStage")] public string EducationalStage { get; set; }

    [JsonPropertyName("courseReviews")] public string CourseReviews { get; set; }

    [JsonPropertyName("requirements")] public string Requirements { get; set; }

    [JsonPropertyName("prerequisites")] public string Prerequisites { get; set; }

    [JsonPropertyName("goals")] public string Goals { get; set; }

    [JsonPropertyName("outcome")] public string Outcome { get; set; }

    [JsonPropertyName("state")] public CourseState State { get; set; }

    [JsonPropertyName("lessons")] public List<Lesson> Lessons { get; set; }

    [JsonPropertyName("sessions")] public List<Session> Sessions { get; set; }

    [JsonPropertyName("group_id")] public string GroupId { get; set; }

    [JsonPropertyName("group")] public Group Group { get; set; }

    [JsonPropertyName("enrollments")] public List<Enrollment> Enrollments { get; set; }
}