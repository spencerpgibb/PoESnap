using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;
using PoESnap.Services.CharacterUpdateService;

namespace PoESnap.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private readonly ILogger<CharacterService> _logger;
        private readonly HttpClient _httpClient;
        private static string MongoConnectionString = "mongodb://localhost:27017";
        private readonly IMongoDatabase _characterDatabase;
        private readonly IMongoCollection<Character> _characterCollection;
        private readonly ICharacterUpdateService _characterUpdateService;

        public CharacterService(ILogger<CharacterService> logger, ICharacterUpdateService characterUpdateService)
        {
            _logger = logger;
            _characterUpdateService = characterUpdateService;
            _httpClient = new HttpClient();

            _characterUpdateService.StartUpdates();

            // This allows automapping of the camelCase database fields to our models. 
            var camelCaseConvention = new ConventionPack { new CamelCaseElementNameConvention() };
            ConventionRegistry.Register("CamelCase", camelCaseConvention, type => true);
            ConventionRegistry.Register("IgnoreExtraElements", camelCaseConvention, type => true);

            // Establish the connection to MongoDB and get the restaurants database
            var mongoClient = new MongoClient(MongoConnectionString);
            _characterDatabase = mongoClient.GetDatabase("poe_snap");
            _characterCollection = _characterDatabase.GetCollection<Character>("characters");
        }

        public Character GetCharacter(string characterName)
        {
            if (_characterCollection == null)
            {
                throw new Exception("No Characters present");
            }

            try
            {
                var character = _characterCollection.AsQueryable().Where(r => r.Metadata != null && r.Metadata.Name == characterName).FirstOrDefault();

                if (character == null)
                {
                    throw new Exception("Character not found");
                }

                return character;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
                throw;
            }
        }

        public async Task<Character> GetCharacterAsync(string characterName)
        {
            if (characterName == null)
            {
                throw new BadHttpRequestException("characterName cannot be null");
            }

            for (int i = 0; i < 3; i++)
            {
                try
                {
                    return GetCharacter(characterName);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex.Message);
                }

                await Task.Delay(500);
            }
            throw new Exception("Character not found");
        }

        public async void AddCharacter(string accountName, string characterName)
        {
            var decodedAccountName = System.Uri.UnescapeDataString(accountName);
            var decodedCharacterName = System.Uri.UnescapeDataString(characterName);

            var character = _characterCollection.AsQueryable().Where(c => c.Metadata != null && c.Metadata.Name == decodedCharacterName).FirstOrDefault();

            if (character != null)
                return;

            var result = await _httpClient.GetStringAsync($"https://www.pathofexile.com/character-window/get-items?accountName={decodedAccountName}&character={decodedCharacterName}&realm=pc");

            var modelCharacter = BsonSerializer.Deserialize<Models.Character>(result);

            character = new Character();

            character.Metadata = modelCharacter.Metadata;
            character.LastFetched = DateTime.UtcNow;
            character.AccountName = decodedAccountName;
            character.Snapshots.Add(new CharacterSnapshot { Items = modelCharacter.Items, SnapshotFetchTime = DateTime.UtcNow });

            _characterCollection.InsertOne(character);
        }
    }
}
