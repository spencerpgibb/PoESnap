using MongoDB.Bson.Serialization.Attributes;

namespace PoESnap.Models
{
    public class IncubatedItem
    {
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("level")]
        public uint Level { get; set; }

        [BsonElement("progress")]
        public uint Progress { get; set; }

        [BsonElement("total")]
        public uint Total { get; set; }

        public IncubatedItem() 
        {
            Name = string.Empty;
        }
    }
}
