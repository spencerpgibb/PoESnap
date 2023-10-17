using System.Text.Json.Serialization;

namespace PoESnap.Models
{
    public class ItemProperty
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("values")]
        public List<object> Values { get; set; }

        [JsonPropertyName("displayMode")]
        public uint DisplayMode { get; set; }

        [JsonPropertyName("progress")]
        public double? Progress { get; set; }

        [JsonPropertyName("type")]
        public uint? Type { get; set; }

        [JsonPropertyName("suffix")]
        public string? Suffix { get; set; }

        public ItemProperty()
        {
            Name = string.Empty;
            Values = new List<object>();
        }
    }
}
