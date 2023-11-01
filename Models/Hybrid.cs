using MongoDB.Bson.Serialization.Attributes;

namespace PoESnap.Models
{
    public class Hybrid
    {
        [BsonElement("isVaalGem")]
        public bool? IsVaalGem { get; set; }

        [BsonElement("baseTypeName")]
        public string BaseTypeName { get; set; }

        [BsonElement("explicitMods")]
        public List<string>? ExplicitMods { get; set; }

        [BsonElement("secDescrText")]
        public string? SecondaryDescriptionText { get; set; }

        [BsonElement("properties")]
        public List<ItemProperty>? Properties { get; set; }

        public Hybrid()
        {
            BaseTypeName = string.Empty;
        }
    }
}
