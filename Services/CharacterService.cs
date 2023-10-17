using Microsoft.AspNetCore.Mvc;
using PoESnap.Models;
using System.Text.Json;

namespace PoESnap.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly ILogger<CharacterService> _logger;
        private readonly List<Character> _characterList;
        private readonly HttpClient _httpClient;

        public CharacterService(ILogger<CharacterService> logger)
        {
            _logger = logger;
            _httpClient = new HttpClient();
            _characterList = new List<Character>();
        }

        public Character GetCharacter(string characterName)
        {
            if (_characterList == null || _characterList.Count == 0)
            {
                throw new Exception("No Characters present");
            }

            var character = _characterList.Find(c => c.Metadata != null && c.Metadata.Name == characterName);

            if (character == null)
            {
                throw new Exception("Character not found");
            }

            return character;       
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
            var result = await _httpClient.GetStringAsync($"https://www.pathofexile.com/character-window/get-items?accountName={accountName}&character={characterName}&realm=pc");

            var character = JsonSerializer.Deserialize<Character>(result);

            if (character != null)
            {
                _characterList.Add(character);
            }
        }
    }
}
