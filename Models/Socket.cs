using MongoDB.Bson.Serialization.Attributes;

namespace PoESnap.Models
{
    public class Socket
    {
        [BsonElement("group")]
        public uint Group { get; set; }

        [BsonElement("attr")]
        public string? Attr { get; set; }

        [BsonElement("sColour")]
        public string? SocketColour { get; set; }
    }
}
