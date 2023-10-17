using System.Text.Json.Serialization;

namespace PoESnap.Models
{
    public class CrucibleNode
    {
        [JsonPropertyName("skill")]
        public uint? Skill { get; set; }

        [JsonPropertyName("tier")]
        public uint? Tier { get; set; }

        [JsonPropertyName("icon")]
        public string? Icon { get; set; }

        [JsonPropertyName("allocated")]
        public bool? Allocated { get; set; }

        [JsonPropertyName("isNotable")]
        public bool? IsNotable { get; set; }

        [JsonPropertyName("isReward")]
        public bool? IsReward { get; set; }

        [JsonPropertyName("stats")]
        public List<string>? Stats { get; set; }

        [JsonPropertyName("reminderText")]
        public List<string>? ReminderText { get; set; }

        [JsonPropertyName("orbit")]
        public uint? Orbit { get; set; }

        [JsonPropertyName("orbitIndex")]
        public uint? OrbitIndex { get; set; }

        [JsonPropertyName("out")]
        public List<string> Out { get; set; }

        [JsonPropertyName("in")]
        public List<string> In { get; set; }

        public CrucibleNode()
        {
            Out = new List<string>();
            In = new List<string>();
        }
    }
}
