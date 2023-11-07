using MongoDB.Bson.Serialization.Attributes;
using PoESnap.Models;

namespace PoESnap.Services.CharacterService
{
    public class CharacterSnapshot
    {
        [BsonElement("snapshotFetchTime")]
        public DateTime SnapshotFetchTime { get; set; }

        [BsonElement("items")]
        public List<Item>? Items { get; set; }
    }
}
