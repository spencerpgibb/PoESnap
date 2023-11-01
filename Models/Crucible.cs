using MongoDB.Bson.Serialization.Attributes;

namespace PoESnap.Models
{
    public class Crucible
    {
        [BsonElement("layout")]
        public string Layout { get; set; }

        [BsonElement("nodes")]
        public Dictionary<string, CrucibleNode> Nodes { get; set; }

        public Crucible()
        {
            Layout = string.Empty;
            Nodes = new Dictionary<string, CrucibleNode>();
        }
    }
}
