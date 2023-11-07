namespace PoESnap.Services.CharacterService
{
    public interface ICharacterService
    {
        Models.Character GetCharacter(string characterName);
        Task<Models.Character> GetCharacterAsync(string characterName);
        void AddCharacter(string accountName, string characterName);
    }
}
