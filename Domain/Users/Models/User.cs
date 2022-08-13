using System.Text.Json.Serialization;
using FourTierArchitectureExample.Domain.Helpers.Models;

namespace FourTierArchitectureExample.Domain.Users.Models;

    public abstract class User
    {
        // [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]    
        public DateTime UpdatedAt { get; set; }

        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("confirmed")]
        public bool Confirmed { get; set; }

        [JsonPropertyName("blocked")]
        public bool Blocked { get; set; }

        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("nationality")]
        public string Nationality { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("birthDate")]
        public string BirthDate { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("institution")]
        public string Institution { get; set; }

        [JsonPropertyName("class")]
        public string Class { get; set; }

        [JsonPropertyName("locale")]
        public string Locale { get; set; }

        [JsonPropertyName("email_verified")]
        public bool EmailVerified { get; set; }

        [JsonPropertyName("educationalLevel")]
        public string EducationalLevel { get; set; }

        [JsonPropertyName("educationalStage")]
        public string EducationalStage { get; set; }

        [JsonPropertyName("profileImage")]
        public Image ProfileImage { get; set; }

        [JsonPropertyName("profileCompletionPercentage")]
        public int ProfileCompletionPercentage { get; set; }
        
        [JsonPropertyName("wish_lists")]
        public List<WishList> WishLists { get; set; }

        [JsonPropertyName("student_courses")]
        public string StudentCourses { get; set; }

        [JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonPropertyName("competitionsSubmissions")]
        public string CompetitionsSubmissions { get; set; }
        
        [JsonPropertyName("role")]
        public abstract string Role { get; }
    }
