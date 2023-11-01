using MongoDB.Bson.Serialization.Attributes;

namespace PoESnap.Models
{
    public class Scourged
    {
        [BsonElement("tier")]
        public uint Tier { get; set; }

        [BsonElement("level")]
        public uint? Level { get; set; }

        [BsonElement("progress")]
        public uint? Progress { get; set; }

        [BsonElement("total")]
        public uint? Total { get; set; }
    }
}
