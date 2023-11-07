using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using PoESnap.Models;

namespace PoESnap.Services.CharacterService
{
    public class Character
    {
        [BsonElement("_id")]
        public ObjectId Id { get; set; }

        [BsonElement("lastFetched")]
        public DateTime LastFetched { get; set; }

        [BsonElement("snapshots")]
        public List<CharacterSnapshot> Snapshots { get; set; }

        [BsonElement("character")]
        public CharacterMetadata? Metadata { get; set; }

        public Character() 
        {
            Snapshots = new List<CharacterSnapshot>();
        }
    }
}
