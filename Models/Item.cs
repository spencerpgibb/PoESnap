using MongoDB.Bson.Serialization.Attributes;

namespace PoESnap.Models
{
    public class Item
    {
        [BsonElement("verified")]
        public bool Verified { get; set; }

        [BsonElement("w")]
        public uint Width { get; set; }

        [BsonElement("h")]
        public uint Height { get; set; }

        [BsonElement("icon")]
        public string Icon { get; set; }

        [BsonElement("support")]
        public bool? Support { get; set; }

        [BsonElement("stackSize")]
        public int? StackSize { get; set; }

        [BsonElement("maxStackSize")]
        public int? MaxStackSize { get; set; }

        [BsonElement("stackSizeText")]
        public string? StackSizeText { get; set; }

        [BsonElement("league")]
        public string? League { get; set; }

        [BsonElement("id")]
        public string? ItemId { get; set; }

        [BsonElement("influences")]
        public object? Influences { get; set; }

        [BsonElement("elder")]
        public bool? Elder { get; set; }

        [BsonElement("shaper")]
        public bool? Shaper { get; set; }

        [BsonElement("searing")]
        public bool? Searing { get; set; }

        [BsonElement("tangled")]
        public bool? Tangled { get; set; }

        [BsonElement("abyssJewel")]
        public bool? AbyssJewel { get; set; }

        [BsonElement("delve")]
        public bool? Delve { get; set; }

        [BsonElement("fractured")]
        public bool? Fractured { get; set; }

        [BsonElement("synthesised")]
        public bool? Synthesised { get; set; }

        [BsonElement("sockets")]
        public List<Socket>? Sockets { get; set; }

        [BsonElement("socketedItems")]
        public List<Item>? SocketedItems { get; set; }

        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("typeLine")]
        public string TypeLine { get; set; }

        [BsonElement("baseType")]
        public string BaseType { get; set; }

        [BsonElement("identified")]
        public bool Identified { get; set; }

        [BsonElement("itemLevel")]
        public int? ItemLevel { get; set; }

        [BsonElement("ilvl")]
        public int ItemLvl { get; set; }

        [BsonElement("note")]
        public string? Note { get; set; }

        [BsonElement("forum_note")]
        public string? ForumNote { get; set; }

        [BsonElement("lockedToCharacter")]
        public bool? LockedToCharacter { get; set; }

        [BsonElement("lockedToAccount")]
        public bool? LockedToAccount { get; set; }

        [BsonElement("duplicated")]
        public bool? Duplicated { get; set; }

        [BsonElement("split")]
        public bool? Split { get; set; }

        [BsonElement("corrupted")]
        public bool? Corrupted { get; set; }

        [BsonElement("unmodifiable")]
        public bool? Unmodifiable { get; set; }

        [BsonElement("cisRaceReward")]
        public bool? CisRaceReward { get; set; }

        [BsonElement("seaRaceReward")]
        public bool? SeaRaceReward { get; set; }

        [BsonElement("thRaceReward")]
        public bool? ThRaceReward { get; set; }

        [BsonElement("properties")]
        public List<ItemProperty>? Properties { get; set; }

        [BsonElement("notableProperties")]
        public List<ItemProperty>? NotableProperties { get; set; }

        [BsonElement("requirements")]
        public List<ItemProperty>? Requirements { get; set; }

        [BsonElement("additionalProperties")]
        public List<ItemProperty>? AdditionalProperties { get; set; }

        [BsonElement("nextLevelRequirements")]
        public List<ItemProperty>? NextLevelRequirements { get; set; }

        [BsonElement("talismanTier")]
        public int? TalismanTier { get; set; }

        [BsonElement("secDescrText")]
        public string? SecondaryDescriptionText { get; set; }

        [BsonElement("utilityMods")]
        public List<string>? UtilityMods { get; set; }

        [BsonElement("logbookMods")]
        public List<LogbookMods>? LogbookMods { get; set; }

        [BsonElement("enchantMods")]
        public List<string>? EnchantMods { get; set; }

        [BsonElement("scourgeMods")]
        public List<string>? ScourgeMods { get; set; }

        [BsonElement("implicitMods")]
        public List<string>? ImplicitMods { get; set; }

        [BsonElement("ultimatumMods")] // ultimatum icon, tier
        public List<Tuple<string, uint>>? UltimatumMods { get; set; }

        [BsonElement("explicitMods")]
        public List<string>? ExplicitMods { get; set; }

        [BsonElement("craftedMods")]
        public List<string>? CraftedMods { get; set; }

        [BsonElement("fracturedMods")]
        public List<string>? FracturedMods { get; set; }

        [BsonElement("crucibleMods")]
        public List<string>? CrucibleMods { get; set; }

        [BsonElement("cosmeticMods")]
        public List<string>? CosmeticMods { get; set; }

        [BsonElement("veiledMods")]
        public List<string>? VeiledMods { get; set; }

        [BsonElement("veiled")]
        public bool? Veiled { get; set; }

        [BsonElement("descrText")]
        public string? DescriptionText { get; set; }

        [BsonElement("flavourText")]
        public List<string>? FlavourText { get; set; }

        [BsonElement("flavourTextParsed")]
        public List<string>? FlavourTextParsed { get; set; }

        [BsonElement("flavourTextNote")]
        public string? FlavourTextNote { get; set; }

        [BsonElement("prophecyText")]
        public string? ProphecyText { get; set; }

        [BsonElement("isRelic")]
        public bool? IsRelic { get; set; }

        [BsonElement("foilVariation")]
        public int? FoilVariation { get; set; }

        [BsonElement("replica")]
        public bool? Replica { get; set; }

        [BsonElement("foreseeing")]
        public bool? Foreseeing { get; set; }

        [BsonElement("incubatedItem")]
        public IncubatedItem? IncubatedItem { get; set; }

        [BsonElement("scourged")]
        public Scourged? Scourged { get; set; }

        [BsonElement("crucible")]
        public Crucible? Crucible { get; set; }

        [BsonElement("ruthless")]
        public bool? Ruthless { get; set; }

        [BsonElement("frameType")]
        public uint? FrameType { get; set; }

        [BsonElement("artFilename")]
        public string? ArtFilename { get; set; }

        [BsonElement("hybrid")]
        public Hybrid? Hybrid { get; set; }

        [BsonElement("extended")]
        public Extended? Extended { get; set; }

        [BsonElement("x")]
        public uint? X { get; set; }

        [BsonElement("y")]
        public uint? Y { get; set; }

        [BsonElement("inventoryId")]
        public string? InventoryId { get; set; }

        [BsonElement("socket")]
        public uint? Socket { get; set; }

        [BsonElement("colour")]
        public string? Colour { get; set; }

        public Item()
        {
            ItemId = string.Empty;
            Icon = string.Empty;
            Name = string.Empty;
            TypeLine = string.Empty;
            BaseType = string.Empty;
        }
    }
}
