namespace PoESnap.Services.CharacterService
{
    public interface ICharacterService
    {
        Character GetCharacter(string characterName);
        Task<Character> GetCharacterAsync(string characterName);
        void AddCharacter(string accountName, string characterName);
    }
}
