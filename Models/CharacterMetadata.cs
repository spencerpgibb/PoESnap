using System.Text.Json.Serialization;

namespace PoESnap.Models
{
    public class CharacterMetadata
    {
        public CharacterMetadata()
        {
            Name = string.Empty;
            Realm = string.Empty;
            Class = string.Empty;
            League = string.Empty;
        }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("realm")]
        public string Realm { get; set; }

        [JsonPropertyName("class")]
        public string Class { get; set; }

        [JsonPropertyName("league")]
        public string League { get; set; }

        [JsonPropertyName("level")]
        public int Level { get; set; }

        [JsonPropertyName("pinnable")]
        public bool? Pinnable { get; set; }
    }
}
