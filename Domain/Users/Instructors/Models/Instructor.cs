using System.Text.Json.Serialization;
using FourTierArchitectureExample.Domain.Users.Models;

namespace FourTierArchitectureExample.Domain.Users.Instructors.Models;

public class Instructor : User
{

    [JsonPropertyName("instructor_courses")]
    public List<string> InstructorCourses { get; set; }

    [JsonPropertyName("instructor_packages")]
    public List<string> InstructorPackages { get; set; }

    [JsonPropertyName("refers")]
    public List<string> Refers { get; set; }

    [JsonPropertyName("badges")]
    public List<object> Badges { get; set; }

    [JsonPropertyName("competitions")]
    public string Competitions { get; set; }
    
    [JsonPropertyName("role")]
    public override string Role => "instructor";
}
