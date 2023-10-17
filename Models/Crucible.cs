using System.Text.Json.Serialization;

namespace PoESnap.Models
{
    public class Crucible
    {
        [JsonPropertyName("layout")]
        public string Layout { get; set; }

        [JsonPropertyName("nodes")]
        public Dictionary<string, CrucibleNode> Nodes { get; set; }

        public Crucible()
        {
            Nodes = new Dictionary<string, CrucibleNode>();
        }
    }
}
