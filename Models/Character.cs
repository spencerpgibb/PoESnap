using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PoESnap.Models
{
    public class Character
    {
        [BsonElement("_id")]
        public ObjectId Id { get; set; }

        [BsonElement("items")]
        public List<Item>? Items { get; set; }

        [BsonElement("character")]
        public CharacterMetadata? Metadata { get; set; }
    }
}
