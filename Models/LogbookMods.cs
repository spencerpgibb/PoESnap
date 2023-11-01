using MongoDB.Bson.Serialization.Attributes;

namespace PoESnap.Models
{
    public class LogbookMods
    {
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("faction")]
        public KeyValuePair<string, string> Faction { get; set; }

        [BsonElement("mods")]
        public List<string> Mods { get; set; }

        public LogbookMods() 
        {
            Name = string.Empty;
            Mods = new List<string>();
        }
    }
}
