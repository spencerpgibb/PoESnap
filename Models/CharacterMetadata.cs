using MongoDB.Bson.Serialization.Attributes;

namespace PoESnap.Models
{
    public class CharacterMetadata
    {
        public CharacterMetadata()
        {
            Name = string.Empty;
            Realm = string.Empty;
            Class = string.Empty;
            League = string.Empty;
        }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("realm")]
        public string Realm { get; set; }

        [BsonElement("class")]
        public string Class { get; set; }

        [BsonElement("league")]
        public string League { get; set; }

        [BsonElement("level")]
        public int Level { get; set; }

        [BsonElement("pinnable")]
        public bool? Pinnable { get; set; }
    }
}
