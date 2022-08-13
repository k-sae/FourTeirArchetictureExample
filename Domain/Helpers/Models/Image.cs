using System.Text.Json.Serialization;

namespace FourTierArchitectureExample.Domain.Helpers.Models;

public class Image
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonPropertyName("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonPropertyName("filename")]
    public string Filename { get; set; }

    [JsonPropertyName("encoding")]
    public object Encoding { get; set; }

    [JsonPropertyName("mimetype")]
    public object Mimetype { get; set; }

    [JsonPropertyName("size")]
    public object Size { get; set; }

    [JsonPropertyName("url")]
    public string Url { get; set; }
}