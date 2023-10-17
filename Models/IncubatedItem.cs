using System.Text.Json.Serialization;

namespace PoESnap.Models
{
    public class IncubatedItem
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("level")]
        public uint Level { get; set; }

        [JsonPropertyName("progress")]
        public uint Progress { get; set; }

        [JsonPropertyName("total")]
        public uint Total { get; set; }

        public IncubatedItem() 
        {
            Name = string.Empty;
        }
    }
}
