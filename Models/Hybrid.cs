using System.Text.Json.Serialization;

namespace PoESnap.Models
{
    public class Hybrid
    {
        [JsonPropertyName("isVaalGem")]
        public bool? IsVaalGem { get; set; }

        [JsonPropertyName("baseTypeName")]
        public string BaseTypeName { get; set; }

        [JsonPropertyName("explicitMods")]
        public List<string>? ExplicitMods { get; set; }

        [JsonPropertyName("secDescrText")]
        public string? SecondaryDescriptionText { get; set; }

        public Hybrid()
        {
            BaseTypeName = string.Empty;
        }
    }
}
