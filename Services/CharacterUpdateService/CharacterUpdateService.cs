using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;
using PoESnap.Services.CharacterService;

namespace PoESnap.Services.CharacterUpdateService
{
    public class CharacterUpdateService : ICharacterUpdateService
    {
        private readonly ILogger<CharacterUpdateService> _logger;
        private readonly HttpClient _httpClient;
        private static string MongoConnectionString = "mongodb://localhost:27017";
        private readonly IMongoDatabase _characterDatabase;
        private readonly IMongoCollection<Character> _characterCollection;
        private bool _isStarted = false;

        public CharacterUpdateService(ILogger<CharacterUpdateService> logger) 
        {
            _logger = logger;
            _httpClient = new HttpClient();

            // This allows automapping of the camelCase database fields to our models. 
            var camelCaseConvention = new ConventionPack { new CamelCaseElementNameConvention() };
            ConventionRegistry.Register("CamelCase", camelCaseConvention, type => true);
            ConventionRegistry.Register("IgnoreExtraElements", camelCaseConvention, type => true);

            // Establish the connection to MongoDB and get the restaurants database
            var mongoClient = new MongoClient(MongoConnectionString);
            _characterDatabase = mongoClient.GetDatabase("poe_snap");
            _characterCollection = _characterDatabase.GetCollection<Character>("characters");
        }

        public void StartUpdates()
        {
            if (_isStarted)
                return;
            var cts = new CancellationTokenSource();
            RecurringTask(() => UpdateCharacters(), 15, cts.Token);
            _isStarted = true;
        }

        public void RecurringTask(Action action, int minutes, CancellationToken cancellationToken)
        {
            if (action == null)
            {
                return;
            }

            Task.Run(async () =>
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    action();
                    await Task.Delay(TimeSpan.FromMinutes(minutes));
                }
            }, cancellationToken);
        }

        public async void UpdateCharacters()
        {
            var _listOfExistingCharacters = _characterCollection.AsQueryable().Where(c => c.Metadata != null && c.Snapshots != null && c.Snapshots.Any()).ToList(); 

            foreach (var character in _listOfExistingCharacters)
            {
                TimeSpan timeSinceLastFetch = DateTime.UtcNow.Subtract(character.LastFetched);

                if (timeSinceLastFetch.TotalMinutes >= 10 && character.AccountName != null && character.Metadata != null && character.Metadata.Name != null)
                {
                    var result = await _httpClient.GetStringAsync($"https://www.pathofexile.com/character-window/get-items?accountName={character.AccountName}&character={character.Metadata.Name}&realm=pc");
                    var fetchTime = DateTime.UtcNow;

                    var modelCharacter = BsonSerializer.Deserialize<Models.Character>(result);

                    // Update snapshots for given character with items just fetched
                    var snapshotFilter = Builders<Character>.Filter.Eq(c => c.Metadata.Name, value: character.Metadata.Name);

                    character.Snapshots.Add(new CharacterSnapshot { Items = modelCharacter.Items, SnapshotFetchTime = DateTime.UtcNow });

                    var snapshotUpdate = Builders<Character>.Update.Set(c => c.Snapshots, character.Snapshots);

                    _characterCollection.UpdateOne(snapshotFilter, snapshotUpdate);

                    // Update last fetched time 
                    var fetchTimeFilter = Builders<Character>.Filter.Eq(c => c.Metadata.Name, character.Metadata.Name);

                    var fetchTimeUpdate = Builders<Character>.Update.Set(c => c.LastFetched, fetchTime);

                    _characterCollection.UpdateOne(fetchTimeFilter, fetchTimeUpdate);
                }
            }
        }
    }
}
