using System.Text.Json.Serialization;

namespace PoESnap.Models
{
    public class Scourged
    {
        [JsonPropertyName("tier")]
        public uint Tier { get; set; }

        [JsonPropertyName("level")]
        public uint? Level { get; set; }

        [JsonPropertyName("progress")]
        public uint? Progress { get; set; }

        [JsonPropertyName("total")]
        public uint? Total { get; set; }
    }
}
