using System.Text.Json.Serialization;

namespace PoESnap.Models
{
    public class Item
    {
        [JsonPropertyName("verified")]
        public bool Verified { get; set; }

        [JsonPropertyName("w")]
        public uint Width { get; set; }

        [JsonPropertyName("h")]
        public uint Height { get; set; }

        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        [JsonPropertyName("support")]
        public bool? Support { get; set; }

        [JsonPropertyName("stackSize")]
        public int? StackSize { get; set; }

        [JsonPropertyName("maxStackSize")]
        public int? MaxStackSize { get; set; }

        [JsonPropertyName("stackSizeText")]
        public string? StackSizeText { get; set; }

        [JsonPropertyName("league")]
        public string? League { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("influences")]
        public object? Influences { get; set; }

        [JsonPropertyName("elder")]
        public bool? Elder { get; set; }

        [JsonPropertyName("shaper")]
        public bool? Shaper { get; set; }

        [JsonPropertyName("searing")]
        public bool? Searing { get; set; }

        [JsonPropertyName("tangled")]
        public bool? Tangled { get; set; }

        [JsonPropertyName("abyssJewel")]
        public bool? AbyssJewel { get; set; }

        [JsonPropertyName("delve")]
        public bool? Delve { get; set; }

        [JsonPropertyName("fractured")]
        public bool? Fractured { get; set; }

        [JsonPropertyName("synthesized")]
        public bool? Synthesized { get; set; }

        [JsonPropertyName("sockets")]
        public List<Socket>? Sockets { get; set; }

        [JsonPropertyName("socketedItems")]
        public List<Item>? SocketedItems { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("typeLine")]
        public string TypeLine { get; set; }

        [JsonPropertyName("baseType")]
        public string BaseType { get; set; }

        [JsonPropertyName("identified")]
        public bool Identified { get; set; }

        [JsonPropertyName("itemLevel")]
        public int? ItemLevel { get; set; }

        [JsonPropertyName("ilvl")]
        public int ItemLvl { get; set; }

        [JsonPropertyName("note")]
        public string? Note { get; set; }

        [JsonPropertyName("forum_note")]
        public string? ForumNote { get; set; }

        [JsonPropertyName("lockedToCharacter")]
        public bool? LockedToCharacter { get; set; }

        [JsonPropertyName("lockedToAccount")]
        public bool? LockedToAccount { get; set; }

        [JsonPropertyName("duplicated")]
        public bool? Duplicated { get; set; }

        [JsonPropertyName("cisRaceReward")]
        public bool? CisRaceReward { get; set; }

        [JsonPropertyName("seaRaceReward")]
        public bool? SeaRaceReward { get; set; }

        [JsonPropertyName("thRaceReward")]
        public bool? ThRaceReward { get; set; }

        [JsonPropertyName("properties")]
        public List<ItemProperty>? Properties { get; set; }

        [JsonPropertyName("notableProperties")]
        public List<ItemProperty>? NotableProperties { get; set; }

        [JsonPropertyName("requirements")]
        public List<ItemProperty>? Requirements { get; set; }

        [JsonPropertyName("additionalProperties")]
        public List<ItemProperty>? AdditionalProperties { get; set; }

        [JsonPropertyName("nextLevelRequirements")]
        public List<ItemProperty>? NextLevelRequirements { get; set; }

        [JsonPropertyName("talismanTier")]
        public int? TalismanTier { get; set; }

        [JsonPropertyName("secDescrText")]
        public string? SecondaryDescriptionText { get; set; }

        [JsonPropertyName("utilityMods")]
        public List<string>? UtilityMods { get; set; }

        [JsonPropertyName("logbookMods")]
        public List<LogbookMods>? LogbookMods { get; set; }

        [JsonPropertyName("enchantMods")]
        public List<string>? EnchantMods { get; set; }

        [JsonPropertyName("scourgeMods")]
        public List<string>? ScourgeMods { get; set; }

        [JsonPropertyName("implicitMods")]
        public List<string>? ImplicitMods { get; set; }

        [JsonPropertyName("ultimatumMods")] // ultimatum icon, tier
        public List<Tuple<string, uint>>? UltimatumMods { get; set; }

        [JsonPropertyName("explicitMods")]
        public List<string>? ExplicitMods { get; set; }

        [JsonPropertyName("craftedMods")]
        public List<string>? CraftedMods { get; set; }

        [JsonPropertyName("fracturedMods")]
        public List<string>? FracturedMods { get; set; }

        [JsonPropertyName("crucibleMods")]
        public List<string>? CrucibleMods { get; set; }

        [JsonPropertyName("cosmeticMods")]
        public List<string>? CosmeticMods { get; set; }

        [JsonPropertyName("veiledMods")]
        public List<string>? VeiledMods { get; set; }

        [JsonPropertyName("veiled")]
        public bool? Veiled { get; set; }

        [JsonPropertyName("descrText")]
        public string? DescriptionText { get; set; }

        [JsonPropertyName("flavourText")]
        public List<string>? FlavourText { get; set; }

        [JsonPropertyName("flavourTextParsed")]
        public List<string>? FlavourTextParsed { get; set; }

        [JsonPropertyName("flavourTextNote")]
        public string? FlavourTextNote { get; set; }

        [JsonPropertyName("prophecyText")]
        public string? ProphecyText { get; set; }

        [JsonPropertyName("isRelic")]
        public bool? IsRelic { get; set; }

        [JsonPropertyName("foilVariation")]
        public int? FoilVariation { get; set; }

        [JsonPropertyName("replica")]
        public bool? Replica { get; set; }

        [JsonPropertyName("foreseeing")]
        public bool? Foreseeing { get; set; }

        [JsonPropertyName("incubtedItem")]
        public IncubatedItem? IncubatedItem { get; set; }

        [JsonPropertyName("scourged")]
        public Scourged? Scourged { get; set; }

        [JsonPropertyName("crucible")]
        public Crucible? Crucible { get; set; }

        [JsonPropertyName("ruthless")]
        public bool? Ruthless { get; set; }

        [JsonPropertyName("frameType")]
        public uint? FrameType { get; set; }

        [JsonPropertyName("artFilename")]
        public string? ArtFilename { get; set; }

        [JsonPropertyName("hybrid")]
        public Hybrid? Hybrid { get; set; }

        [JsonPropertyName("extended")]
        public Extended? Extended { get; set; }

        [JsonPropertyName("x")]
        public uint? X { get; set; }

        [JsonPropertyName("y")]
        public uint? Y { get; set; }

        [JsonPropertyName("inventoryId")]
        public string? InventoryId { get; set; }

        [JsonPropertyName("socket")]
        public uint? Socket { get; set; }

        [JsonPropertyName("colour")]
        public string? Colour { get; set; }

        public Item()
        {
            Id = string.Empty;
            Icon = string.Empty;
            Name = string.Empty;
            TypeLine = string.Empty;
            BaseType = string.Empty;
        }
    }
}
