using System.Text.Json.Serialization;

namespace PoESnap.Models
{
    public class Character
    {
        [JsonPropertyName("items")]
        public List<Item>? Items { get; set; }

        [JsonPropertyName("character")]
        public CharacterMetadata? Metadata { get; set; }
    }
}
