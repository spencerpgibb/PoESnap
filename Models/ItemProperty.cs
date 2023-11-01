using MongoDB.Bson.Serialization.Attributes;

namespace PoESnap.Models
{
    public class ItemProperty
    {
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("values")]
        public List<object> Values { get; set; }

        [BsonElement("displayMode")]
        public uint DisplayMode { get; set; }

        [BsonElement("progress")]
        public double? Progress { get; set; }

        [BsonElement("type")]
        public uint? Type { get; set; }

        [BsonElement("suffix")]
        public string? Suffix { get; set; }

        public ItemProperty()
        {
            Name = string.Empty;
            Values = new List<object>();
        }
    }
}
