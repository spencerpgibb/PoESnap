using System.Text.Json.Serialization;

namespace PoESnap.Models
{
    public class Socket
    {
        [JsonPropertyName("group")]
        public uint Group { get; set; }

        [JsonPropertyName("attr")]
        public string? Attr { get; set; }

        [JsonPropertyName("sColour")]
        public string? SocketColour { get; set; }
    }
}
