using MongoDB.Bson.Serialization.Attributes;

namespace PoESnap.Models
{
    public class CrucibleNode
    {
        [BsonElement("skill")]
        public uint? Skill { get; set; }

        [BsonElement("tier")]
        public uint? Tier { get; set; }

        [BsonElement("icon")]
        public string? Icon { get; set; }

        [BsonElement("allocated")]
        public bool? Allocated { get; set; }

        [BsonElement("isNotable")]
        public bool? IsNotable { get; set; }

        [BsonElement("isReward")]
        public bool? IsReward { get; set; }

        [BsonElement("stats")]
        public List<string>? Stats { get; set; }

        [BsonElement("reminderText")]
        public List<string>? ReminderText { get; set; }

        [BsonElement("orbit")]
        public uint? Orbit { get; set; }

        [BsonElement("orbitIndex")]
        public uint? OrbitIndex { get; set; }

        [BsonElement("out")]
        public List<string> Out { get; set; }

        [BsonElement("in")]
        public List<string> In { get; set; }

        public CrucibleNode()
        {
            Out = new List<string>();
            In = new List<string>();
        }
    }
}
