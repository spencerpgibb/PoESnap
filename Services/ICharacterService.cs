using PoESnap.Models;

namespace PoESnap.Services
{
    public interface ICharacterService
    {
        Character GetCharacter(string characterName);
        Task<Character> GetCharacterAsync(string characterName);
        void AddCharacter(string accountName, string characterName);
    }
}
