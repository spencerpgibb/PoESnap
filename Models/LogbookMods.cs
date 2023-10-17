using System.Text.Json.Serialization;

namespace PoESnap.Models
{
    public class LogbookMods
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("faction")]
        public KeyValuePair<string, string> Faction { get; set; }

        [JsonPropertyName("mods")]
        public List<string> Mods { get; set; }

        public LogbookMods() 
        {
            Name = string.Empty;
            Mods = new List<string>();
        }
    }
}
