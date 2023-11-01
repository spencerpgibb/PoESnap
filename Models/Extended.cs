using MongoDB.Bson.Serialization.Attributes;

namespace PoESnap.Models
{
    public class Extended
    {
        [BsonElement("category")]
        public string? Category { get; set; }  

        [BsonElement("subcategories")]
        public List<string>? Subcategories { get; set; }

        [BsonElement("prefixes")]
        public uint? prefixes { get; set; }

        [BsonElement("suffixes")]
        public uint? suffixes { get; set; }
    }
}
