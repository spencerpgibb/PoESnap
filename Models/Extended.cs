using System.Text.Json.Serialization;

namespace PoESnap.Models
{
    public class Extended
    {
        [JsonPropertyName("category")]
        public string? Category { get; set; }  

        [JsonPropertyName("subcategories")]
        public List<string>? Subcategories { get; set; }

        [JsonPropertyName("prefixes")]
        public uint? prefixes { get; set; }

        [JsonPropertyName("suffixes")]
        public uint? suffixes { get; set; }
    }
}
