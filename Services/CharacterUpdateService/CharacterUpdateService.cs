using MongoDB.Bson.Serialization.Conventions;
using MongoDB.Driver;
using PoESnap.Services.CharacterService;

namespace PoESnap.Services.CharacterUpdateService
{
    public class CharacterUpdateService : ICharacterUpdateService
    {
        private readonly ILogger<CharacterUpdateService> _logger;
        private static string MongoConnectionString = "mongodb://localhost:27017";
        private readonly IMongoDatabase _characterDatabase;
        private readonly IMongoCollection<Character> _characterCollection;
        private bool _isStarted = false;

        public CharacterUpdateService(ILogger<CharacterUpdateService> logger) 
        {
            _logger = logger;

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
            RecurringTask(() => UpdateCharacters(), 1, cts.Token);
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

        public void UpdateCharacters()
        {
            _logger.LogInformation("RecurringTask executed.");
        }
    }
}
